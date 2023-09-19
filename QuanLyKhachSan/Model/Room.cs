using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Model
{
    internal class Room
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public string Amenities { get; set; }
        public string Status { get; set; }
        public string UrlImg { get; set; }
        public string Note { get; set; }
        public string Desc { get; set; }
    }
}
