namespace BTL_QUANLYTHUVIEN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.rgbSkins = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDauSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuonTra = new DevExpress.XtraBars.BarButtonItem();
            this.rpTrangChinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTaiLieu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgNguoiDung = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTienIch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpThongTinChung = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnThoat,
            this.rgbSkins,
            this.skinRibbonGalleryBarItem2,
            this.btnDocGia,
            this.btnNhanVien,
            this.btnDauSach,
            this.btnKho,
            this.btnMuonTra});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.skinRibbonGalleryBarItem2);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpTrangChinh,
            this.rpQuanLy,
            this.rpThongTinChung});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1094, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Glyph")));
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.LargeGlyph")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.LargeGlyph")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 4;
            this.btnThoat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.LargeGlyph")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // rgbSkins
            // 
            this.rgbSkins.Caption = "skinRibbonGalleryBarItem1";
            this.rgbSkins.Id = 5;
            this.rgbSkins.Name = "rgbSkins";
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.Id = 6;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // btnDocGia
            // 
            this.btnDocGia.Caption = "Độc Giả";
            this.btnDocGia.Id = 7;
            this.btnDocGia.LargeGlyph = global::BTL_QUANLYTHUVIEN.Properties.Resources.student;
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDocGia_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Glyph")));
            this.btnNhanVien.Id = 8;
            this.btnNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.LargeGlyph")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnDauSach
            // 
            this.btnDauSach.Caption = "Quản Lý Đầu Sách";
            this.btnDauSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDauSach.Glyph")));
            this.btnDauSach.Id = 9;
            this.btnDauSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDauSach.LargeGlyph")));
            this.btnDauSach.Name = "btnDauSach";
            this.btnDauSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDauSach_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Quản Lý Kho";
            this.btnKho.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKho.Glyph")));
            this.btnKho.Id = 10;
            this.btnKho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKho.LargeGlyph")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Caption = "Mượn/Trả";
            this.btnMuonTra.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMuonTra.Glyph")));
            this.btnMuonTra.Id = 11;
            this.btnMuonTra.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMuonTra.LargeGlyph")));
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMuonTra_ItemClick);
            // 
            // rpTrangChinh
            // 
            this.rpTrangChinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgHeThong,
            this.rpgGiaoDien});
            this.rpTrangChinh.Name = "rpTrangChinh";
            this.rpTrangChinh.Text = "Trang chính";
            // 
            // rpgHeThong
            // 
            this.rpgHeThong.ItemLinks.Add(this.btnDangNhap);
            this.rpgHeThong.ItemLinks.Add(this.btnDangXuat);
            this.rpgHeThong.ItemLinks.Add(this.btnThoat);
            this.rpgHeThong.Name = "rpgHeThong";
            this.rpgHeThong.ShowCaptionButton = false;
            this.rpgHeThong.Text = "Hệ Thống";
            // 
            // rpgGiaoDien
            // 
            this.rpgGiaoDien.ItemLinks.Add(this.rgbSkins);
            this.rpgGiaoDien.Name = "rpgGiaoDien";
            this.rpgGiaoDien.Text = "Giao Diện";
            // 
            // rpQuanLy
            // 
            this.rpQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTaiLieu,
            this.rpgNguoiDung,
            this.rpgTienIch});
            this.rpQuanLy.Name = "rpQuanLy";
            this.rpQuanLy.Text = "Quản Lý";
            // 
            // rpgTaiLieu
            // 
            this.rpgTaiLieu.ItemLinks.Add(this.btnDauSach);
            this.rpgTaiLieu.ItemLinks.Add(this.btnKho);
            this.rpgTaiLieu.Name = "rpgTaiLieu";
            this.rpgTaiLieu.Text = "Tài Liệu";
            // 
            // rpgNguoiDung
            // 
            this.rpgNguoiDung.ItemLinks.Add(this.btnDocGia);
            this.rpgNguoiDung.ItemLinks.Add(this.btnNhanVien);
            this.rpgNguoiDung.Name = "rpgNguoiDung";
            this.rpgNguoiDung.Text = "Người Dùng";
            // 
            // rpgTienIch
            // 
            this.rpgTienIch.AllowTextClipping = false;
            this.rpgTienIch.ItemLinks.Add(this.btnMuonTra);
            this.rpgTienIch.Name = "rpgTienIch";
            this.rpgTienIch.Text = "Mượn Trả";
            // 
            // rpThongTinChung
            // 
            this.rpThongTinChung.Name = "rpThongTinChung";
            this.rpThongTinChung.Text = "Thông Tin Chung";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 633);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1094, 31);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 144);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1094, 489);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            this.xtraTabControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.xtraTabControl1_ControlAdded);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1088, 461);
            this.xtraTabPage1.Text = "Trang Chính";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 664);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpTrangChinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGiaoDien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpThongTinChung;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem rgbSkins;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.BarButtonItem btnDocGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTaiLieu;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnDauSach;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem btnMuonTra;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTienIch;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

