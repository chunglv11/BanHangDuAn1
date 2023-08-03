namespace _3.PL.Views
{
    partial class FrmThongTinHoaDon
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lb_MaHD = new Label();
            lb_MaNV = new Label();
            lb_SDTkh = new Label();
            lb_TongTien = new Label();
            dgv_Show = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btn_in = new Button();
            lb_Ngaytt = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Show).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(379, 41);
            label1.TabIndex = 0;
            label1.Text = "Shop quần áo nam hổ béo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 115);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã hoá đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 156);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 2;
            label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 200);
            label4.Name = "label4";
            label4.Size = new Size(134, 23);
            label4.TabIndex = 3;
            label4.Text = "SDT khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 242);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền";
            // 
            // lb_MaHD
            // 
            lb_MaHD.AutoSize = true;
            lb_MaHD.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_MaHD.Location = new Point(187, 115);
            lb_MaHD.Name = "lb_MaHD";
            lb_MaHD.Size = new Size(34, 23);
            lb_MaHD.TabIndex = 5;
            lb_MaHD.Text = "......";
            // 
            // lb_MaNV
            // 
            lb_MaNV.AutoSize = true;
            lb_MaNV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_MaNV.Location = new Point(187, 156);
            lb_MaNV.Name = "lb_MaNV";
            lb_MaNV.Size = new Size(34, 23);
            lb_MaNV.TabIndex = 6;
            lb_MaNV.Text = "......";
            // 
            // lb_SDTkh
            // 
            lb_SDTkh.AutoSize = true;
            lb_SDTkh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_SDTkh.Location = new Point(187, 200);
            lb_SDTkh.Name = "lb_SDTkh";
            lb_SDTkh.Size = new Size(34, 23);
            lb_SDTkh.TabIndex = 7;
            lb_SDTkh.Text = "......";
            // 
            // lb_TongTien
            // 
            lb_TongTien.AutoSize = true;
            lb_TongTien.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TongTien.Location = new Point(187, 242);
            lb_TongTien.Name = "lb_TongTien";
            lb_TongTien.Size = new Size(34, 23);
            lb_TongTien.TabIndex = 8;
            lb_TongTien.Text = "......";
            // 
            // dgv_Show
            // 
            dgv_Show.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Show.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgv_Show.Location = new Point(12, 280);
            dgv_Show.Name = "dgv_Show";
            dgv_Show.RowHeadersWidth = 51;
            dgv_Show.RowTemplate.Height = 29;
            dgv_Show.Size = new Size(602, 211);
            dgv_Show.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn giá";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Thành tiền";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // btn_in
            // 
            btn_in.BackColor = SystemColors.ButtonHighlight;
            btn_in.FlatStyle = FlatStyle.Popup;
            btn_in.Location = new Point(268, 497);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(94, 45);
            btn_in.TabIndex = 10;
            btn_in.Text = "IN";
            btn_in.UseVisualStyleBackColor = false;
            btn_in.Click += btn_in_Click;
            // 
            // lb_Ngaytt
            // 
            lb_Ngaytt.AutoSize = true;
            lb_Ngaytt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Ngaytt.Location = new Point(187, 75);
            lb_Ngaytt.Name = "lb_Ngaytt";
            lb_Ngaytt.Size = new Size(34, 23);
            lb_Ngaytt.TabIndex = 12;
            lb_Ngaytt.Text = "......";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 75);
            label7.Name = "label7";
            label7.Size = new Size(141, 23);
            label7.TabIndex = 11;
            label7.Text = "Ngày thanh toán";
            // 
            // FrmThongTinHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(626, 544);
            Controls.Add(lb_Ngaytt);
            Controls.Add(label7);
            Controls.Add(btn_in);
            Controls.Add(dgv_Show);
            Controls.Add(lb_TongTien);
            Controls.Add(lb_SDTkh);
            Controls.Add(lb_MaNV);
            Controls.Add(lb_MaHD);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmThongTinHoaDon";
            Text = "FrmThongTinHoaDon";
            Load += FrmThongTinHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lb_MaHD;
        private Label lb_MaNV;
        private Label lb_SDTkh;
        private Label lb_TongTien;
        private DataGridView dgv_Show;
        private Button btn_in;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label lb_Ngaytt;
        private Label label7;
    }
}