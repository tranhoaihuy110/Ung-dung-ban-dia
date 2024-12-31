namespace BanDia
{
    partial class BaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.cBNguoiBaoCao = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenBaoCao = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txMabc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDT = new System.Windows.Forms.RadioButton();
            this.radioButtonNN = new System.Windows.Forms.RadioButton();
            this.radioButtonIN = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng Doanh Thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày lập";
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(628, 415);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(256, 26);
            this.dateTimePickerNgayLap.TabIndex = 4;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Location = new System.Drawing.Point(277, 417);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(180, 26);
            this.txtDoanhThu.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã nhân viên";
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(177, 594);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(179, 54);
            this.btnXuatBaoCao.TabIndex = 14;
            this.btnXuatBaoCao.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // cBNguoiBaoCao
            // 
            this.cBNguoiBaoCao.FormattingEnabled = true;
            this.cBNguoiBaoCao.Location = new System.Drawing.Point(277, 342);
            this.cBNguoiBaoCao.Name = "cBNguoiBaoCao";
            this.cBNguoiBaoCao.Size = new System.Drawing.Size(180, 28);
            this.cBNguoiBaoCao.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(458, 594);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 54);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(277, 491);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(180, 26);
            this.dateTimePickerStart.TabIndex = 37;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(628, 491);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(253, 26);
            this.dateTimePickerEnd.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Ngày kết thúc";
            // 
            // txtTenBaoCao
            // 
            this.txtTenBaoCao.Location = new System.Drawing.Point(628, 342);
            this.txtTenBaoCao.Name = "txtTenBaoCao";
            this.txtTenBaoCao.Size = new System.Drawing.Size(256, 26);
            this.txtTenBaoCao.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 310);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(691, 594);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(179, 54);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Báo Cáo";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txMabc
            // 
            this.txMabc.Location = new System.Drawing.Point(-5, 732);
            this.txMabc.Multiline = true;
            this.txMabc.Name = "txMabc";
            this.txMabc.Size = new System.Drawing.Size(10, 10);
            this.txMabc.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonIN);
            this.groupBox1.Controls.Add(this.radioButtonNN);
            this.groupBox1.Controls.Add(this.radioButtonDT);
            this.groupBox1.Location = new System.Drawing.Point(910, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 195);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại báo cáo";
            // 
            // radioButtonDT
            // 
            this.radioButtonDT.AutoSize = true;
            this.radioButtonDT.Location = new System.Drawing.Point(30, 43);
            this.radioButtonDT.Name = "radioButtonDT";
            this.radioButtonDT.Size = new System.Drawing.Size(109, 24);
            this.radioButtonDT.TabIndex = 0;
            this.radioButtonDT.TabStop = true;
            this.radioButtonDT.Text = "Doanh thu";
            this.radioButtonDT.UseVisualStyleBackColor = true;
            // 
            // radioButtonNN
            // 
            this.radioButtonNN.AutoSize = true;
            this.radioButtonNN.Location = new System.Drawing.Point(30, 83);
            this.radioButtonNN.Name = "radioButtonNN";
            this.radioButtonNN.Size = new System.Drawing.Size(173, 24);
            this.radioButtonNN.TabIndex = 1;
            this.radioButtonNN.TabStop = true;
            this.radioButtonNN.Text = "Đĩa thuê nhiều nhất";
            this.radioButtonNN.UseVisualStyleBackColor = true;
            // 
            // radioButtonIN
            // 
            this.radioButtonIN.AutoSize = true;
            this.radioButtonIN.Location = new System.Drawing.Point(30, 128);
            this.radioButtonIN.Name = "radioButtonIN";
            this.radioButtonIN.Size = new System.Drawing.Size(142, 24);
            this.radioButtonIN.TabIndex = 2;
            this.radioButtonIN.TabStop = true;
            this.radioButtonIN.Text = "Đĩa thuê ít nhất";
            this.radioButtonIN.UseVisualStyleBackColor = true;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 738);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txMabc);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTenBaoCao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cBNguoiBaoCao);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.dateTimePickerNgayLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoCao";
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.ComboBox cBNguoiBaoCao;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenBaoCao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txMabc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonIN;
        private System.Windows.Forms.RadioButton radioButtonNN;
        private System.Windows.Forms.RadioButton radioButtonDT;
    }
}