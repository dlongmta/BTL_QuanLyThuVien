using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class TheLoai_BUS
    {
        public static int KetNoi()
        {
            return sqlConnectionData.connection() == null ? 0 : 1;
        }
        //Load danh sách sinh viên
        public static DataTable DanhSachTL()
        {
            return TheLoai_DAO.LoadDSTheLoai();
        }
        public static string LastMaTL()
        {
            return TheLoai_DAO.LastMaTL();
        }
        public static void themTL(string maTL,string tenTL)
        {
            TheLoai_DAO.themTL(maTL, tenTL);
        }
        public static void suaTL(string maTL, string tenTL)
        {
            TheLoai_DAO.suaTL(maTL, tenTL);
        }
        public static void xoaTL(string maTL)
        {
            TheLoai_DAO.xoaTL(maTL);
        }
        public static DataTable DStenTL()
        {
            return TheLoai_DAO.DStenTL();
        }
        public static string MaTL(string s)
        {
            return TheLoai_DAO.MaTL(s);
        }
    }
    public class DauSach_BUS
    {
        public static DataTable LoadDSDauSach()
        {
            return DauSach_DAO.LoadDSDauSach();

        }
        public static string LastMaDS()
        {
            return DauSach_DAO.LastMaDS();
        }
        public static void themDS(string maDS, string tenDS, string maTL, string tenTG, string NXB, string giaSach, int sl1, int sl2)
        {
            DauSach_DAO.themDS(maDS, tenDS, maTL, tenTG, NXB, giaSach, sl1, sl2);
        }
        public static void suaDS_ten(string maDS, string s)
        {
            DauSach_DAO.suaDS_ten(maDS, s);
        }
        public static void suaDS_tl(string maDS, string s)
        {
            DauSach_DAO.suaDS_tl(maDS, s);
        }
        public static void suaDS_tg(string maDS, string s)
        {
            DauSach_DAO.suaDS_tg(maDS, s);
        }
        public static void suaDS_nxb(string maDS, string s)
        {
            DauSach_DAO.suaDS_nxb(maDS, s);
        }
        public static void suaDS_giasach(string maDS, string s)
        {
            DauSach_DAO.suaDS_giasach(maDS, s);
        }
        public static void xoaDS(string maDS)
        {
            DauSach_DAO.xoaDS(maDS);
        }
        public static DataTable dsTenDS()
        {
            return DauSach_DAO.dsTenDS();
        }
    }
    public class Sach_BUS
    {
        public static DataTable LoadDSSach(string maDS)
        {
            return Sach_DAO.LoadDSSach(maDS);
        }
        public static string LastMaSach()
        {
            return Sach_DAO.LastMaSach();
        }
        public static void themSach(string maDS, string maSach, string tt, string ttm)
        {
            Sach_DAO.themSach(maDS, maSach, tt, ttm);
        }
        public static void xoaSach(string maSach)
        {
            Sach_DAO.xoaSach(maSach);
        }
        public static DataTable dsmaSach(string s)
        {
            return Sach_DAO.dsmaSach(s);
        }
    }
    public class DocGia_BUS
    {
        public static DataTable DanhSachDG()
        {
            return DocGia_DAO.DanhSachDG();
        }
        public static string LastMaDG()
        {
            return DocGia_DAO.LastMaDG();
        }
        public static void themDG(string maDG, string tenDG, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, DateTime nct, DateTime nht, string donVi)
        {
            DocGia_DAO.themDG(maDG, tenDG, gioiTinh, ngaySinh, diaChi, sdt, nct, nht, donVi);
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        public static void suaDG_Ten(string ma, string s)
        {
            DocGia_DAO.suaDG_Ten(ma, s);
        }
        public static void suaDG_gt(string ma, string s)
        {
            DocGia_DAO.suaDG_gt(ma, s);
        }
        public static void suaDG_dc(string ma, string s)
        {
            DocGia_DAO.suaDG_dc(ma, s);
        }
        public static void suaDG_dv(string ma, string s)
        {
            DocGia_DAO.suaDG_dv(ma, s);
        }
        public static void suaDG_sdt(string ma, string s)
        {
            DocGia_DAO.suaDG_sdt(ma, s);
        }
        public static void suaDG_ns(string ma, DateTime s)
        {
            DocGia_DAO.suaDG_ns(ma, s);
        }
        public static void suaDG_nct(string ma, DateTime s)
        {
            DocGia_DAO.suaDG_nct(ma, s);
        }
        public static void suaDG_nhh(string ma, DateTime s)
        {
            DocGia_DAO.suaDG_nhh(ma, s);
        }
        public static void xoaDG(string ma)
        {
            DocGia_DAO.xoaDG(ma);
        }
        public static DataTable checkDG(string s)
        {
            return DocGia_DAO.checkDG(s);
        }
        public static DataTable dsMaDG()
        {
            return DocGia_DAO.dsMaDG();
        }
        public static string TenDG(string s)
        {
            return DocGia_DAO.TenDG(s);
        }
       
    }
    public class MuonTra_BUS
    {
        public static void muonSach(string maMT, string maNV, string maDG, DateTime ngayMuon, DateTime hanTra, string maSach)
        {
            MuonTra_DAO.muonSach(maMT, maNV, maDG, ngayMuon, hanTra, maSach);
        }
        public static string LastMaMT()
        {
            return MuonTra_DAO.LastMaMT();
        }
        public static DataTable checkTraSach(string s)
        {
            return MuonTra_DAO.checkTraSach(s);
        }
        public static void TraSach(string ma, string ghichu, DateTime ngaytra)
        {
            MuonTra_DAO.TraSach(ma, ghichu, ngaytra);
        }
        public static DataTable DsMuonTra()
        {
            return MuonTra_DAO.DsMuonTra();
        }
        public static void xoaMT(string ma)
        {
            MuonTra_DAO.xoaMT(ma);
        }
        public static void suaMT_datra(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime nt, DateTime ht)
        {
            MuonTra_DAO.suaMT_datra( ma, S, DG, NV, gc, nm, nt, ht);
        }
        public static void suaMT_damuon(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime ht)
        {
            MuonTra_DAO.suaMT_damuon(ma, S, DG, NV, gc, nm, ht);
            
        }
        public static void themMT(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime ht)
        {
            MuonTra_DAO.themMT(ma, S, DG, NV, gc, nm, ht);
        }
    }
    public class NhanVien_BUS
    {
        public static DataTable login(string s, string s2)
        {
            return NhanVien_DAO.login(s, s2);
        }
        public static DataTable dsMaNV()
        {
            return NhanVien_DAO.dsMaNV();
        }
    }
}
