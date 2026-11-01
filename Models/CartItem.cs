using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoangHaPC_Demo.Models
{
    public class CartItem
    {
        public string Ten { get; set; }      // Tên sản phẩm
        public long Gia { get; set; }        // Giá 1 sản phẩm
        public string Hinh { get; set; }     // Đường dẫn hình
        public int SoLuong { get; set; }     // Số lượng

        public long ThanhTien
        {
            get { return Gia * SoLuong; }
        }
    }
}