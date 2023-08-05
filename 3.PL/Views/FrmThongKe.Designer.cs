namespace _3.PL.Views
{
    partial class FrmThongKe
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
            this.lbl_LN = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Thang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrid_Show = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Nam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_HD = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_DoanhThu = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_KH = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Ngay = new System.Windows.Forms.ComboBox();
            this.TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Show)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_LN
            // 
            this.lbl_LN.AutoSize = true;
            this.lbl_LN.Location = new System.Drawing.Point(150, 96);
            this.lbl_LN.Name = "lbl_LN";
            this.lbl_LN.Size = new System.Drawing.Size(17, 20);
            this.lbl_LN.TabIndex = 0;
            this.lbl_LN.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lbl_LN);
            this.panel3.Location = new System.Drawing.Point(899, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 181);
            this.panel3.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(114, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lợi nhuận";
            // 
            // cmb_Thang
            // 
            this.cmb_Thang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Thang.FormattingEnabled = true;
            this.cmb_Thang.Location = new System.Drawing.Point(216, 77);
            this.cmb_Thang.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_Thang.Name = "cmb_Thang";
            this.cmb_Thang.Size = new System.Drawing.Size(155, 33);
            this.cmb_Thang.TabIndex = 6;
            this.cmb_Thang.SelectedValueChanged += new System.EventHandler(this.cmb_Thang_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(221, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tháng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgrid_Show);
            this.groupBox4.Controls.Add(this.txt_TK);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(1, 359);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(1186, 321);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Bán";
            // 
            // dgrid_Show
            // 
            this.dgrid_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.TongTien,
            this.Sdt});
            this.dgrid_Show.Location = new System.Drawing.Point(22, 97);
            this.dgrid_Show.Margin = new System.Windows.Forms.Padding(5);
            this.dgrid_Show.Name = "dgrid_Show";
            this.dgrid_Show.RowHeadersWidth = 62;
            this.dgrid_Show.RowTemplate.Height = 33;
            this.dgrid_Show.Size = new System.Drawing.Size(1155, 216);
            this.dgrid_Show.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TenSP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DonGia";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "TongTien";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // Sdt
            // 
            this.Sdt.HeaderText = "Sdt";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 125;
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TK.Location = new System.Drawing.Point(179, 57);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(5);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(997, 32);
            this.txt_TK.TabIndex = 4;
            this.txt_TK.TextChanged += new System.EventHandler(this.txt_TK_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tìm Kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Năm";
            // 
            // cmb_Nam
            // 
            this.cmb_Nam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Nam.FormattingEnabled = true;
            this.cmb_Nam.Location = new System.Drawing.Point(31, 77);
            this.cmb_Nam.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_Nam.Name = "cmb_Nam";
            this.cmb_Nam.Size = new System.Drawing.Size(171, 33);
            this.cmb_Nam.TabIndex = 7;
            this.cmb_Nam.SelectedValueChanged += new System.EventHandler(this.cmb_Nam_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(19, 84);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(255, 32);
            this.txt_Sdt.TabIndex = 7;
            this.txt_Sdt.TextChanged += new System.EventHandler(this.txt_Sdt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số Điện Thoại Khách Hàng";
            // 
            // lbl_HD
            // 
            this.lbl_HD.AutoSize = true;
            this.lbl_HD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_HD.ForeColor = System.Drawing.Color.Black;
            this.lbl_HD.Location = new System.Drawing.Point(126, 89);
            this.lbl_HD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_HD.Name = "lbl_HD";
            this.lbl_HD.Size = new System.Drawing.Size(22, 25);
            this.lbl_HD.TabIndex = 6;
            this.lbl_HD.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(87, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Số Hóa Đơn";
            // 
            // lbl_DoanhThu
            // 
            this.lbl_DoanhThu.AutoSize = true;
            this.lbl_DoanhThu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DoanhThu.ForeColor = System.Drawing.Color.Black;
            this.lbl_DoanhThu.Location = new System.Drawing.Point(117, 89);
            this.lbl_DoanhThu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_DoanhThu.Name = "lbl_DoanhThu";
            this.lbl_DoanhThu.Size = new System.Drawing.Size(22, 25);
            this.lbl_DoanhThu.TabIndex = 1;
            this.lbl_DoanhThu.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.Controls.Add(this.lbl_KH);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(589, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 179);
            this.panel4.TabIndex = 31;
            // 
            // lbl_KH
            // 
            this.lbl_KH.AutoSize = true;
            this.lbl_KH.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_KH.ForeColor = System.Drawing.Color.Black;
            this.lbl_KH.Location = new System.Drawing.Point(134, 89);
            this.lbl_KH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_KH.Name = "lbl_KH";
            this.lbl_KH.Size = new System.Drawing.Size(22, 25);
            this.lbl_KH.TabIndex = 9;
            this.lbl_KH.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(70, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng Khách Hàng";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cmb_Ngay);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(16, 203);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(369, 145);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Theo Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày";
            // 
            // cmb_Ngay
            // 
            this.cmb_Ngay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Ngay.FormattingEnabled = true;
            this.cmb_Ngay.Location = new System.Drawing.Point(32, 77);
            this.cmb_Ngay.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_Ngay.Name = "cmb_Ngay";
            this.cmb_Ngay.Size = new System.Drawing.Size(171, 33);
            this.cmb_Ngay.TabIndex = 10;
            this.cmb_Ngay.SelectedValueChanged += new System.EventHandler(this.cmb_Ngay_SelectedValueChanged);
            // 
            // TenSp
            // 
            this.TenSp.HeaderText = "Ten SP";
            this.TenSp.MinimumWidth = 6;
            this.TenSp.Name = "TenSp";
            this.TenSp.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.lbl_DoanhThu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 179);
            this.panel1.TabIndex = 30;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "So luong";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Don Gia";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.cmb_Nam);
            this.groupBox7.Controls.Add(this.cmb_Thang);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.Location = new System.Drawing.Point(452, 203);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox7.Size = new System.Drawing.Size(410, 145);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Theo Tháng ,Năm";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_Sdt);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(904, 203);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(283, 145);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Theo Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.lbl_HD);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 179);
            this.panel2.TabIndex = 32;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1189, 678);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.panel2);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Show)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_LN;
        private Panel panel3;
        private Label label6;
        private ComboBox cmb_Thang;
        private Label label8;
        private GroupBox groupBox4;
        private DataGridView dgrid_Show;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn Sdt;
        private TextBox txt_TK;
        private Label label4;
        private Label label5;
        private ComboBox cmb_Nam;
        private Label label1;
        private TextBox txt_Sdt;
        private Label label2;
        private Label lbl_HD;
        private Label label12;
        private Label lbl_DoanhThu;
        private Panel panel4;
        private Label lbl_KH;
        private Label label11;
        private GroupBox groupBox5;
        private DataGridViewTextBoxColumn TenSp;
        private Panel panel1;
        private DataGridViewTextBoxColumn Soluong;
        private DataGridViewTextBoxColumn DonGia;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private Panel panel2;
        private DataGridViewTextBoxColumn ID;
        private ComboBox cmb_Ngay;
        private Label label3;
    }
}