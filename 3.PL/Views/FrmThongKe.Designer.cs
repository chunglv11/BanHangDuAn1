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
            lbl_LN = new Label();
            panel3 = new Panel();
            label6 = new Label();
            cmb_Thang = new ComboBox();
            label8 = new Label();
            groupBox4 = new GroupBox();
            dgrid_Show = new DataGridView();
            txt_TK = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmb_Nam = new ComboBox();
            label1 = new Label();
            txt_Sdt = new TextBox();
            label2 = new Label();
            lbl_HD = new Label();
            label12 = new Label();
            lbl_DoanhThu = new Label();
            panel4 = new Panel();
            lbl_KH = new Label();
            label11 = new Label();
            groupBox5 = new GroupBox();
            dtp_ngay = new DateTimePicker();
            label3 = new Label();
            TenSp = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            Soluong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            groupBox7 = new GroupBox();
            groupBox6 = new GroupBox();
            panel2 = new Panel();
            ID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            Sdt = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_Show).BeginInit();
            panel4.SuspendLayout();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_LN
            // 
            lbl_LN.AutoSize = true;
            lbl_LN.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_LN.Location = new Point(150, 96);
            lbl_LN.Name = "lbl_LN";
            lbl_LN.Size = new Size(22, 25);
            lbl_LN.TabIndex = 0;
            lbl_LN.Text = "0";
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lbl_LN);
            panel3.Location = new Point(899, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 181);
            panel3.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(114, 28);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 1;
            label6.Text = "Lợi nhuận";
            // 
            // cmb_Thang
            // 
            cmb_Thang.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Thang.FormattingEnabled = true;
            cmb_Thang.Location = new Point(216, 77);
            cmb_Thang.Margin = new Padding(5);
            cmb_Thang.Name = "cmb_Thang";
            cmb_Thang.Size = new Size(155, 33);
            cmb_Thang.TabIndex = 6;
            cmb_Thang.SelectedValueChanged += cmb_Thang_SelectedValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(221, 53);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 23);
            label8.TabIndex = 4;
            label8.Text = "Tháng";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgrid_Show);
            groupBox4.Controls.Add(txt_TK);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(1, 359);
            groupBox4.Margin = new Padding(5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5);
            groupBox4.Size = new Size(1186, 321);
            groupBox4.TabIndex = 36;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh Sách Bán";
            // 
            // dgrid_Show
            // 
            dgrid_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_Show.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, ThanhTien, Sdt });
            dgrid_Show.Location = new Point(22, 97);
            dgrid_Show.Margin = new Padding(5);
            dgrid_Show.Name = "dgrid_Show";
            dgrid_Show.RowHeadersWidth = 62;
            dgrid_Show.RowTemplate.Height = 33;
            dgrid_Show.Size = new Size(1155, 216);
            dgrid_Show.TabIndex = 5;
            // 
            // txt_TK
            // 
            txt_TK.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TK.Location = new Point(179, 57);
            txt_TK.Margin = new Padding(5);
            txt_TK.Name = "txt_TK";
            txt_TK.Size = new Size(997, 32);
            txt_TK.TabIndex = 4;
            txt_TK.TextChanged += txt_TK_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 59);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 3;
            label4.Text = "Tìm Kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 53);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 23);
            label5.TabIndex = 9;
            label5.Text = "Năm";
            // 
            // cmb_Nam
            // 
            cmb_Nam.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Nam.FormattingEnabled = true;
            cmb_Nam.Location = new Point(31, 77);
            cmb_Nam.Margin = new Padding(5);
            cmb_Nam.Name = "cmb_Nam";
            cmb_Nam.Size = new Size(171, 33);
            cmb_Nam.TabIndex = 7;
            cmb_Nam.SelectedValueChanged += cmb_Nam_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(80, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Doanh Thu";
            // 
            // txt_Sdt
            // 
            txt_Sdt.Location = new Point(19, 84);
            txt_Sdt.Name = "txt_Sdt";
            txt_Sdt.Size = new Size(255, 32);
            txt_Sdt.TabIndex = 7;
            txt_Sdt.TextChanged += txt_Sdt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 53);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 23);
            label2.TabIndex = 6;
            label2.Text = "Số Điện Thoại Khách Hàng";
            // 
            // lbl_HD
            // 
            lbl_HD.AutoSize = true;
            lbl_HD.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_HD.ForeColor = Color.Black;
            lbl_HD.Location = new Point(126, 89);
            lbl_HD.Margin = new Padding(5, 0, 5, 0);
            lbl_HD.Name = "lbl_HD";
            lbl_HD.Size = new Size(22, 25);
            lbl_HD.TabIndex = 6;
            lbl_HD.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(87, 27);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(112, 25);
            label12.TabIndex = 11;
            label12.Text = "Số Hóa Đơn";
            // 
            // lbl_DoanhThu
            // 
            lbl_DoanhThu.AutoSize = true;
            lbl_DoanhThu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DoanhThu.ForeColor = Color.Black;
            lbl_DoanhThu.Location = new Point(117, 89);
            lbl_DoanhThu.Margin = new Padding(5, 0, 5, 0);
            lbl_DoanhThu.Name = "lbl_DoanhThu";
            lbl_DoanhThu.Size = new Size(22, 25);
            lbl_DoanhThu.TabIndex = 1;
            lbl_DoanhThu.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaShell;
            panel4.Controls.Add(lbl_KH);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(589, 0);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 179);
            panel4.TabIndex = 31;
            // 
            // lbl_KH
            // 
            lbl_KH.AutoSize = true;
            lbl_KH.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_KH.ForeColor = Color.Black;
            lbl_KH.Location = new Point(134, 89);
            lbl_KH.Margin = new Padding(5, 0, 5, 0);
            lbl_KH.Name = "lbl_KH";
            lbl_KH.Size = new Size(22, 25);
            lbl_KH.TabIndex = 9;
            lbl_KH.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(70, 27);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(162, 25);
            label11.TabIndex = 10;
            label11.Text = "Tổng Khách Hàng";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dtp_ngay);
            groupBox5.Controls.Add(label3);
            groupBox5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(16, 203);
            groupBox5.Margin = new Padding(5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(5);
            groupBox5.Size = new Size(369, 145);
            groupBox5.TabIndex = 33;
            groupBox5.TabStop = false;
            groupBox5.Text = "Theo Ngày";
            // 
            // dtp_ngay
            // 
            dtp_ngay.Location = new Point(62, 80);
            dtp_ngay.Name = "dtp_ngay";
            dtp_ngay.Size = new Size(250, 32);
            dtp_ngay.TabIndex = 11;
            dtp_ngay.ValueChanged += dtp_ngay_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 53);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 10;
            label3.Text = "Ngày";
            // 
            // TenSp
            // 
            TenSp.HeaderText = "Ten SP";
            TenSp.MinimumWidth = 6;
            TenSp.Name = "TenSp";
            TenSp.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(lbl_DoanhThu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 179);
            panel1.TabIndex = 30;
            // 
            // Soluong
            // 
            Soluong.HeaderText = "So luong";
            Soluong.MinimumWidth = 6;
            Soluong.Name = "Soluong";
            Soluong.Width = 125;
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Don Gia";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.Width = 125;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(cmb_Nam);
            groupBox7.Controls.Add(cmb_Thang);
            groupBox7.Controls.Add(label8);
            groupBox7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox7.Location = new Point(452, 203);
            groupBox7.Margin = new Padding(5);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(5);
            groupBox7.Size = new Size(410, 145);
            groupBox7.TabIndex = 35;
            groupBox7.TabStop = false;
            groupBox7.Text = "Theo Tháng ,Năm";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txt_Sdt);
            groupBox6.Controls.Add(label2);
            groupBox6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(904, 203);
            groupBox6.Margin = new Padding(5);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(5);
            groupBox6.Size = new Size(283, 145);
            groupBox6.TabIndex = 34;
            groupBox6.TabStop = false;
            groupBox6.Text = "Theo Khách Hàng";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(lbl_HD);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(281, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 179);
            panel2.TabIndex = 32;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "TenSP";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "SoLuong";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "DonGia";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "ThanhTien";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 125;
            // 
            // Sdt
            // 
            Sdt.HeaderText = "Sdt";
            Sdt.MinimumWidth = 6;
            Sdt.Name = "Sdt";
            Sdt.Width = 125;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1189, 678);
            Controls.Add(panel3);
            Controls.Add(groupBox4);
            Controls.Add(panel4);
            Controls.Add(groupBox5);
            Controls.Add(panel1);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(panel2);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_Show).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_LN;
        private Panel panel3;
        private Label label6;
        private ComboBox cmb_Thang;
        private Label label8;
        private GroupBox groupBox4;
        private DataGridView dgrid_Show;
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
        private Label label3;
        private DateTimePicker dtp_ngay;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn Sdt;
    }
}