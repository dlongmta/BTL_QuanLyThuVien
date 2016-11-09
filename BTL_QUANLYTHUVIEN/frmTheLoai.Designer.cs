namespace BTL_QUANLYTHUVIEN
{
    partial class frmTheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheLoai));
            this.nbcThongTin = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgThongTin = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbTenTL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaTL = new System.Windows.Forms.TextBox();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDSTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhap = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcTheLoai = new DevExpress.XtraGrid.GridControl();
            this.gvTheLoai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TLbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nbcThongTin)).BeginInit();
            this.nbcThongTin.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLbindingSource)).BeginInit();
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
            this.nbcThongTin.OptionsNavPane.ExpandedWidth = 244;
            this.nbcThongTin.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.nbcThongTin.Size = new System.Drawing.Size(244, 392);
            this.nbcThongTin.TabIndex = 1;
            this.nbcThongTin.Text = "Thông Tin Đầu Sách";
            // 
            // nbgThongTin
            // 
            this.nbgThongTin.Caption = "Thông Tin Thể Loại";
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
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(244, 289);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.tbTenTL);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.tbMaTL);
            this.panelControl1.Location = new System.Drawing.Point(5, 42);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(233, 216);
            this.panelControl1.TabIndex = 10;
            // 
            // btnLuu
            // 
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnLuu.Location = new System.Drawing.Point(21, 169);
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
            this.btnHuy.Location = new System.Drawing.Point(130, 169);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbTenTL
            // 
            this.tbTenTL.Location = new System.Drawing.Point(98, 96);
            this.tbTenTL.Name = "tbTenTL";
            this.tbTenTL.Size = new System.Drawing.Size(130, 21);
            this.tbTenTL.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Thể Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thể Loại";
            // 
            // tbMaTL
            // 
            this.tbMaTL.Location = new System.Drawing.Point(98, 34);
            this.tbMaTL.Name = "tbMaTL";
            this.tbMaTL.ReadOnly = true;
            this.tbMaTL.Size = new System.Drawing.Size(107, 21);
            this.tbMaTL.TabIndex = 1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupsBorder = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDSTheLoai,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnCapNhap});
            this.ribbonControl1.Location = new System.Drawing.Point(244, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(610, 75);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnDSTheLoai
            // 
            this.btnDSTheLoai.Caption = "\r\nDanh Sách Thể Loại";
            this.btnDSTheLoai.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDSTheLoai.Glyph")));
            this.btnDSTheLoai.Id = 1;
            this.btnDSTheLoai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDSTheLoai.LargeGlyph")));
            this.btnDSTheLoai.Name = "btnDSTheLoai";
            this.btnDSTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSTheLoai_ItemClick);
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
            // btnCapNhap
            // 
            this.btnCapNhap.Caption = "Cập Nhập Dữ Liệu";
            this.btnCapNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCapNhap.Glyph")));
            this.btnCapNhap.Id = 6;
            this.btnCapNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCapNhap.LargeGlyph")));
            this.btnCapNhap.Name = "btnCapNhap";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDSTheLoai);
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
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCapNhap);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // gcTheLoai
            // 
            this.gcTheLoai.DataMember = "sp_DSTheLoai";
            this.gcTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTheLoai.Location = new System.Drawing.Point(244, 75);
            this.gcTheLoai.MainView = this.gvTheLoai;
            this.gcTheLoai.MenuManager = this.ribbonControl1;
            this.gcTheLoai.Name = "gcTheLoai";
            this.gcTheLoai.Size = new System.Drawing.Size(610, 317);
            this.gcTheLoai.TabIndex = 4;
            this.gcTheLoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTheLoai});
            // 
            // gvTheLoai
            // 
            this.gvTheLoai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTL,
            this.colTenTL});
            this.gvTheLoai.GridControl = this.gcTheLoai;
            this.gvTheLoai.Name = "gvTheLoai";
            this.gvTheLoai.OptionsFind.AlwaysVisible = true;
            this.gvTheLoai.OptionsView.ShowGroupPanel = false;
            this.gvTheLoai.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvTheLoai_FocusedRowChanged);
            this.gvTheLoai.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvTheLoai_ValidateRow);
            // 
            // colMaTL
            // 
            this.colMaTL.Caption = "Mã Thể Loại";
            this.colMaTL.FieldName = "MaTL";
            this.colMaTL.Name = "colMaTL";
            this.colMaTL.OptionsColumn.ReadOnly = true;
            this.colMaTL.Visible = true;
            this.colMaTL.VisibleIndex = 0;
            this.colMaTL.Width = 156;
            // 
            // colTenTL
            // 
            this.colTenTL.Caption = "Tên Thể Loại";
            this.colTenTL.FieldName = "TenTL";
            this.colTenTL.Name = "colTenTL";
            this.colTenTL.Visible = true;
            this.colTenTL.VisibleIndex = 1;
            this.colTenTL.Width = 436;
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 392);
            this.Controls.Add(this.gcTheLoai);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.nbcThongTin);
            this.Name = "frmTheLoai";
            this.Text = "frmTheLoai";
            ((System.ComponentModel.ISupportInitialize)(this.nbcThongTin)).EndInit();
            this.nbcThongTin.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl nbcThongTin;
        private DevExpress.XtraNavBar.NavBarGroup nbgThongTin;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDSTheLoai;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnCapNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.GridControl gcTheLoai;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTL;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTL;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox tbTenTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaTL;
        private System.Windows.Forms.BindingSource TLbindingSource;
    }
}