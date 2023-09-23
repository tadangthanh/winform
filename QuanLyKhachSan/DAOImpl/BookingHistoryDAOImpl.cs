using QuanLyKhachSan.DAO;
using QuanLyKhachSan.Mapper;
using QuanLyKhachSan.Model;
using QuanLyKhachSan.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAOImpl
{
    internal class BookingHistoryDAOImpl : Commons<BookingHistory>, IBookingHistoryDAO
    {
        BookingHistoryMapper bookingHistoryMapper = new BookingHistoryMapper();
        public int delete(int id)
        {
            int result = 0;
            SqlConnection sqlConn = Connection.GetConnection();
            string sqlQuery = "Delete from BookingHistory where BookingHistoryId = @id";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConn))
            {
                command.Parameters.AddWithValue("@id", id);
                result = command.ExecuteNonQuery();
            }
            Connection.CloseConnection(sqlConn);
            return result;
        }

        public List<BookingHistory> findAll()
        {
            List<BookingHistory> list = new List<BookingHistory>();
            SqlConnection sqlConn = Connection.GetConnection();
            string sqlQuery = "Select * from BookingHistory";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(bookingHistoryMapper.mappRow(reader));
                    }
                }
            }
            Connection.CloseConnection(sqlConn);
            return list;
        }

        public BookingHistory findOne(int id)
        {
            BookingHistory booking = null;
            SqlConnection sqlConn = Connection.GetConnection();
            string sqlQuery = "Select * from BookingHistory where BookingHistoryId = @id";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        booking = bookingHistoryMapper.mappRow(reader);
                    }
                }
            }
            return booking;
        }

        public int save(BookingHistory booking)
        {
            int result = 0;
            SqlConnection sqlConn = Connection.GetConnection();
            string sqlQuery = "INSERT INTO BookingHistory (ReservationId,BookingTime,TotalPrice,CustomerId) OUTPUT INSERTED.BookingHistoryId VALUES (@ReservationId,@BookingTime,@TotalPrice,@CustomerId)";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConn))
            {
                setParameter(command, sqlQuery, booking.Reservation.ReservationId, booking.BookingTime, booking.TotalPrice,booking.Customer.CustomerId);
                result = (int)command.ExecuteScalar();
            }
            Connection.CloseConnection(sqlConn);
            return result;
        }

        public int update(BookingHistory booking)
        {
            int result = 0;
            SqlConnection sqlConn = Connection.GetConnection();
            string sqlQuery = "UPDATE BookingHistory set ReservationId = @ReservationId,BookingTime = @BookingTime, TotalPrice = @TotalPrice, CustomerId = @CustomerId) where BookingHistoryId= @BookingHistoryId";
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConn))
            {
                setParameter(command, sqlQuery, booking.Reservation.ReservationId, booking.BookingTime, booking.TotalPrice, booking.Customer.CustomerId,booking.BookingHistoryId);
                result = (int)command.ExecuteNonQuery();
            }
            Connection.CloseConnection(sqlConn);
            return result;
        }
    }
}
