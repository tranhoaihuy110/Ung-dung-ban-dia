namespace BanDia
{
    partial class NhapKho
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
            this.radioButtonNV = new System.Windows.Forms.RadioButton();
            this.radioButtonPN = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNCC = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatPhieu = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtPt = new System.Windows.Forms.TextBox();
            this.cbMa = new System.Windows.Forms.ComboBox();
            this.xemChiTietPhieuThueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cBManv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonNV
            // 
            this.radioButtonNV.AutoSize = true;
            this.radioButtonNV.Location = new System.Drawing.Point(428, 143);
            this.radioButtonNV.Name = "radioButtonNV";
            this.radioButtonNV.Size = new System.Drawing.Size(134, 24);
            this.radioButtonNV.TabIndex = 53;
            this.radioButtonNV.TabStop = true;
            this.radioButtonNV.Text = "Mã Nhân Viên";
            this.radioButtonNV.UseVisualStyleBackColor = true;
            // 
            // radioButtonPN
            // 
            this.radioButtonPN.AutoSize = true;
            this.radioButtonPN.Location = new System.Drawing.Point(428, 111);
            this.radioButtonPN.Name = "radioButtonPN";
            this.radioButtonPN.Size = new System.Drawing.Size(142, 24);
            this.radioButtonPN.TabIndex = 52;
            this.radioButtonPN.TabStop = true;
            this.radioButtonPN.Text = "Mã Phiếu Nhập";
            this.radioButtonPN.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNCC);
            this.groupBox1.Controls.Add(this.radioButtonNV);
            this.groupBox1.Controls.Add(this.radioButtonPN);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXuatPhieu);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtPt);
            this.groupBox1.Location = new System.Drawing.Point(10, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 214);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý phiếu nhập";
            // 
            // radioButtonNCC
            // 
            this.radioButtonNCC.AutoSize = true;
            this.radioButtonNCC.Location = new System.Drawing.Point(428, 173);
            this.radioButtonNCC.Name = "radioButtonNCC";
            this.radioButtonNCC.Size = new System.Drawing.Size(164, 24);
            this.radioButtonNCC.TabIndex = 61;
            this.radioButtonNCC.TabStop = true;
            this.radioButtonNCC.Text = "Mã Nhà Cung Cấp";
            this.radioButtonNCC.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(19, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 51);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(202, 127);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 51);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-124, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã phiếu thuê";
            // 
            // btnXuatPhieu
            // 
            this.btnXuatPhieu.Location = new System.Drawing.Point(19, 56);
            this.btnXuatPhieu.Name = "btnXuatPhieu";
            this.btnXuatPhieu.Size = new System.Drawing.Size(141, 48);
            this.btnXuatPhieu.TabIndex = 40;
            this.btnXuatPhieu.Text = "Xuất phiếu";
            this.btnXuatPhieu.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(202, 56);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(143, 48);
            this.btnTim.TabIndex = 48;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtPt
            // 
            this.txtPt.Location = new System.Drawing.Point(403, 56);
            this.txtPt.Name = "txtPt";
            this.txtPt.Size = new System.Drawing.Size(221, 26);
            this.txtPt.TabIndex = 47;
            // 
            // cbMa
            // 
            this.cbMa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMa.FormattingEnabled = true;
            this.cbMa.Location = new System.Drawing.Point(930, 511);
            this.cbMa.Name = "cbMa";
            this.cbMa.Size = new System.Drawing.Size(219, 28);
            this.cbMa.TabIndex = 56;
            this.cbMa.TextChanged += new System.EventHandler(this.cbMa_TextChanged);
            // 
            // xemChiTietPhieuThueToolStripMenuItem
            // 
            this.xemChiTietPhieuThueToolStripMenuItem.Name = "xemChiTietPhieuThueToolStripMenuItem";
            this.xemChiTietPhieuThueToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.xemChiTietPhieuThueToolStripMenuItem.Text = "Xem chi tiết phiếu nhập";
            this.xemChiTietPhieuThueToolStripMenuItem.Click += new System.EventHandler(this.xemChiTietPhieuThueToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTietPhieuThueToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(272, 36);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1550, 426);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1090, 652);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 48);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1090, 577);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 51);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "Tạo phiếu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cBManv
            // 
            this.cBManv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBManv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBManv.FormattingEnabled = true;
            this.cBManv.Location = new System.Drawing.Point(1327, 511);
            this.cBManv.Name = "cBManv";
            this.cBManv.Size = new System.Drawing.Size(219, 28);
            this.cBManv.TabIndex = 60;
            this.cBManv.TextChanged += new System.EventHandler(this.cBManv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1191, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mã nhân viên";
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 740);
            this.Controls.Add(this.cBManv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLuu);
            this.Name = "NhapKho";
            this.Text = "Phiếu nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonNV;
        private System.Windows.Forms.RadioButton radioButtonPN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatPhieu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtPt;
        private System.Windows.Forms.ComboBox cbMa;
        private System.Windows.Forms.ToolStripMenuItem xemChiTietPhieuThueToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cBManv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonNCC;
    }
}