﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASPCore_Final.Models
{
    public partial class ESHOPContext : DbContext
    {
        public ESHOPContext()
        {
        }

        public ESHOPContext(DbContextOptions<ESHOPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BannerQc> BannerQc { get; set; }
        public virtual DbSet<BinhLuanSp> BinhLuanSp { get; set; }
        public virtual DbSet<ChiTietHd> ChiTietHd { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
        public virtual DbSet<HangHoa> HangHoa { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoiDap> HoiDap { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<Loai> Loai { get; set; }
        public virtual DbSet<LoaiTinTuc> LoaiTinTuc { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyen { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHang { get; set; }
        public virtual DbSet<SanPhamKho> SanPhamKho { get; set; }
        public virtual DbSet<TbThongKe> TbThongKe { get; set; }
        public virtual DbSet<TinTuc> TinTuc { get; set; }
        public virtual DbSet<TrangThai> TrangThai { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }
        public virtual DbSet<YeuThich> YeuThich { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=ESHOP;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BannerQc>(entity =>
            {
                entity.HasKey(e => e.MaQc);

                entity.ToTable("BannerQC");

                entity.Property(e => e.MaQc).HasColumnName("MaQC");

                entity.Property(e => e.Hinh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThucQc)
                    .HasColumnName("NgayKetThucQC")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.NoiDungQc)
                    .HasColumnName("NoiDungQC")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BinhLuanSp>(entity =>
            {
                entity.HasKey(e => e.MaBl);

                entity.ToTable("BinhLuanSP");

                entity.Property(e => e.MaBl).HasColumnName("MaBL");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.NgayBl)
                    .HasColumnName("NgayBL")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasMaxLength(100);

                entity.HasOne(d => d.MaHhNavigation)
                    .WithMany(p => p.BinhLuanSp)
                    .HasForeignKey(d => d.MaHh)
                    .HasConstraintName("FK_BinhLuanSP_HangHoa");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.BinhLuanSp)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_BinhLuanSP_KhachHang");
            });

            modelBuilder.Entity<ChiTietHd>(entity =>
            {
                entity.HasKey(e => e.MaCt);

                entity.ToTable("ChiTietHD");

                entity.Property(e => e.MaCt).HasColumnName("MaCT");

                entity.Property(e => e.KichCo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.MaHh).HasColumnName("MaHH");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.ChiTietHd)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietHD__MaHD__25869641");

                entity.HasOne(d => d.MaHhNavigation)
                    .WithMany(p => p.ChiTietHd)
                    .HasForeignKey(d => d.MaHh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietHD__MaHH__267ABA7A");
            });

            modelBuilder.Entity<ChiTietPhieuNhap>(entity =>
            {
                entity.HasKey(e => new { e.MaPn, e.MaHh, e.KichCo });

                entity.Property(e => e.MaPn).HasColumnName("MaPN");

                entity.Property(e => e.MaHh).HasColumnName("MaHH");

                entity.Property(e => e.KichCo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SoLuongNhap).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MaHhNavigation)
                    .WithMany(p => p.ChiTietPhieuNhap)
                    .HasForeignKey(d => d.MaHh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietPhieuNhap_HangHoa");

                entity.HasOne(d => d.MaPnNavigation)
                    .WithMany(p => p.ChiTietPhieuNhap)
                    .HasForeignKey(d => d.MaPn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietPhieuNhap_PhieuNhapHang");
            });

            modelBuilder.Entity<HangHoa>(entity =>
            {
                entity.HasKey(e => e.MaHh);

                entity.Property(e => e.MaHh).HasColumnName("MaHH");

                entity.Property(e => e.Hinh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaLoai)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MaNcc)
                    .IsRequired()
                    .HasColumnName("MaNCC")
                    .HasMaxLength(50);

                entity.Property(e => e.TenHh)
                    .IsRequired()
                    .HasColumnName("TenHH")
                    .HasMaxLength(60);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.HangHoa)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HangHoa_Loai");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.HangHoa)
                    .HasForeignKey(d => d.MaNcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HangHoa__MaNCC__15502E78");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(50);

                entity.Property(e => e.MaVoucher)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayDat).HasColumnType("datetime");

                entity.Property(e => e.NgayGiao).HasColumnType("datetime");

                entity.Property(e => e.SdtNguoinhan)
                    .HasColumnName("SDT_nguoinhan")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDon_KhachHang");

                entity.HasOne(d => d.MaTrangThaiNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.MaTrangThai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaTrangT__1ED998B2");
            });

            modelBuilder.Entity<HoiDap>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.CauHoi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayDua).HasColumnType("date");

                entity.Property(e => e.TraLoi).HasMaxLength(50);

                entity.Property(e => e.TrangThaiTl).HasColumnName("TrangThaiTL");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoiDap)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoiDap_KhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HoiDap)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_HoiDap_NhanVien");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.DiaChi).HasMaxLength(60);

                entity.Property(e => e.DienThoai).HasMaxLength(24);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.Hinh).HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LoaiKH).HasColumnName("LoaiKH");

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThaiHd).HasColumnName("TrangThaiHD");
            });

            modelBuilder.Entity<Loai>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<LoaiTinTuc>(entity =>
            {
                entity.HasKey(e => e.LoaiTt);

                entity.Property(e => e.LoaiTt)
                    .HasColumnName("LoaiTT")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TenTt)
                    .HasColumnName("TenTT")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNcc);

                entity.Property(e => e.MaNcc)
                    .HasColumnName("MaNCC")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Hinh).HasMaxLength(50);

                entity.Property(e => e.TenCongTy)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaPq).HasColumnName("MaPQ");

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.TrangThaiHd).HasColumnName("TrangThaiHD");

                entity.HasOne(d => d.MaPqNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.MaPq)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__MaPQ__1BFD2C07");
            });

            modelBuilder.Entity<PhanQuyen>(entity =>
            {
                entity.HasKey(e => e.MaPq);

                entity.Property(e => e.MaPq).HasColumnName("MaPQ");
            });

            modelBuilder.Entity<PhieuNhapHang>(entity =>
            {
                entity.HasKey(e => e.MaPn);

                entity.Property(e => e.MaPn).HasColumnName("MaPN");

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");
            });

            modelBuilder.Entity<SanPhamKho>(entity =>
            {
                entity.HasKey(e => new { e.MaSpKho, e.MaHh });

                entity.ToTable("SanPham_Kho");

                entity.Property(e => e.MaSpKho)
                    .HasColumnName("MaSP_Kho")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KichCo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaHhNavigation)
                    .WithMany(p => p.SanPhamKhoNavigation)
                    .HasForeignKey(d => d.MaHh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SanPham_Kho_HangHoa");
            });

            modelBuilder.Entity<TbThongKe>(entity =>
            {
                entity.HasKey(e => e.MaTb);

                entity.ToTable("TB_ThongKe");

                entity.Property(e => e.MaTb).HasColumnName("MaTB");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinTuc>(entity =>
            {
                entity.HasKey(e => e.MaTt);

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.Hinh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoaiTt)
                    .HasColumnName("LoaiTT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasColumnType("text");

                entity.Property(e => e.TieuDe).HasMaxLength(100);

                entity.HasOne(d => d.LoaiTtNavigation)
                    .WithMany(p => p.TinTuc)
                    .HasForeignKey(d => d.LoaiTt)
                    .HasConstraintName("FK_TinTuc_LoaiTinTuc");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.TinTuc)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_TinTuc_NhanVien");
            });

            modelBuilder.Entity<TrangThai>(entity =>
            {
                entity.HasKey(e => e.MaTrangThai);

                entity.Property(e => e.MaTrangThai).ValueGeneratedNever();

                entity.Property(e => e.TenTrangThai)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.MaVc);

                entity.Property(e => e.MaVc)
                    .HasColumnName("MaVC")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.TongTienDk).HasColumnName("TongTienDK");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<YeuThich>(entity =>
            {
                entity.HasKey(e => e.MaYt);

                entity.Property(e => e.MaYt).HasColumnName("MaYT");

                entity.Property(e => e.DiemDanhGia).HasDefaultValueSql("((5))");

                entity.Property(e => e.MaBl).HasColumnName("MaBL");

                entity.Property(e => e.MaHh).HasColumnName("MaHH");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.NgayChon).HasColumnType("datetime");

                entity.HasOne(d => d.MaHhNavigation)
                    .WithMany(p => p.YeuThich)
                    .HasForeignKey(d => d.MaHh)
                    .HasConstraintName("FK_YeuThich_HangHoa");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.YeuThich)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_YeuThich_KhachHang");
            });
        }
    }
}
