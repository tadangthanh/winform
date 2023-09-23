using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Mapper
{
    internal class BookingHistoryMapper : RowMapper<BookingHistory>
    {
        public BookingHistory mappRow(SqlDataReader reader)
        {
            BookingHistory booking = new BookingHistory();
            booking.BookingHistoryId = reader.GetInt32(reader.GetOrdinal("BookingHistoryId"));
            booking.BookingTime = reader.GetDateTime(reader.GetOrdinal("BookingTime"));
            booking.TotalPrice = reader.GetDecimal(reader.GetOrdinal("TotalPrice"));
            return booking;
        }
    }
}
