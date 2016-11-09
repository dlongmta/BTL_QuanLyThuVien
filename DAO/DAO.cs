using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DTO;

namespace DAO
{
    public class sqlConnectionData
    {
        public static SqlConnection connection()
        {
            SqlConnection cnn = new SqlConnection("Data Source=MAX-PC\\SQLEXPRESS;Initial Catalog=BTL_QuanLyThuVien;Integrated Security=True");
            return cnn;
        }
    }
    public class TheLoai_DAO
    {
        //Load danh sách thể loại
        public static DataTable LoadDSTheLoai()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSTheLoai").Tables[0];
            cnn.Close();
            return dtb;

        }
        //lấy mã TL cuối cùng
        public static string LastMaTL()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaTL").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        //thêm THỂ LOẠI
        public static void themTL(string maTL,string tenTL)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_themTL",maTL,tenTL);
            cnn.Close();
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
      //SỬA TÊN THỂ LOẠI
        public static void suaTL(string maTL,string tenTL)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaTenTL", maTL, tenTL);
            cnn.Close();
        }
        //XÓA mã thể loại
        public static void xoaTL(string maTL)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaTL", maTL);
            cnn.Close();
        }
        public static DataTable DStenTL()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn,"sp_DStenTL").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static string MaTL(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_maTL",s).Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
    }
    public class DauSach_DAO
    {
        public static DataTable LoadDSDauSach()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSDauSach").Tables[0];
            cnn.Close();
            return dtb;

        }
        //lấy mã DS cuối cùng
        public static string LastMaDS()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaDS").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        //thêm đầu sách
        public static void themDS(string maDS,string tenDS,string maTL,string tenTG,string NXB,string giaSach,int sl1,int sl2)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_ThemDS", maDS, tenDS, maTL, tenTG, NXB, giaSach, sl1, sl2);
            cnn.Close();
        }
        //sửa tên
        public static void suaDS_ten(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_ten", maDS, s);
            cnn.Close();
        }
        public static void suaDS_tl(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_tl", maDS, s);
            cnn.Close();
        }
        public static void suaDS_tg(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_TG", maDS, s);
            cnn.Close();
        }
        public static void suaDS_nxb(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_nxb", maDS, s);
            cnn.Close();
        }
        public static void suaDS_giasach(string maDS, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDS_giasach", maDS, s);
            cnn.Close();
        }
        //XÓA mã đầu sách
        public static void xoaDS(string maDS)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaDS", maDS);
            cnn.Close();
        }
        //danh sách tên đầu sách
        public static DataTable dsTenDS()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DStenDS").Tables[0];
            cnn.Close();
            return dtb;
        }
       
    }
    public class Sach_DAO
    {
        public static DataTable LoadDSSach(string maDS)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSSach",maDS).Tables[0];
            cnn.Close();
            return dtb;
        }
        public static string LastMaSach()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaSach").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        //thêm sách
        public static void themSach(string maDS, string maSach,string tt,string ttm)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_themSach", maDS,maSach,tt,ttm);
            cnn.Close();
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        //XÓA mã sách
        public static void xoaSach(string maSach)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaSach", maSach);
            cnn.Close();
        }
        public static DataTable dsmaSach(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSMaSach",s).Tables[0];
            cnn.Close();
            return dtb;
        }
      
    }
    public class DocGia_DAO
    {
        public static DataTable DanhSachDG()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSDocGia").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static string LastMaDG()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaDG").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        public static void themDG(string maDG,string tenDG,string gioiTinh,DateTime ngaySinh,string diaChi,string sdt,DateTime nct,DateTime nht,string donVi)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_themDG", maDG,tenDG,gioiTinh,ngaySinh,diaChi,sdt,nct,nht,donVi);
            cnn.Close();
            //   DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_themSV").Tables[0];
        }
        public static void suaDG_Ten(string ma,string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_TEN", ma, s);
            cnn.Close();
        }
        public static void suaDG_gt(string ma, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_gt", ma, s);
            cnn.Close();
        }
        public static void suaDG_dc(string ma, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_dc", ma, s);
            cnn.Close();
        }
        public static void suaDG_dv(string ma, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_dv", ma, s);
            cnn.Close();
        }
        public static void suaDG_sdt(string ma, string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_sdt", ma, s);
            cnn.Close();
        }
        public static void suaDG_ns(string ma, DateTime s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_ns", ma, s);
            cnn.Close();
        }
        public static void suaDG_nct(string ma, DateTime s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_nct", ma, s);
            cnn.Close();
        }
        public static void suaDG_nhh(string ma, DateTime s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaDG_nhh", ma, s);
            cnn.Close();
        }
        public static void xoaDG(string ma)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaDG", ma);
            cnn.Close();
        }
        public static DataTable checkDG(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb= SqlHelper.ExecuteDataset(cnn, "sp_checkDG", s).Tables[0];
            cnn.Close();
            return dtb;
        }
        public static DataTable dsMaDG()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSMADG").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static string TenDG(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_tenDG",s).Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
    }
    public class MuonTra_DAO
    {
        public static void muonSach(string maMT,string maNV,string maDG,DateTime ngayMuon,DateTime hanTra,string maSach)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_muonSach", maMT,maNV,maDG,ngayMuon,hanTra,maSach);
            cnn.Close();
        }
        public static string LastMaMT()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_lastMaMT").Tables[0];
            cnn.Close();
            return dtb.Rows[0][0].ToString();
        }
        public static DataTable checkTraSach(string s)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_checkSach", s).Tables[0];
            cnn.Close();
            return dtb;
        }
        public static void TraSach(string ma,string ghichu,DateTime ngaytra)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_traSach", ma,ghichu,ngaytra);
            cnn.Close();
        }
        public static DataTable DsMuonTra()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSMuonTra").Tables[0];
            cnn.Close();
            return dtb;
        }
        public static void xoaMT(string ma)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_xoaMT", ma);
            cnn.Close();
        }
        public static void suaMT_datra(string ma,string S,string DG,string NV,string gc,DateTime nm,DateTime nt,DateTime ht)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaMT_DATRA", ma,S,DG,NV,gc,nm,nt,ht);
            cnn.Close();
        }
        public static void suaMT_damuon(string ma, string S, string DG, string NV, string gc, DateTime nm,DateTime ht)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_suaMT_DAmuon", ma, S, DG, NV, gc, nm, ht);
            cnn.Close();
        }
        public static void themMT(string ma, string S, string DG, string NV, string gc, DateTime nm, DateTime ht)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            SqlHelper.ExecuteNonQuery(cnn, "sp_themMT", ma, S, DG, NV, gc, nm, ht);
            cnn.Close();
        }

    }
    public class NhanVien_DAO
    {
        public static DataTable login(string s,string s2)
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_login", s,s2).Tables[0];
            cnn.Close();
            return dtb;
        }
        public static DataTable dsMaNV()
        {
            SqlConnection cnn = sqlConnectionData.connection();
            DataTable dtb = SqlHelper.ExecuteDataset(cnn, "sp_DSMaNV").Tables[0];
            cnn.Close();
            return dtb;
        }
    }
}
