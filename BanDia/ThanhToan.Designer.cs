namespace BanDia
{
    partial class ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonmaptr = new System.Windows.Forms.RadioButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.radioButtonmapt = new System.Windows.Forms.RadioButton();
            this.radioButtonMatt = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.comboBoxTim = new System.Windows.Forms.ComboBox();
            this.btnList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(671, 496);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 48);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonmaptr);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.radioButtonmapt);
            this.groupBox1.Controls.Add(this.radioButtonMatt);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Location = new System.Drawing.Point(57, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 179);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // radioButtonmaptr
            // 
            this.radioButtonmaptr.AutoSize = true;
            this.radioButtonmaptr.Location = new System.Drawing.Point(282, 138);
            this.radioButtonmaptr.Name = "radioButtonmaptr";
            this.radioButtonmaptr.Size = new System.Drawing.Size(122, 24);
            this.radioButtonmaptr.TabIndex = 13;
            this.radioButtonmaptr.TabStop = true;
            this.radioButtonmaptr.Text = "Mã phiếu trả";
            this.radioButtonmaptr.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(109, 41);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(243, 26);
            this.txtTim.TabIndex = 5;
            // 
            // radioButtonmapt
            // 
            this.radioButtonmapt.AutoSize = true;
            this.radioButtonmapt.Location = new System.Drawing.Point(282, 108);
            this.radioButtonmapt.Name = "radioButtonmapt";
            this.radioButtonmapt.Size = new System.Drawing.Size(135, 24);
            this.radioButtonmapt.TabIndex = 1;
            this.radioButtonmapt.TabStop = true;
            this.radioButtonmapt.Text = "Mã phiếu thuê";
            this.radioButtonmapt.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatt
            // 
            this.radioButtonMatt.AutoSize = true;
            this.radioButtonMatt.Location = new System.Drawing.Point(282, 78);
            this.radioButtonMatt.Name = "radioButtonMatt";
            this.radioButtonMatt.Size = new System.Drawing.Size(137, 24);
            this.radioButtonMatt.TabIndex = 0;
            this.radioButtonMatt.TabStop = true;
            this.radioButtonMatt.Text = "Mã thanh toán";
            this.radioButtonMatt.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(17, 73);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 35);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // comboBoxTim
            // 
            this.comboBoxTim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTim.FormattingEnabled = true;
            this.comboBoxTim.Items.AddRange(new object[] {
            "Tổng tiền trả tăng dần",
            "Tổng tiền trả giảm dần",
            "Phí trễ tăng dần",
            "Phí trễ giảm dần "});
            this.comboBoxTim.Location = new System.Drawing.Point(588, 452);
            this.comboBoxTim.Name = "comboBoxTim";
            this.comboBoxTim.Size = new System.Drawing.Size(323, 28);
            this.comboBoxTim.TabIndex = 10;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(936, 410);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 35);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "Liệt kê";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(936, 470);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 356);
            this.dataGridView1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inHoaDonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 36);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // inHoaDonToolStripMenuItem
            // 
            this.inHoaDonToolStripMenuItem.Name = "inHoaDonToolStripMenuItem";
            this.inHoaDonToolStripMenuItem.Size = new System.Drawing.Size(171, 32);
            this.inHoaDonToolStripMenuItem.Text = "In hóa đơn";
            this.inHoaDonToolStripMenuItem.Click += new System.EventHandler(this.inHoaDonToolStripMenuItem_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 657);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxTim);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Name = "ThanhToan";
            this.Text = "Quản Lý Thanh Toán";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.RadioButton radioButtonmapt;
        private System.Windows.Forms.RadioButton radioButtonMatt;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox comboBoxTim;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonmaptr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inHoaDonToolStripMenuItem;
    }
}