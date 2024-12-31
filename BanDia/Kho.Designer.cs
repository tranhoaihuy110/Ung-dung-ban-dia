namespace BanDia
{
    partial class Kho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kho));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMa = new System.Windows.Forms.RadioButton();
            this.radioButtonTen = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.comboBoxTim = new System.Windows.Forms.ComboBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(974, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.radioButtonTen);
            this.groupBox1.Controls.Add(this.radioButtonMa);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Location = new System.Drawing.Point(61, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // radioButtonMa
            // 
            this.radioButtonMa.AutoSize = true;
            this.radioButtonMa.Location = new System.Drawing.Point(226, 78);
            this.radioButtonMa.Name = "radioButtonMa";
            this.radioButtonMa.Size = new System.Drawing.Size(121, 24);
            this.radioButtonMa.TabIndex = 0;
            this.radioButtonMa.TabStop = true;
            this.radioButtonMa.Text = "Mã băng đĩa";
            this.radioButtonMa.UseVisualStyleBackColor = true;
            // 
            // radioButtonTen
            // 
            this.radioButtonTen.AutoSize = true;
            this.radioButtonTen.Location = new System.Drawing.Point(226, 108);
            this.radioButtonTen.Name = "radioButtonTen";
            this.radioButtonTen.Size = new System.Drawing.Size(126, 24);
            this.radioButtonTen.TabIndex = 1;
            this.radioButtonTen.TabStop = true;
            this.radioButtonTen.Text = "Tên băng đĩa";
            this.radioButtonTen.UseVisualStyleBackColor = true;
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
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(873, 432);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 35);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Liệt kê";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // comboBoxTim
            // 
            this.comboBoxTim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTim.FormattingEnabled = true;
            this.comboBoxTim.Items.AddRange(new object[] {
            "Số lượng tăng dần",
            "Số lượng giảm dần"});
            this.comboBoxTim.Location = new System.Drawing.Point(525, 474);
            this.comboBoxTim.Name = "comboBoxTim";
            this.comboBoxTim.Size = new System.Drawing.Size(323, 28);
            this.comboBoxTim.TabIndex = 4;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(109, 41);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(243, 26);
            this.txtTim.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(614, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(873, 492);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBoxTim);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kho";
            this.Text = "Quản Lý Kho";
            this.Load += new System.EventHandler(this.Kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.RadioButton radioButtonTen;
        private System.Windows.Forms.RadioButton radioButtonMa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox comboBoxTim;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}