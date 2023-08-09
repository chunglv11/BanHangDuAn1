namespace _3.PL.Views
{
    partial class FrmKhachHang
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
            panel2 = new Panel();
            textBox2 = new TextBox();
            dtg_ShowKhachHang = new DataGridView();
            groupBox1 = new GroupBox();
            txb_sdt = new TextBox();
            label4 = new Label();
            rbtn_Quen = new RadioButton();
            rbtn_Vang = new RadioButton();
            txb_hoten = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_LamMoi = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            dtg_KicCo = new DataGridView();
            txt_TimKiem = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_KicCo).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(dtg_ShowKhachHang);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 272);
            panel2.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 17);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nhập số điện thoại";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dtg_ShowKhachHang
            // 
            dtg_ShowKhachHang.BackgroundColor = SystemColors.ControlLight;
            dtg_ShowKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ShowKhachHang.Location = new Point(12, 55);
            dtg_ShowKhachHang.Name = "dtg_ShowKhachHang";
            dtg_ShowKhachHang.RowHeadersWidth = 51;
            dtg_ShowKhachHang.RowTemplate.Height = 29;
            dtg_ShowKhachHang.Size = new Size(690, 193);
            dtg_ShowKhachHang.TabIndex = 9;
            dtg_ShowKhachHang.CellClick += dtg_ShowKhachHang_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txb_sdt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(rbtn_Quen);
            groupBox1.Controls.Add(rbtn_Vang);
            groupBox1.Controls.Add(txb_hoten);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 219);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khách hàng";
            // 
            // txb_sdt
            // 
            txb_sdt.Location = new Point(134, 82);
            txb_sdt.Name = "txb_sdt";
            txb_sdt.Size = new Size(274, 30);
            txb_sdt.TabIndex = 10;
            txb_sdt.KeyPress += txb_sdt_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 85);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 9;
            label4.Text = "Số điện thoại:";
            // 
            // rbtn_Quen
            // 
            rbtn_Quen.AutoSize = true;
            rbtn_Quen.Location = new Point(286, 137);
            rbtn_Quen.Name = "rbtn_Quen";
            rbtn_Quen.Size = new Size(122, 27);
            rbtn_Quen.TabIndex = 8;
            rbtn_Quen.TabStop = true;
            rbtn_Quen.Text = "Khách quen";
            rbtn_Quen.UseVisualStyleBackColor = true;
            // 
            // rbtn_Vang
            // 
            rbtn_Vang.AutoSize = true;
            rbtn_Vang.Location = new Point(134, 135);
            rbtn_Vang.Name = "rbtn_Vang";
            rbtn_Vang.Size = new Size(143, 27);
            rbtn_Vang.TabIndex = 7;
            rbtn_Vang.TabStop = true;
            rbtn_Vang.Text = "Khách vãng lai";
            rbtn_Vang.UseVisualStyleBackColor = true;
            // 
            // txb_hoten
            // 
            txb_hoten.Location = new Point(134, 34);
            txb_hoten.Name = "txb_hoten";
            txb_hoten.Size = new Size(273, 30);
            txb_hoten.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 137);
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
            label2.Size = new Size(68, 23);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên:";
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.Image = Properties.Resources.reset;
            btn_LamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LamMoi.Location = new Point(400, 39);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(158, 42);
            btn_LamMoi.TabIndex = 3;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = true;
            btn_LamMoi.Click += btn_LamMoi_Click;
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
            btn_Sua.Click += btn_Sua_Click;
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
            btn_Them.Click += btn_Them_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_LamMoi);
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(724, 98);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 98);
            panel1.TabIndex = 16;
            // 
            // dtg_KicCo
            // 
            dtg_KicCo.BackgroundColor = SystemColors.ControlLight;
            dtg_KicCo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_KicCo.Location = new Point(12, 39);
            dtg_KicCo.Name = "dtg_KicCo";
            dtg_KicCo.RowHeadersWidth = 51;
            dtg_KicCo.RowTemplate.Height = 29;
            dtg_KicCo.Size = new Size(623, 196);
            dtg_KicCo.TabIndex = 8;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(12, 6);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(247, 27);
            txt_TimKiem.TabIndex = 7;
            txt_TimKiem.Text = "Tìm kiếm...";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dtg_KicCo);
            panel3.Controls.Add(txt_TimKiem);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(724, 219);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(724, 219);
            panel4.TabIndex = 10;
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(724, 589);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "FrmKhachHang";
            Text = "FrmKhachHang";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_KicCo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox1;
        private RadioButton rbtn_Quen;
        private RadioButton rbtn_Vang;
        private TextBox txb_hoten;

        private Label label3;
        private Label label2;
        private Button btn_LamMoi;
        private Button btn_Sua;
        private Button btn_Them;
        private GroupBox groupBox2;
        private Panel panel1;
        private DataGridView dtg_KicCo;
        private TextBox txt_TimKiem;
        private Panel panel3;

        private TextBox txb_sdt;

        private Label label4;
        private DataGridView dtg_ShowKhachHang;
        private Panel panel4;
        private TextBox textBox2;
    }
}