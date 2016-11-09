namespace BTL_QUANLYTHUVIEN
{
    partial class frmDauSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDauSach));
            this.nbcThongTin = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgThongTin = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tbGiaSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTacGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbTenDS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaDS = new System.Windows.Forms.TextBox();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDSDauSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuanHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcDauSach = new DevExpress.XtraGrid.GridControl();
            this.gvDauSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTheLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chkGiaSach = new System.Windows.Forms.CheckBox();
            this.chkTacGia = new System.Windows.Forms.CheckBox();
            this.chkNhaXuatBan = new System.Windows.Forms.CheckBox();
            this.chkTheLoai = new System.Windows.Forms.CheckBox();
            this.chkTenDauSach = new System.Windows.Forms.CheckBox();
            this.chkMaDauSach = new System.Windows.Forms.CheckBox();
            this.chkTatCa = new System.Windows.Forms.CheckBox();
            this.DSbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nbcThongTin)).BeginInit();
            this.nbcThongTin.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nbcThongTin
            // 
            this.nbcThongTin.ActiveGroup = this.nbgThongTin;
            this.nbcThongTin.Controls.Add(this.navBarGroupControlContainer1);
            this.nbcThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbcThongTin.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgThongTin});
            this.nbcThongTin.Location = new System.Drawing.Point(0, 0);
            this.nbcThongTin.Name = "nbcThongTin";
            this.nbcThongTin.OptionsNavPane.ExpandedWidth = 296;
            this.nbcThongTin.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.nbcThongTin.Size = new System.Drawing.Size(296, 461);
            this.nbcThongTin.TabIndex = 0;
            this.nbcThongTin.Text = "Thông Tin Đầu Sách";
            // 
            // nbgThongTin
            // 
            this.nbgThongTin.Caption = "Thông Tin Đầu Sách";
            this.nbgThongTin.ControlContainer = this.navBarGroupControlContainer1;
            this.nbgThongTin.Expanded = true;
            this.nbgThongTin.GroupClientHeight = 80;
            this.nbgThongTin.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nbgThongTin.Name = "nbgThongTin";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.panelControl1);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(296, 358);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tbGiaSach);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.tbNXB);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.tbTacGia);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.cboTheLoai);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.tbSoLuong);
            this.panelControl1.Controls.Add(this.tbTenDS);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.tbMaDS);
            this.panelControl1.Location = new System.Drawing.Point(12, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(266, 326);
            this.panelControl1.TabIndex = 10;
            // 
            // tbGiaSach
            // 
            this.tbGiaSach.Location = new System.Drawing.Point(116, 241);
            this.tbGiaSach.Name = "tbGiaSach";
            this.tbGiaSach.Size = new System.Drawing.Size(130, 21);
            this.tbGiaSach.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Giá Sách";
            // 
            // tbNXB
            // 
            this.tbNXB.Location = new System.Drawing.Point(116, 159);
            this.tbNXB.Name = "tbNXB";
            this.tbNXB.Size = new System.Drawing.Size(130, 21);
            this.tbNXB.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nhà Xuất Bản";
            // 
            // tbTacGia
            // 
            this.tbTacGia.Location = new System.Drawing.Point(116, 122);
            this.tbTacGia.Name = "tbTacGia";
            this.tbTacGia.Size = new System.Drawing.Size(130, 21);
            this.tbTacGia.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tác Giả";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(116, 85);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(130, 21);
            this.cboTheLoai.TabIndex = 32;
            // 
            // btnLuu
            // 
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLuu.Location = new System.Drawing.Point(26, 281);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnHuy.Location = new System.Drawing.Point(161, 281);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(116, 200);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.ReadOnly = true;
            this.tbSoLuong.Size = new System.Drawing.Size(130, 21);
            this.tbSoLuong.TabIndex = 5;
            // 
            // tbTenDS
            // 
            this.tbTenDS.Location = new System.Drawing.Point(116, 47);
            this.tbTenDS.Name = "tbTenDS";
            this.tbTenDS.Size = new System.Drawing.Size(130, 21);
            this.tbTenDS.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thể Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Đầu Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đầu Sách";
            // 
            // tbMaDS
            // 
            this.tbMaDS.Location = new System.Drawing.Point(116, 12);
            this.tbMaDS.Name = "tbMaDS";
            this.tbMaDS.ReadOnly = true;
            this.tbMaDS.Size = new System.Drawing.Size(130, 21);
            this.tbMaDS.TabIndex = 1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupsBorder = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDSDauSach,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnChuanHoa,
            this.btnCapNhap,
            this.btnTheLoai});
            this.ribbonControl1.Location = new System.Drawing.Point(296, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(792, 75);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnDSDauSach
            // 
            this.btnDSDauSach.Caption = "\r\nDanh Sách Đầu Sách";
            this.btnDSDauSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDSDauSach.Glyph")));
            this.btnDSDauSach.Id = 1;
            this.btnDSDauSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDSDauSach.LargeGlyph")));
            this.btnDSDauSach.Name = "btnDSDauSach";
            this.btnDSDauSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDauSach_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 2;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 3;
            this.btnSua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSua.LargeGlyph")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 4;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnChuanHoa
            // 
            this.btnChuanHoa.Caption = "Chuẩn Hóa Dữ Liệu";
            this.btnChuanHoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnChuanHoa.Glyph")));
            this.btnChuanHoa.Id = 5;
            this.btnChuanHoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnChuanHoa.LargeGlyph")));
            this.btnChuanHoa.Name = "btnChuanHoa";
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Caption = "Cập Nhập Dữ Liệu";
            this.btnCapNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCapNhap.Glyph")));
            this.btnCapNhap.Id = 6;
            this.btnCapNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCapNhap.LargeGlyph")));
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhap_ItemClick);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Caption = "\r\nDanh Sách Thể Loại";
            this.btnTheLoai.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTheLoai.Glyph")));
            this.btnTheLoai.Id = 7;
            this.btnTheLoai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTheLoai.LargeGlyph")));
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTheLoai_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDSDauSach);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSua);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnChuanHoa);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCapNhap);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTheLoai);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // gcDauSach
            // 
            this.gcDauSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDauSach.Location = new System.Drawing.Point(296, 131);
            this.gcDauSach.MainView = this.gvDauSach;
            this.gcDauSach.Name = "gcDauSach";
            this.gcDauSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gcDauSach.Size = new System.Drawing.Size(792, 330);
            this.gcDauSach.TabIndex = 2;
            this.gcDauSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDauSach});
            // 
            // gvDauSach
            // 
            this.gvDauSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDS,
            this.colTenDS,
            this.colTheLoai,
            this.colTacGia,
            this.colNXB,
            this.colSL,
            this.colGiaSach});
            this.gvDauSach.GridControl = this.gcDauSach;
            this.gvDauSach.Name = "gvDauSach";
            this.gvDauSach.OptionsFind.AlwaysVisible = true;
            this.gvDauSach.OptionsView.ShowGroupPanel = false;
            this.gvDauSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDauSach_FocusedRowChanged);
            this.gvDauSach.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvDauSach_ValidateRow);
            // 
            // colMaDS
            // 
            this.colMaDS.Caption = "Mã Đầu Sách";
            this.colMaDS.FieldName = "MaDS";
            this.colMaDS.Name = "colMaDS";
            this.colMaDS.Visible = true;
            this.colMaDS.VisibleIndex = 0;
            this.colMaDS.Width = 84;
            // 
            // colTenDS
            // 
            this.colTenDS.Caption = "Tên Đầu Sách";
            this.colTenDS.FieldName = "TenDS";
            this.colTenDS.Name = "colTenDS";
            this.colTenDS.Visible = true;
            this.colTenDS.VisibleIndex = 1;
            this.colTenDS.Width = 109;
            // 
            // colTheLoai
            // 
            this.colTheLoai.Caption = "Thể Loại";
            this.colTheLoai.ColumnEdit = this.repositoryItemComboBox1;
            this.colTheLoai.FieldName = "TenTL";
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.Visible = true;
            this.colTheLoai.VisibleIndex = 2;
            this.colTheLoai.Width = 109;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colTacGia
            // 
            this.colTacGia.Caption = "Tác Giả";
            this.colTacGia.FieldName = "TenTG";
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Visible = true;
            this.colTacGia.VisibleIndex = 3;
            this.colTacGia.Width = 109;
            // 
            // colNXB
            // 
            this.colNXB.Caption = "Nhà Xuất Bản";
            this.colNXB.FieldName = "NXB";
            this.colNXB.Name = "colNXB";
            this.colNXB.Visible = true;
            this.colNXB.VisibleIndex = 4;
            this.colNXB.Width = 109;
            // 
            // colSL
            // 
            this.colSL.Caption = "Số Lượng";
            this.colSL.FieldName = "SoLuong";
            this.colSL.Name = "colSL";
            this.colSL.OptionsColumn.ReadOnly = true;
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 5;
            this.colSL.Width = 109;
            // 
            // colGiaSach
            // 
            this.colGiaSach.Caption = "Giá Sách";
            this.colGiaSach.FieldName = "GiaSach";
            this.colGiaSach.Name = "colGiaSach";
            this.colGiaSach.Visible = true;
            this.colGiaSach.VisibleIndex = 6;
            this.colGiaSach.Width = 116;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(296, 75);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(792, 56);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chkGiaSach);
            this.panelControl2.Controls.Add(this.chkTacGia);
            this.panelControl2.Controls.Add(this.chkNhaXuatBan);
            this.panelControl2.Controls.Add(this.chkTheLoai);
            this.panelControl2.Controls.Add(this.chkTenDauSach);
            this.panelControl2.Controls.Add(this.chkMaDauSach);
            this.panelControl2.Controls.Add(this.chkTatCa);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(788, 33);
            this.panelControl2.TabIndex = 19;
            // 
            // chkGiaSach
            // 
            this.chkGiaSach.AutoSize = true;
            this.chkGiaSach.Location = new System.Drawing.Point(510, 9);
            this.chkGiaSach.Name = "chkGiaSach";
            this.chkGiaSach.Size = new System.Drawing.Size(67, 17);
            this.chkGiaSach.TabIndex = 6;
            this.chkGiaSach.Text = "Giá Sách";
            this.chkGiaSach.UseVisualStyleBackColor = true;
            // 
            // chkTacGia
            // 
            this.chkTacGia.AutoSize = true;
            this.chkTacGia.Location = new System.Drawing.Point(347, 9);
            this.chkTacGia.Name = "chkTacGia";
            this.chkTacGia.Size = new System.Drawing.Size(61, 17);
            this.chkTacGia.TabIndex = 5;
            this.chkTacGia.Text = "Tác Giả";
            this.chkTacGia.UseVisualStyleBackColor = true;
            // 
            // chkNhaXuatBan
            // 
            this.chkNhaXuatBan.AutoSize = true;
            this.chkNhaXuatBan.Location = new System.Drawing.Point(413, 9);
            this.chkNhaXuatBan.Name = "chkNhaXuatBan";
            this.chkNhaXuatBan.Size = new System.Drawing.Size(91, 17);
            this.chkNhaXuatBan.TabIndex = 4;
            this.chkNhaXuatBan.Text = "Nhà Xuất Bản";
            this.chkNhaXuatBan.UseVisualStyleBackColor = true;
            // 
            // chkTheLoai
            // 
            this.chkTheLoai.AutoSize = true;
            this.chkTheLoai.Location = new System.Drawing.Point(259, 9);
            this.chkTheLoai.Name = "chkTheLoai";
            this.chkTheLoai.Size = new System.Drawing.Size(66, 17);
            this.chkTheLoai.TabIndex = 3;
            this.chkTheLoai.Text = "Thể Loại";
            this.chkTheLoai.UseVisualStyleBackColor = true;
            // 
            // chkTenDauSach
            // 
            this.chkTenDauSach.AutoSize = true;
            this.chkTenDauSach.Location = new System.Drawing.Point(160, 9);
            this.chkTenDauSach.Name = "chkTenDauSach";
            this.chkTenDauSach.Size = new System.Drawing.Size(93, 17);
            this.chkTenDauSach.TabIndex = 2;
            this.chkTenDauSach.Text = "Tên Đầu Sách";
            this.chkTenDauSach.UseVisualStyleBackColor = true;
            // 
            // chkMaDauSach
            // 
            this.chkMaDauSach.AutoSize = true;
            this.chkMaDauSach.Location = new System.Drawing.Point(68, 9);
            this.chkMaDauSach.Name = "chkMaDauSach";
            this.chkMaDauSach.Size = new System.Drawing.Size(89, 17);
            this.chkMaDauSach.TabIndex = 1;
            this.chkMaDauSach.Text = "Mã Đầu Sách";
            this.chkMaDauSach.UseVisualStyleBackColor = true;
            // 
            // chkTatCa
            // 
            this.chkTatCa.AutoSize = true;
            this.chkTatCa.Location = new System.Drawing.Point(6, 9);
            this.chkTatCa.Name = "chkTatCa";
            this.chkTatCa.Size = new System.Drawing.Size(56, 17);
            this.chkTatCa.TabIndex = 0;
            this.chkTatCa.Text = "Tất cả";
            this.chkTatCa.UseVisualStyleBackColor = true;
            // 
            // frmDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 461);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDauSach);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.nbcThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDauSach";
            this.Text = "frmDauSach";
            ((System.ComponentModel.ISupportInitialize)(this.nbcThongTin)).EndInit();
            this.nbcThongTin.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl nbcThongTin;
        private DevExpress.XtraNavBar.NavBarGroup nbgThongTin;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDSDauSach;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnChuanHoa;
        private DevExpress.XtraBars.BarButtonItem btnCapNhap;
        private DevExpress.XtraBars.BarButtonItem btnTheLoai;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraGrid.GridControl gcDauSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDauSach;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.CheckBox chkGiaSach;
        private System.Windows.Forms.CheckBox chkTacGia;
        private System.Windows.Forms.CheckBox chkNhaXuatBan;
        private System.Windows.Forms.CheckBox chkTheLoai;
        private System.Windows.Forms.CheckBox chkTenDauSach;
        private System.Windows.Forms.CheckBox chkMaDauSach;
        private System.Windows.Forms.CheckBox chkTatCa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDS;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDS;
        private DevExpress.XtraGrid.Columns.GridColumn colTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNXB;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaSach;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox tbGiaSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTacGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbTenDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaDS;
        private System.Windows.Forms.BindingSource DSbindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}