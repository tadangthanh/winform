using QuanLyKhachSan.DTO;
using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan.Views
{
    public partial class Booking : Form
    {
        private SqlConnection conn = null;
        private string strCon = @"Data Source=DESKTOP-CR5N4N8\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        private BindingList<Room> roomList = new BindingList<Room>();
        private BindingList<String> roomType = new BindingList<String>();
        private BindingList<ReservationDTO> reservations = new BindingList<ReservationDTO>();
        private Room roomBooking;
        public Booking()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strCon);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sqlQuery = "SELECT * FROM Room";
            SqlCommand command = new SqlCommand(sqlQuery, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Room room = new Room();
                room.RoomId = reader.GetInt32(0);
                room.RoomType = reader.GetString(1);
                room.Price = reader.GetDecimal(2);
                room.Status = reader.GetString(3);
                room.Amenities = reader.GetString(4);
                room.UrlImg = reader.GetString(5);
                room.Note = reader.GetString(6);
                room.Desc = reader.GetString(7);
                roomType.Add(room.RoomType);
                roomList.Add(room);
            }
            reader.Close();
            InitializeComponent();
            DataList(conn);
            dtgListReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbTypeRoom.DataSource = roomType;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbUrlImg_Click(object sender, EventArgs e)
        {

        }

        private void cbbTypeRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomType = cbbTypeRoom.SelectedItem as string;

            if (selectedRoomType != null)
            {
                //  Room selectedRoom = null;
                foreach (Room room in roomList)
                {
                    if (room.RoomType.Equals(selectedRoomType))
                    {
                        roomBooking = room;
                        break;
                    }
                }

                if (roomBooking != null)
                {
                    lbPrice.Text = roomBooking.Price.ToString();
                    lbNote.Text = roomBooking.Note.ToString();
                    txtAmen.Text = roomBooking.Amenities.ToString();
                    txtDesc.Text = roomBooking.Desc.ToString();
                    lbStatus.Text = roomBooking.Status.ToString();
                    lbUrlImg.Text = roomBooking.UrlImg.ToString();
                }
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            Reservation reservation = new Reservation();
            reservation.CheckInDate = DateTime.Now;
            reservation.CheckOutDate = dpCheckout.Value;
            string fullName = txtFullName.Text;
            string numberPhone = txtNumberPhone.Text;
            string address = txtAddress.Text;
            string cccd = txtCCCD.Text;
            customer.CitizenIdNumber = cccd;
            customer.Name = fullName;
            customer.Address = address;
            customer.PhoneNumber = numberPhone;
            reservation.Customer = customer;
            reservation.ContactInformation = customer.PhoneNumber;
            reservation.PaymentStatus = "Chưa thanh toán";
            reservation.Room = roomBooking;
            string sqlQuery;
            int insertedCustomerId = 0;
            int insertedReservationId = 0;
            // check nếu khách hàng tồn tại thì dùng luôn dữ liệu cũ của khách hàng
            if (!string.IsNullOrEmpty(lbCustomerId.Text))
            {
                insertedCustomerId = int.Parse(lbCustomerId.Text);
            }
            else
            {
                // thêm dữ liệu vào bảng customer
                try
                {
                    sqlQuery = "INSERT INTO Customer (CitizenIdNumber,Name, Address, PhoneNumber) OUTPUT INSERTED.CustomerId VALUES (@CitizenIdNumber,@fullName, @address, @numberPhone)";
                    using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@fullName", fullName);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@numberPhone", numberPhone);
                        command.Parameters.AddWithValue("@CitizenIdNumber", cccd);
                        insertedCustomerId = (int)command.ExecuteScalar();
                    }
                }
                catch { }

            }

            // thêm dữ liệu vào bảng đặt phòng (Reservation)
            sqlQuery = "INSERT INTO Reservation (RoomId, CheckInDate, CheckOutDate,CustomerId," +
                    "ContactInformation,PaymentStatus) OUTPUT INSERTED.ReservationId VALUES " +
                    "(@roomId, @checkInDate, @checkOutDate,@customerId,@contactInformation,@paymentStatus)";
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {

                command.Parameters.AddWithValue("@roomId", reservation.Room.RoomId);
                command.Parameters.AddWithValue("@checkInDate", reservation.CheckInDate);
                command.Parameters.AddWithValue("@checkOutDate", reservation.CheckOutDate);
                command.Parameters.AddWithValue("@customerId", insertedCustomerId);
                command.Parameters.AddWithValue("@contactInformation", reservation.ContactInformation);
                command.Parameters.AddWithValue("@paymentStatus", reservation.PaymentStatus);
                insertedReservationId = (int)command.ExecuteScalar();
                if (insertHistoryBooking(insertedReservationId, DateTime.Now, roomBooking.Price, insertedCustomerId, conn)>0)
                {
                    MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearValueTextBox();
                }
            }
        }
        public int insertHistoryBooking(int reservationId, DateTime BookingTime, decimal totalPrice,int customerId, SqlConnection conn)
        {
            try
            {
                string sqlQuery = "INSERT INTO BookingHistory (ReservationId, BookingTime, TotalPrice,CustomerId) OUTPUT INSERTED.BookingHistoryId VALUES " +
                   "(@reservationId, @BookingTime, @totalPrice,@CustomerId)";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@reservationId", reservationId);
                    command.Parameters.AddWithValue("@BookingTime", BookingTime);
                    command.Parameters.AddWithValue("@totalPrice", totalPrice);
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    return (int)command.ExecuteScalar();
                }
            }
            catch { return 0; }
        }
        public void DataList(SqlConnection conn)
        {
            string sqlQuery = "select c.Name,r.RoomType,v.CheckInDate,v.CheckOutDate,v.PaymentStatus,c.PhoneNumber FROM dbo.Customer as c inner join dbo.Reservation as v on c.CustomerId=v.CustomerId inner join dbo.Room as r on v.RoomId=r.RoomId;";
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReservationDTO reservationDTO = new ReservationDTO();
                    reservationDTO.CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate"));
                    reservationDTO.CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate"));
                    reservationDTO.CustomerName= reader.GetString(reader.GetOrdinal("Name"));
                    reservationDTO.RoomType = reader.GetString(reader.GetOrdinal("RoomType"));
                    reservationDTO.PaymentStatus = reader.GetString(reader.GetOrdinal("PaymentStatus"));
                    reservationDTO.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                    reservations.Add(reservationDTO);
                }
                reader.Close();
            }
            dtgListReservation.DataSource = reservations;
        }
        public void clearValueTextBox()
        {
            txtAddress.Text = "";
            txtCCCD.Text = "";
            txtFullName.Text = "";
            txtNumberPhone.Text = "";
        }
        //load dữ liệu cũ vào textbox nếu khách hàng tồn tại
        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text;
            if (cccd.Length > 11)
            {
                btnDatPhong.Enabled = true;
                try
                {
                    string sqlQuery = "SELECT * FROM Customer WHERE CitizenIdNumber = @cccd";
                    using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                    {
                        command.Parameters.AddWithValue("@cccd", cccd);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Đã có dữ liệu của khách hàng cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                int id = reader.GetInt32(reader.GetOrdinal("CustomerId"));
                                string fullName = reader.GetString(reader.GetOrdinal("Name"));
                                string address = reader.GetString(reader.GetOrdinal("Address"));
                                string phoneNumer = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                                string citizenIdNumber = reader.GetString(reader.GetOrdinal("CitizenIdNumber"));
                                txtAddress.Text = address;
                                txtFullName.Text = fullName;
                                txtNumberPhone.Text = phoneNumer;
                                lbCustomerId.Text = id.ToString();
                            }
                        }

                    }
                }
                catch
                {

                }
            }
        }

        
    }
}
