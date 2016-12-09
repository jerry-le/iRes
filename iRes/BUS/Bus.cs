﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Title.DAO;
using Title.VO;

namespace Title.BUS {
    class Bus {
        public static DataTable GetListNhanVien() {
            return Dao.GetListNhanVien();
        }

        public static int InsertNhanVien(NhanVien nv) {
            return Dao.InsertNhanVien(nv);
        }

        public static int UpdateNhanVien(NhanVien nv) {
            return Dao.UpdateNhanVien(nv);
        }
        
        public static int DeleteNhanVien(NhanVien nv) {
            return Dao.DeleteNhanVien(nv);
        }

        public static DataTable GetListKhachHang() {
            return Dao.GetListKhachHang();
        }

        public static int InsertKhachHang(KhachHang kh) {
            return Dao.InsertKhachHang(kh);
        }

        public static int UpdateKhachHang(KhachHang kh) {
            return Dao.UpdateKhachHang(kh);
        }

        public static int  DeleteKhachHang(KhachHang kh) {
            return Dao.DeleteKhachHang(kh);
        }
        
        public static DataTable GetListMonAn() {
            return Dao.GetListMonAn();
        }

        public static DataTable GetMaMonNext()
        {
            return Dao.GetMaMonNext();
        }

        public static int InsertMonAn(MonAn monAn)
        {
            return Dao.InsertMonAn(monAn);
        }

        public static DataTable GetListMonAnByNhomMon(string maNhom) {
            return Dao.GetListMonAnByNhomMon(maNhom);
        }

        public static DataTable GetListNhomMon() {
            return Dao.GetListNhomMon();
        }

        public static DataTable GetListBanAn() {
            return Dao.GetListBanAn();
        }

        public static int UpdateBanAn(BanAn banAn) {
            return Dao.UpdateBanAn(banAn);
        }

        public static int setBanAnTrong(BanAn banAn)
        {
            return Dao.SetBanAnTrong(banAn);
        }

        public static DataTable GetListChiTietHoaDon(BanAn banAn) {
            return Dao.GetListChiTietHoaDon(banAn);
        }

        public static int InsertChiTietHoaDon(ChiTietHoaDon chiTietHoaDon) {
            return Dao.InsertChiTietHoaDon(chiTietHoaDon);
        }

        public static int InsertHoaDon(HoaDon hoaDon) {
            return Dao.InsertHoaDon(hoaDon);
        }

        public static DataTable GetLastHoaDon() {
            return Dao.GetLastHoaDon();
        }

        public static int EditHoaDon(HoaDon hoaDon)
        {
            return Dao.EditHoaDon(hoaDon);
        }

        public static DataTable GetInfoHoaDon(string maHD)
        {
            return Dao.GetInfoHoaDon(maHD);
        }

        public static int DeleteChiTieHD(string maHD,string maMon)
        {
            return Dao.DeleteChiTietHD(maHD,maMon);
        }

        public static DataTable GetInfoKhachHangTheoMaHoaDon(BanAn banAn)
        {
            return Dao.GetInfoKhachHangQuaMaHoaDon(banAn);
        }

        public static DataTable GetInfoHoaDonTheoBanAn(BanAn banAn)
        {
            return Dao.GetInfoHoaDonTheoBanAn(banAn);
        }
    }
}
