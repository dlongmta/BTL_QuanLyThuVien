using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace BTL_QUANLYTHUVIEN
{
    public partial class frmDauSach : Form
    {
        #region các biến
        public bool them = true;
        public bool sua = false;
        public int soLuongSV = 0;
        public bool daChuanhoa = false;
        #endregion

        public frmDauSach()
        {
            InitializeComponent();
            Enable(false);
        }

        private void btnTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTheLoai f = new frmTheLoai();
            f.Enable(false);
            f.Show();
        }

        private void btnDSDauSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Enable(true);
            Load();
            DataTable dtb = TheLoai_BUS.DStenTL();
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                // string name = dtb.Rows[i][0].ToString().ToUpper();

                string name = ChuanHoa(dtb.Rows[i][0].ToString().ToLower());
                cboTheLoai.Items.Add(name);
                repositoryItemComboBox1.Items.Add(name);
            }
        }
        public void Enable(bool logged)
        {
            btnChuanHoa.Enabled = logged;
            btnCapNhap.Enabled = logged;
            btnLuu.Enabled = logged;
            btnHuy.Enabled = logged;
            btnThem.Enabled = logged;
            btnSua.Enabled = logged;
            btnXoa.Enabled = logged;

        }
        private void Load()
        {
            try
            {
                DSbindingSource.DataSource = DauSach_BUS.LoadDSDauSach();
                gcDauSach.DataSource = DSbindingSource;
                int soTL = cboTheLoai.Items.Count;
                for(int i=0;i<soTL;i++)
                {
                    repositoryItemComboBox1.Items.RemoveAt(0);
                    cboTheLoai.Items.RemoveAt(0);
                }
               // gcTheLoai.DataSource = TLbindingSource;
            }
            catch
            {
                MessageBox.Show("Load bị lỗi!");
            }
        }

        private void gvDauSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvDauSach.FocusedRowHandle >= 0)
            {
                tbMaDS.Text = gvDauSach.GetFocusedRowCellValue(colMaDS).ToString();
                tbTenDS.Text = gvDauSach.GetFocusedRowCellValue(colTenDS).ToString();
                tbTacGia.Text = gvDauSach.GetFocusedRowCellValue(colTacGia).ToString();
                tbNXB.Text = gvDauSach.GetFocusedRowCellValue(colNXB).ToString();
                tbSoLuong.Text = gvDauSach.GetFocusedRowCellValue(colSL).ToString();
                cboTheLoai.Text = gvDauSach.GetFocusedRowCellValue(colTheLoai).ToString();
                tbGiaSach.Text = gvDauSach.GetFocusedRowCellValue(colGiaSach).ToString();
                sua = false;
            }
        }
        //chuẩn hóa chuỗi
        public string ChuanHoa(string st)
        {
            string st1 = "";
            st = st.Trim();
            while (st.Length != 0)
            {
                st += " ";
                int i = st.IndexOf(' ');
                string s = char.ToUpper(st[0]) + st.Substring(1, i);
                st1 += s;
                st = st.Substring(i + 1).Trim();
            }
            return st1.Trim();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (them)
            {
                tbTenDS.Clear();
                tbTacGia.Clear();
                tbNXB.Clear();
                tbSoLuong.Clear();
                tbGiaSach.Clear();
                //mã đầu sách tự tăng
                string maDS = nextMa(DauSach_BUS.LastMaDS());
                them = false;
                DSbindingSource.AddNew();
                //GÁN vào textbox và gridview
                gvDauSach.SetFocusedRowCellValue(colMaDS, maDS);
                tbMaDS.Text = maDS;
                //trỏ tới dòng cuối cùng trong gridview
                gvDauSach.FocusedRowHandle = gvDauSach.RowCount - 1;
                tbTenDS.Focus();
            }
            else
            {
                gvDauSach.FocusedRowHandle = gvDauSach.RowCount - 1;
                tbTenDS.Focus();
            }
        }
        //Hàm tự tăng mã THỂ loại
        public string nextMa(string s)
        {
            string sub1 = s.Substring(0, 2);
            string sub2 = s.Substring(2).Trim();
            int ma = Convert.ToInt32(sub2) + 1;
            string sub = "";
            //chèn thêm các kí tự 0 vào mã
            for (int i = 0; i < sub2.Length - ma.ToString().Length; i++)
                sub += "0";
            sub += ma.ToString();
            sub1 += sub;
            //
            return sub1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!them && gvDauSach.FocusedRowHandle == gvDauSach.RowCount - 1)
                {
                    if (tbTenDS.Text != ""&&cboTheLoai.Text!="")
                    {
                        //chuẩn hóa tên
                        string maDS = tbMaDS.Text;
                        string tenDS = ChuanHoa(tbTenDS.Text.ToLower());
                        string maTL = TheLoai_BUS.MaTL(cboTheLoai.Text.Trim());
                        string tenTG = ChuanHoa(tbTacGia.Text.ToLower());
                        string nxb = ChuanHoa(tbNXB.Text.ToLower());
                        string giaSach=tbGiaSach.Text;
                        DauSach_BUS.themDS(maDS, tenDS, maTL, tenTG, nxb, giaSach, 0, 0);
                       // TheLoai_BUS.themTL(tbMaTL.Text, tenTL);
                        MessageBox.Show("Thêm thành công");
                        // this.SinhVienbindingSource.EndEdit();
                        //thêm trực tiếp sinh viên vào gridview mà không load lại danh sách
                        //gvDauSach.SetFocusedRowCellValue(colTenTL, tenTL);
                        gvDauSach.SetFocusedRowCellValue(colMaDS, maDS);
                        gvDauSach.SetFocusedRowCellValue(colTenDS, tenDS);
                        gvDauSach.SetFocusedRowCellValue(colTheLoai, cboTheLoai.Text);
                        gvDauSach.SetFocusedRowCellValue(colTacGia, tenTG);
                        gvDauSach.SetFocusedRowCellValue(colNXB, nxb);
                        gvDauSach.SetFocusedRowCellValue(colGiaSach, giaSach);
                        gvDauSach.SetFocusedRowCellValue(colSL, "         0/  0");
                        //load_DS();
                        //chuẩn hóa ở textbox
                        //tbTenTL.Text = tenTL;
                        tbTenDS.Text = tenDS;
                        tbTacGia.Text = tenTG;
                        tbNXB.Text = nxb;
                        tbGiaSach.Text = giaSach.ToString();
                        tbSoLuong.Text = "         0/  0";
                        //
                        them = true;
                    }
                    else
                    {
                        MessageBox.Show("Nhập tên đầu sách");
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string maDS = tbMaDS.Text.Trim();
                            string tenDS=ChuanHoa(tbTenDS.Text.Trim().ToLower());
                            string tenTL=cboTheLoai.Text;
                            string maTL=TheLoai_BUS.MaTL(tenTL);
                            string tenTG=ChuanHoa(tbTacGia.Text.ToLower());
                            string nxb=ChuanHoa(tbNXB.Text.ToLower());
                            string sl=tbSoLuong.Text;
                            string giaSach=tbGiaSach.Text;
                            if (tenDS != gvDauSach.GetFocusedRowCellValue(colTenDS).ToString().Trim())
                            {
                                //TheLoai_BUS.suaTL(tbMaTL.Text.Trim(), tenTL);
                                DauSach_BUS.suaDS_ten(maDS, tenDS);
                                gvDauSach.SetFocusedRowCellValue(colTenDS, tenDS);
                                tbTenDS.Text = tenDS;
                            }
                            else tbTenDS.Text = tenDS;
                            if(tenTL!=gvDauSach.GetFocusedRowCellValue(colTheLoai).ToString())
                            {
                                DauSach_BUS.suaDS_tl(maDS, maTL);
                                gvDauSach.SetFocusedRowCellValue(colTheLoai, tenTL);
                            }
                            if (tenTG != gvDauSach.GetFocusedRowCellValue(colTacGia).ToString())
                            {
                                DauSach_BUS.suaDS_tg(maDS, tenTG);
                                gvDauSach.SetFocusedRowCellValue(colTacGia, tenTG);
                                tbTacGia.Text = tenTG;
                            }
                            else tbTacGia.Text = tenTG;
                            if (nxb != gvDauSach.GetFocusedRowCellValue(colNXB).ToString())
                            {
                                DauSach_BUS.suaDS_nxb(maDS, nxb);
                                gvDauSach.SetFocusedRowCellValue(colNXB, nxb);
                                tbNXB.Text = nxb;
                            }
                            else tbNXB.Text = nxb;
                            if(sl!=gvDauSach.GetFocusedRowCellValue(colSL).ToString())
                            {
                                
                                gvDauSach.SetFocusedRowCellValue(colSL, sl);
                                tbSoLuong.Text = sl;
                            }
                            if (giaSach != gvDauSach.GetFocusedRowCellValue(colGiaSach).ToString())
                            {
                                DauSach_BUS.suaDS_giasach(maDS, giaSach);
                                gvDauSach.SetFocusedRowCellValue(colGiaSach, giaSach);
                                tbGiaSach.Text = giaSach;
                            }
                            else tbGiaSach.Text = giaSach;
                            MessageBox.Show("Sửa thành công!");
                            sua = true;
                        }
                        catch
                        {
                            MessageBox.Show("Sửa không thành công");
                        }
                    }
                    else
                    {
                        tbTenDS.Text = gvDauSach.GetFocusedRowCellValue(colTenDS).ToString();
                        cboTheLoai.Text = gvDauSach.GetFocusedRowCellValue(colTheLoai).ToString();
                        tbTacGia.Text = gvDauSach.GetFocusedRowCellValue(colTacGia).ToString();
                        tbNXB.Text = gvDauSach.GetFocusedRowCellValue(colNXB).ToString();
                        tbSoLuong.Text = gvDauSach.GetFocusedRowCellValue(colSL).ToString();
                        tbGiaSach.Text = gvDauSach.GetFocusedRowCellValue(colGiaSach).ToString();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //hủy khi không muốn thêm thể loại
            // MessageBox.Show(gvSinhVien.FocusedRowHandle+" "+gvSinhVien.RowCount);
            if (!them && gvDauSach.FocusedRowHandle == gvDauSach.RowCount - 1)
            {
                them = true;
                DSbindingSource.RemoveAt(gvDauSach.RowCount - 1);
            }
            //hủy khi sửa
            else
            {
                tbTenDS.Text = gvDauSach.GetFocusedRowCellValue(colTenDS).ToString();
                cboTheLoai.Text = gvDauSach.GetFocusedRowCellValue(colTheLoai).ToString();
                tbTacGia.Text = gvDauSach.GetFocusedRowCellValue(colTacGia).ToString();
                tbNXB.Text = gvDauSach.GetFocusedRowCellValue(colNXB).ToString();
                tbSoLuong.Text = gvDauSach.GetFocusedRowCellValue(colSL).ToString();
                tbGiaSach.Text = gvDauSach.GetFocusedRowCellValue(colGiaSach).ToString();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //TheLoai_BUS.xoaTL(gvDauSach.GetFocusedRowCellValue(colMaTL).ToString());
                DauSach_BUS.xoaDS(gvDauSach.GetFocusedRowCellValue(colMaDS).ToString());
                DSbindingSource.RemoveAt(gvDauSach.FocusedRowHandle);
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbTenDS.Focus();
        }

        private void gvDauSach_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (!them)
            {
                if (gvDauSach.FocusedRowHandle != gvDauSach.RowCount - 1)
                {

                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (gvDauSach.GetFocusedRowCellValue(colTenDS).ToString() != ""&&gvDauSach.GetFocusedRowCellValue(colTheLoai).ToString()!="")
                            {
                                //chuẩn hóa tên
                                string maDS = gvDauSach.GetFocusedRowCellValue(colMaDS).ToString();
                                string tenDS = ChuanHoa(gvDauSach.GetFocusedRowCellValue(colTenDS).ToString().ToLower());
                                string tenTL = gvDauSach.GetFocusedRowCellValue(colTheLoai).ToString();
                                string maTL = TheLoai_BUS.MaTL(tenTL);
                                string tenTG = ChuanHoa(gvDauSach.GetFocusedRowCellValue(colTacGia).ToString().ToLower());
                                string nxb = ChuanHoa(gvDauSach.GetFocusedRowCellValue(colNXB).ToString().ToLower());
                                string giaSach = ChuanHoa(gvDauSach.GetFocusedRowCellValue(colGiaSach).ToString().ToLower());
                                DauSach_BUS.themDS(maDS, tenDS, maTL, tenTG, nxb, giaSach, 0, 0);
                                MessageBox.Show("Thêm thành công");
                                // this.SinhVienbindingSource.EndEdit();
                                //chuẩn hóa trực tiếp sinh viên vào gridview mà không load lại danh sách
                                gvDauSach.SetFocusedRowCellValue(colTenDS, tenDS);
                                gvDauSach.SetFocusedRowCellValue(colTacGia, tenTG);
                                gvDauSach.SetFocusedRowCellValue(colNXB, nxb);
                                gvDauSach.SetFocusedRowCellValue(colSL, "         0/  0");
                                gvDauSach.SetFocusedRowCellValue(colGiaSach, giaSach);
                                //load_DS();
                                //chuẩn hóa ở textbox
                                tbTenDS.Text = tenDS;
                                tbTacGia.Text = tenTG;
                                cboTheLoai.Text = tenTL;
                                tbNXB.Text = nxb;
                                tbGiaSach.Text = giaSach;
                                tbSoLuong.Text = "         0/  0";
                                //
                                them = true;
                            }
                            else
                                MessageBox.Show("Nhập tên tên đầu sách");

                        }
                        catch
                        {
                            MessageBox.Show("Lưu không thành công!");
                        }
                    }
                    else
                    {
                        them = true;
                        DSbindingSource.RemoveAt(gvDauSach.RowCount - 1);
                    }
                }
            }
            else if (daChuanhoa)
            {
                daChuanhoa = false;
            }
            else if (sua)
            {
                sua = false;
            }
            else
            {
                string maDS = gvDauSach.GetFocusedRowCellValue(colMaDS).ToString();
                string tenDS = ChuanHoa(gvDauSach.GetFocusedRowCellValue(colTenDS).ToString().ToLower());
                string tenTL = gvDauSach.GetFocusedRowCellValue(colTheLoai).ToString();
                string maTL = TheLoai_BUS.MaTL(tenTL);
                string tenTG = ChuanHoa(gvDauSach.GetFocusedRowCellValue(colTacGia).ToString().ToLower());
                string nxb = ChuanHoa(gvDauSach.GetFocusedRowCellValue(colNXB).ToString().ToLower());
                string giaSach = ChuanHoa(gvDauSach.GetFocusedRowCellValue(colGiaSach).ToString().ToLower());
                //khi vừa mới thêm xong
                if (tbTenDS.Text == tenDS&&
                    tbTacGia.Text==tenTG&&
                    cboTheLoai.Text==tenTL&&
                    tbNXB.Text==nxb&&
                    tbGiaSach.Text==giaSach)
                {

                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (tenDS != tbTenDS.Text)
                            {
                                //TheLoai_BUS.suaTL(tbMaTL.Text.Trim(), tenTL);
                                DauSach_BUS.suaDS_ten(maDS, tenDS);
                                gvDauSach.SetFocusedRowCellValue(colTenDS, tenDS);
                                tbTenDS.Text = tenDS;
                            }
                            else gvDauSach.SetFocusedRowCellValue(colTenDS, tenDS);
                            if (tenTL != cboTheLoai.Text)
                            {
                                DauSach_BUS.suaDS_tl(maDS, maTL);
                                cboTheLoai.Text = tenTL;
                            }
                            if (tenTG != tbTacGia.Text)
                            {
                                DauSach_BUS.suaDS_tg(maDS, tenTG);
                                gvDauSach.SetFocusedRowCellValue(colTacGia, tenTG);
                                tbTacGia.Text = tenTG;
                            }
                            else gvDauSach.SetFocusedRowCellValue(colTacGia, tenTG);
                            if (nxb != tbNXB.Text)
                            {
                                DauSach_BUS.suaDS_nxb(maDS, nxb);
                                gvDauSach.SetFocusedRowCellValue(colNXB, nxb);
                                tbNXB.Text = nxb;
                            }
                            else gvDauSach.SetFocusedRowCellValue(colNXB, nxb);
                            if (giaSach != tbGiaSach.Text)
                            {
                                DauSach_BUS.suaDS_giasach(maDS, giaSach);
                                gvDauSach.SetFocusedRowCellValue(colGiaSach, giaSach);
                                tbGiaSach.Text = giaSach;
                            }
                            else gvDauSach.SetFocusedRowCellValue(colGiaSach, giaSach);
                            // string maLop = Lop_BUS.maLop(cboLop.Text);
                            //  sv = new SinhVien_DTO(tbHoSV.Text, tbTenSV.Text, cboGioiTinh.Text, dtpNgaySinh.Value, tbDiaChi.Text, tbNoiSinh.Text, maLop);
                            //   SinhVien_BUS.suaSV(sv);
                            //TheLoai_BUS.suaTL(maTL, tenTL);
                            //gvDauSach.SetFocusedRowCellValue(colTenTL, tenTL);
                            //tbTenTL.Text = tenTL;
                            MessageBox.Show("Sửa thành công!");
                        }
                        catch
                        {
                            MessageBox.Show("Sửa không thành công!");
                        }
                    }
                    else
                    {
                        gvDauSach.SetFocusedRowCellValue(colTenDS, tbTenDS.Text);
                        gvDauSach.SetFocusedRowCellValue(colTheLoai, cboTheLoai.Text);
                        gvDauSach.SetFocusedRowCellValue(colTacGia, tbTacGia.Text);
                        gvDauSach.SetFocusedRowCellValue(colNXB, tbNXB.Text);
                        gvDauSach.SetFocusedRowCellValue(colGiaSach, tbGiaSach.Text);
                        //gvDauSach.SetFocusedRowCellValue(colTenDS, tbTenDS.Text);
                    }
                }
            }
        }

        private void btnCapNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load();
        }
    }
}
