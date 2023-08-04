namespace _3.PL.Views
{
    partial class FrmQuanLyHoaDon
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            dtg_hdct = new DataGridView();
            groupBox1 = new GroupBox();
            btn_Xoa = new Button();
            tb_timkiem = new TextBox();
            dtg_ShowHD = new DataGridView();
            rdb_Chua = new RadioButton();
            rdb_Da = new RadioButton();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hdct).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowHD).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 725);
            panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_hdct);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1277, 387);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // dtg_hdct
            // 
            dtg_hdct.BackgroundColor = Color.SeaShell;
            dtg_hdct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hdct.Location = new Point(7, 35);
            dtg_hdct.Name = "dtg_hdct";
            dtg_hdct.RowHeadersWidth = 51;
            dtg_hdct.RowTemplate.Height = 29;
            dtg_hdct.Size = new Size(1053, 346);
            dtg_hdct.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_Da);
            groupBox1.Controls.Add(rdb_Chua);
            groupBox1.Controls.Add(btn_Xoa);
            groupBox1.Controls.Add(tb_timkiem);
            groupBox1.Controls.Add(dtg_ShowHD);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1277, 335);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // btn_Xoa
            // 
            btn_Xoa.Image = Properties.Resources.delete;
            btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new Point(355, 30);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(196, 40);
            btn_Xoa.TabIndex = 4;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // tb_timkiem
            // 
            tb_timkiem.Location = new Point(12, 33);
            tb_timkiem.Name = "tb_timkiem";
            tb_timkiem.PlaceholderText = "Tìm kiếm...";
            tb_timkiem.Size = new Size(273, 34);
            tb_timkiem.TabIndex = 1;
            tb_timkiem.TextChanged += tb_timkiem_TextChanged;
            // 
            // dtg_ShowHD
            // 
            dtg_ShowHD.BackgroundColor = Color.SeaShell;
            dtg_ShowHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ShowHD.Location = new Point(12, 88);
            dtg_ShowHD.Name = "dtg_ShowHD";
            dtg_ShowHD.RowHeadersWidth = 51;
            dtg_ShowHD.RowTemplate.Height = 29;
            dtg_ShowHD.Size = new Size(1222, 217);
            dtg_ShowHD.TabIndex = 0;
            dtg_ShowHD.CellClick += dtg_ShowHD_CellClick;
            // 
            // rdb_Chua
            // 
            rdb_Chua.AutoSize = true;
            rdb_Chua.Location = new Point(629, 33);
            rdb_Chua.Name = "rdb_Chua";
            rdb_Chua.Size = new Size(185, 32);
            rdb_Chua.TabIndex = 5;
            rdb_Chua.TabStop = true;
            rdb_Chua.Text = "Chưa thanh toán";
            rdb_Chua.UseVisualStyleBackColor = true;
            rdb_Chua.CheckedChanged += rdb_Chua_CheckedChanged;
            // 
            // rdb_Da
            // 
            rdb_Da.AutoSize = true;
            rdb_Da.Location = new Point(853, 33);
            rdb_Da.Name = "rdb_Da";
            rdb_Da.Size = new Size(163, 32);
            rdb_Da.TabIndex = 6;
            rdb_Da.TabStop = true;
            rdb_Da.Text = "Đã thanh toán";
            rdb_Da.UseVisualStyleBackColor = true;
            rdb_Da.CheckedChanged += rdb_Da_CheckedChanged;
            // 
            // FrmQuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1277, 725);
            Controls.Add(panel1);
            Name = "FrmQuanLyHoaDon";
            Text = "FrmQuanLyHoaDon";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_hdct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox tb_timkiem;
        private DataGridView dtg_ShowHD;
        private GroupBox groupBox2;
        private DataGridView dtg_hdct;
        private Button btn_Xoa;
        private RadioButton rdb_Chua;
        private RadioButton rdb_Da;
    }
}