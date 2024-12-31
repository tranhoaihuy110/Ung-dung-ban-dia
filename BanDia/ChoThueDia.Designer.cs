namespace BanDia
{
    partial class ChoThueDia
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuatPhieu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemChiTietPhieuThueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traBangĐiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtPt = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTV = new System.Windows.Forms.RadioButton();
            this.radioButtonPT = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txtMaTV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(922, 538);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 51);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.Text = "Tạo phiếu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1040, 619);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 48);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Mã thành viên";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 426);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTietPhieuThueToolStripMenuItem,
            this.traBangĐiaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(267, 68);
            // 
            // xemChiTietPhieuThueToolStripMenuItem
            // 
            this.xemChiTietPhieuThueToolStripMenuItem.Name = "xemChiTietPhieuThueToolStripMenuItem";
            this.xemChiTietPhieuThueToolStripMenuItem.Size = new System.Drawing.Size(266, 32);
            this.xemChiTietPhieuThueToolStripMenuItem.Text = "Xem chi tiết phiếu thuê";
            this.xemChiTietPhieuThueToolStripMenuItem.Click += new System.EventHandler(this.xemChiTietPhieuThueToolStripMenuItem_Click);
            // 
            // traBangĐiaToolStripMenuItem
            // 
            this.traBangĐiaToolStripMenuItem.Name = "traBangĐiaToolStripMenuItem";
            this.traBangĐiaToolStripMenuItem.Size = new System.Drawing.Size(266, 32);
            this.traBangĐiaToolStripMenuItem.Text = "Trả toàn bộ băng đĩa";
            this.traBangĐiaToolStripMenuItem.Click += new System.EventHandler(this.traBangĐiaToolStripMenuItem_Click);
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
            // txtPt
            // 
            this.txtPt.Location = new System.Drawing.Point(403, 56);
            this.txtPt.Name = "txtPt";
            this.txtPt.Size = new System.Drawing.Size(221, 26);
            this.txtPt.TabIndex = 47;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-124, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã phiếu thuê";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTV);
            this.groupBox1.Controls.Add(this.radioButtonPT);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXuatPhieu);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtPt);
            this.groupBox1.Location = new System.Drawing.Point(23, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 214);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý phiếu thuê";
            // 
            // radioButtonTV
            // 
            this.radioButtonTV.AutoSize = true;
            this.radioButtonTV.Location = new System.Drawing.Point(428, 143);
            this.radioButtonTV.Name = "radioButtonTV";
            this.radioButtonTV.Size = new System.Drawing.Size(148, 24);
            this.radioButtonTV.TabIndex = 53;
            this.radioButtonTV.TabStop = true;
            this.radioButtonTV.Text = "Mã Khách Hàng";
            this.radioButtonTV.UseVisualStyleBackColor = true;
            // 
            // radioButtonPT
            // 
            this.radioButtonPT.AutoSize = true;
            this.radioButtonPT.Location = new System.Drawing.Point(428, 111);
            this.radioButtonPT.Name = "radioButtonPT";
            this.radioButtonPT.Size = new System.Drawing.Size(140, 24);
            this.radioButtonPT.TabIndex = 52;
            this.radioButtonPT.TabStop = true;
            this.radioButtonPT.Text = "Mã Phiếu Thuê";
            this.radioButtonPT.UseVisualStyleBackColor = true;
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
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(818, 619);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(166, 48);
            this.btnKiemTra.TabIndex = 51;
            this.btnKiemTra.Text = "Kiểm tra thanh toán";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txtMaTV
            // 
            this.txtMaTV.Location = new System.Drawing.Point(922, 491);
            this.txtMaTV.Name = "txtMaTV";
            this.txtMaTV.Size = new System.Drawing.Size(286, 26);
            this.txtMaTV.TabIndex = 52;
            // 
            // ChoThueDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 679);
            this.Controls.Add(this.txtMaTV);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLuu);
            this.Name = "ChoThueDia";
            this.Text = "Thuê Đĩa";
            this.Load += new System.EventHandler(this.ChoThueDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuatPhieu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemChiTietPhieuThueToolStripMenuItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtPt;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton radioButtonTV;
        private System.Windows.Forms.RadioButton radioButtonPT;
        private System.Windows.Forms.ToolStripMenuItem traBangĐiaToolStripMenuItem;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txtMaTV;
    }
}