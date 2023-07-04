namespace _3.PL.Views
{
    partial class FrmSanPham
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
            groupBox1 = new GroupBox();
            rbtn_KHD = new RadioButton();
            rbtn_HD = new RadioButton();
            txt_Ten = new TextBox();
            txt_Ma = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_TimKiem = new TextBox();
            dtg_ShowSanPham = new DataGridView();
            groupBox2 = new GroupBox();
            btn_LamMoi = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowSanPham).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtn_KHD);
            groupBox1.Controls.Add(rbtn_HD);
            groupBox1.Controls.Add(txt_Ten);
            groupBox1.Controls.Add(txt_Ma);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(957, 196);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // rbtn_KHD
            // 
            rbtn_KHD.AutoSize = true;
            rbtn_KHD.Location = new Point(248, 126);
            rbtn_KHD.Name = "rbtn_KHD";
            rbtn_KHD.Size = new Size(166, 27);
            rbtn_KHD.TabIndex = 8;
            rbtn_KHD.TabStop = true;
            rbtn_KHD.Text = "Không hoạt động";
            rbtn_KHD.UseVisualStyleBackColor = true;
            // 
            // rbtn_HD
            // 
            rbtn_HD.AutoSize = true;
            rbtn_HD.Location = new Point(113, 126);
            rbtn_HD.Name = "rbtn_HD";
            rbtn_HD.Size = new Size(114, 27);
            rbtn_HD.TabIndex = 7;
            rbtn_HD.TabStop = true;
            rbtn_HD.Text = "Hoạt động";
            rbtn_HD.UseVisualStyleBackColor = true;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(113, 80);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(274, 30);
            txt_Ten.TabIndex = 5;
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(114, 34);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(273, 30);
            txt_Ma.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên:";
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(12, 6);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(300, 27);
            txt_TimKiem.TabIndex = 7;
            txt_TimKiem.Text = "Tìm kiếm...";
            // 
            // dtg_ShowSanPham
            // 
            dtg_ShowSanPham.BackgroundColor = SystemColors.ControlLight;
            dtg_ShowSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ShowSanPham.Location = new Point(12, 55);
            dtg_ShowSanPham.Name = "dtg_ShowSanPham";
            dtg_ShowSanPham.RowHeadersWidth = 51;
            dtg_ShowSanPham.RowTemplate.Height = 29;
            dtg_ShowSanPham.Size = new Size(601, 163);
            dtg_ShowSanPham.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_LamMoi);
            groupBox2.Controls.Add(btn_Xoa);
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(957, 113);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.Image = Properties.Resources.reset;
            btn_LamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LamMoi.Location = new Point(600, 39);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(158, 42);
            btn_LamMoi.TabIndex = 3;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Image = Properties.Resources.delete;
            btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new Point(405, 39);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(158, 42);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Image = Properties.Resources.updated;
            btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sua.Location = new Point(216, 39);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(158, 42);
            btn_Sua.TabIndex = 1;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            btn_Them.Image = Properties.Resources.add;
            btn_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Them.Location = new Point(30, 39);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(158, 42);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 196);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 113);
            panel1.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_TimKiem);
            panel3.Controls.Add(dtg_ShowSanPham);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(957, 233);
            panel3.TabIndex = 13;
            // 
            // FrmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(957, 542);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmSanPham";
            Text = "FrmSanPham";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowSanPham).EndInit();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbtn_KHD;
        private RadioButton rbtn_HD;
        private TextBox txt_Ten;
        private TextBox txt_Ma;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_TimKiem;
        private DataGridView dtg_ShowSanPham;
        private GroupBox groupBox2;
        private Button btn_LamMoi;
        private Button btn_Xoa;
        private Button btn_Them;
        private Button btn_Sua;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
    }
}