using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DAOImpl;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.Model;
using QuanLyKhachSan.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan.Views
{
    public partial class Booking : Form
    {

        ICustomerDAO customerDao = new CustomerDAOImpl();
        IReservationDAO reservationDao = new ReservationDAOImpl();
        IBookingHistoryDAO bookingHistoryDAO = new BookingHistoryDAOImpl();
        // danh sách các loại phòng của ks
        private BindingList<Room> roomList = new BindingList<Room>();
        private BindingList<String> roomType = new BindingList<String>();
        // danh sách khách đặt phòng
        private BindingList<ReservationDTO> reservations = new BindingList<ReservationDTO>();
        private Validation validation = new Validation();

        //phòng khách đặt
        private Room roomBooking;
        public Booking()
        {
            SqlConnection conn = Connection.GetConnection();
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
            dtgListReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HandlerCommon();
            Connection.CloseConnection(conn);
        }
        private void HandlerCommon()
        {
            SqlConnection conn = Connection.GetConnection();
            DataList(conn);
            dtgListReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dpCheckIn.Value = DateTime.Now;
            cbbTypeRoom.DataSource = roomType;

            txtSearchReservation.GotFocus += new EventHandler(textBox_GotFocus);
            void textBox_GotFocus(object sender, EventArgs e)
            {
                txtSearchReservation.Text = "";
            }
            Connection.CloseConnection(conn);
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
            BookingHistory bookingHistory = new BookingHistory();
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
            int insertedCustomerId = 0;
            int insertedReservationId = 0;
            // dialog xác nhận lại thông tin khách hàng
            string msg = "Họ tên khách hàng: " + customer.Name + "\n" + "Căn Cước công dân: " + customer.CitizenIdNumber + "\n"
                + "Địa chỉ :" + customer.Address + "\n"
                + "Số điện thoại: " + customer.PhoneNumber + "\n"
                + "Ngày nhận phòng: " + reservation.CheckInDate + "\n"
                + "Ngày trả phòng(dự kiến): " + reservation.CheckOutDate;
            DialogResult reconfirm = MessageBox.Show(msg, "Kiểm tra lại thông tin", MessageBoxButtons.YesNo);

            if (reconfirm == DialogResult.Yes && txtCCCD.Text.Length == 12)
            {
                // check nếu khách hàng tồn tại thì dùng luôn dữ liệu cũ của khách hàng
                if (!string.IsNullOrEmpty(lbCustomerId.Text))
                {
                    insertedCustomerId = int.Parse(lbCustomerId.Text);
                }
                else
                {   // thêm dữ liệu vào bảng customer
                    try
                    {
                        insertedCustomerId = customerDao.save(customer);
                        customer.CustomerId= insertedCustomerId;
                    }
                    catch { }

                }
                // thêm dữ liệu vào bảng đặt phòng (Reservation)
                SqlConnection conn = Connection.GetConnection();
                reservation.Customer.CustomerId = insertedCustomerId;
                insertedReservationId = reservationDao.save(reservation);
                reservation.ReservationId = insertedReservationId;
                bookingHistory.Reservation= reservation;
                bookingHistory.Customer = customer;
                bookingHistory.TotalPrice = roomBooking.Price;
                bookingHistory.BookingTime = DateTime.Now;
                if (bookingHistoryDAO.save(bookingHistory) > 0)
                {
                    MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReservationDTO reservationDTO = new ReservationDTO();
                    reservationDTO.CheckInDate = reservation.CheckInDate;
                    reservationDTO.CheckOutDate = reservation.CheckOutDate;
                    reservationDTO.PhoneNumber = customer.PhoneNumber;
                    reservationDTO.CustomerName = customer.Name;
                    reservationDTO.PaymentStatus = reservation.PaymentStatus;
                    reservationDTO.RoomType = roomBooking.RoomType;
                    reservations.Add(reservationDTO);
                    dtgListReservation.DataSource = reservations;
                    btnDatPhong.Enabled = false;
                    sorting();
                    clearValueTextBox();
                }
                Connection.CloseConnection(conn);
            }

        }
       /* public int insertHistoryBooking(int reservationId, DateTime BookingTime, decimal totalPrice, int customerId, SqlConnection conn)
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
        }*/

        public void DataList(SqlConnection conn)
        {
            string sqlQuery = @"select c.Name,r.RoomType,v.CheckInDate,v.CheckOutDate,v.PaymentStatus,c.PhoneNumber FROM dbo.Customer as c inner join dbo.Reservation as v on c.CustomerId=v.CustomerId inner join dbo.Room as r on v.RoomId=r.RoomId where v.PaymentStatus like '%chưa thanh toán%';";
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReservationDTO reservationDTO = new ReservationDTO();
                    reservationDTO.CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate"));
                    reservationDTO.CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate"));
                    reservationDTO.CustomerName = reader.GetString(reader.GetOrdinal("Name"));
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
            SqlConnection conn = Connection.GetConnection();
            string cccd = txtCCCD.Text;
            validation.validate(txtCCCD, TypeRegex.CCCD, errCCCD);
            if (cccd.Length > 11)
            {
                btnDatPhong.Enabled = validation.checkAll() && !validation.validate(txtCCCD, TypeRegex.CCCD, errCCCD) ? true : false;

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
            Connection.CloseConnection(conn);
        }

        private void dpCheckout_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateSelected = dpCheckout.Value;
            if (dateSelected < DateTime.Now)
            {
                MessageBox.Show("Thời gian trả phòng không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dpCheckout.Value = DateTime.Now;
            }
        }
        private void sorting()
        {
            string sortingSelected = cbbSortReservation.SelectedItem as string;
            if (sortingSelected != null)
            {
                if (sortingSelected.Equals("Ngày rời khỏi giảm dần"))
                {
                    var sortedReservations = new BindingList<ReservationDTO>(reservations.OrderByDescending(r => r.CheckOutDate).ToList());
                    reservations = sortedReservations;
                    dtgListReservation.DataSource = reservations;
                }
                else if (sortingSelected.Equals("Ngày rời khỏi tăng dần"))
                {
                    var sortedReservations = new BindingList<ReservationDTO>(reservations.OrderBy(r => r.CheckOutDate).ToList());
                    reservations = sortedReservations;
                    dtgListReservation.DataSource = reservations;
                }
            }


        }

        private void cbbSortReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorting();
        }
        private void txtSearchReservation_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.GetConnection();
            string keyword = txtSearchReservation.Text.Trim();
            string sqlQuery = @"select c.Name,r.RoomType,v.CheckInDate,v.CheckOutDate,v.PaymentStatus,c.PhoneNumber FROM dbo.Customer as c inner join dbo.Reservation as v on c.CustomerId=v.CustomerId inner join dbo.Room as r on v.RoomId=r.RoomId where c.Name like @Name";
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                reservations.Clear();
                if (!string.IsNullOrEmpty(keyword))
                {
                    command.Parameters.AddWithValue("@Name", "%" + keyword + "%");
                }
                else
                {
                    command.Parameters.AddWithValue("@Name", "%%");
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReservationDTO reservationDTO = new ReservationDTO();
                        reservationDTO.CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate"));
                        reservationDTO.CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate"));
                        reservationDTO.CustomerName = reader.GetString(reader.GetOrdinal("Name"));
                        reservationDTO.RoomType = reader.GetString(reader.GetOrdinal("RoomType"));
                        reservationDTO.PaymentStatus = reader.GetString(reader.GetOrdinal("PaymentStatus"));
                        reservationDTO.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                        reservations.Add(reservationDTO);
                    }
                }
                dtgListReservation.DataSource = reservations;
                sorting();
            }
            Connection.CloseConnection(conn);
        }

        private void txtNumberPhone_TextChanged(object sender, EventArgs e)
        {
            validation.validate(txtNumberPhone, TypeRegex.NumberPhone, errNumberPhone);
            btnDatPhong.Enabled = validation.checkAll() && txtCCCD.Text.Length == 12 ? true : false;
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            btnDatPhong.Enabled = validation.checkAll() && txtCCCD.Text.Length == 12 ? true : false;
            validation.validate(txtFullName, TypeRegex.Name, errName);
        }

    }
}
