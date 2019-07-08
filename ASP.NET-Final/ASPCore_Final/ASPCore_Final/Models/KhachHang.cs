﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPCore_Final.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            BinhLuanSp = new HashSet<BinhLuanSp>();
            HoaDon = new HashSet<HoaDon>();
            HoiDap = new HashSet<HoiDap>();
            YeuThich = new HashSet<YeuThich>();
        }
        [Display(Name = "Mã KH")]
        public int MaKh { get; set; }
        [Display(Name = "Mật Khẩu")]
        public string MatKhau { get; set; }
        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "SĐT")]
        public string DienThoai { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Hình")]
        public string Hinh { get; set; }
        [Display(Name = "Loại KH")]
        public bool? LoaiKH { get; set; }
        [Display(Name = "Tài khoản")]
        public string TaiKhoan { get; set; }
        [Display(Name = "Giới Tính")]
        public string GioiTinh { get; set; }
        [Display(Name = "Ngày Sinh")]
        public DateTime? NgaySinh { get; set; }
        [Display(Name = "Trạng thái HĐ")]
        public bool? TrangThaiHd { get; set; }

        public ICollection<BinhLuanSp> BinhLuanSp { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
        public ICollection<HoiDap> HoiDap { get; set; }
        public ICollection<YeuThich> YeuThich { get; set; }
    }
}
