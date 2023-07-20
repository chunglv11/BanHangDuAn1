namespace _3.PL.Views
{
    partial class FrmPhuongThucTT
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_KHD = new System.Windows.Forms.RadioButton();
            this.rbtn_HD = new System.Windows.Forms.RadioButton();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dtg_ShowMauSac = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.dtg_ShowChucVu = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowMauSac)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 142);
            this.panel2.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LamMoi);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1196, 142);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = global::_3.PL.Properties.Resources.reset;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(750, 49);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(198, 52);
            this.btn_LamMoi.TabIndex = 3;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;

            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);

            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::_3.PL.Properties.Resources.delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(506, 49);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(198, 52);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;

            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);

            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::_3.PL.Properties.Resources.updated;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(270, 49);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(198, 52);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;

            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);

            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::_3.PL.Properties.Resources.add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(38, 49);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(198, 52);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_KHD);
            this.groupBox1.Controls.Add(this.rbtn_HD);
            this.groupBox1.Controls.Add(this.txt_Ten);
            this.groupBox1.Controls.Add(this.txt_Ma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1196, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // rbtn_KHD
            // 
            this.rbtn_KHD.AutoSize = true;
            this.rbtn_KHD.Location = new System.Drawing.Point(310, 158);
            this.rbtn_KHD.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_KHD.Name = "rbtn_KHD";
            this.rbtn_KHD.Size = new System.Drawing.Size(208, 34);
            this.rbtn_KHD.TabIndex = 8;
            this.rbtn_KHD.TabStop = true;
            this.rbtn_KHD.Text = "Không hoạt động";
            this.rbtn_KHD.UseVisualStyleBackColor = true;
            // 
            // rbtn_HD
            // 
            this.rbtn_HD.AutoSize = true;
            this.rbtn_HD.Location = new System.Drawing.Point(141, 158);
            this.rbtn_HD.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_HD.Name = "rbtn_HD";
            this.rbtn_HD.Size = new System.Drawing.Size(142, 34);
            this.rbtn_HD.TabIndex = 7;
            this.rbtn_HD.TabStop = true;
            this.rbtn_HD.Text = "Hoạt động";
            this.rbtn_HD.UseVisualStyleBackColor = true;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(141, 100);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(342, 35);
            this.txt_Ten.TabIndex = 5;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(142, 42);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(340, 35);
            this.txt_Ma.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 214);
            this.panel1.TabIndex = 16;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(15, 8);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm...";
            this.txt_TimKiem.Size = new System.Drawing.Size(308, 31);
            this.txt_TimKiem.TabIndex = 12;
            // 
            // dtg_ShowMauSac
            // 
            this.dtg_ShowMauSac.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtg_ShowMauSac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowMauSac.Location = new System.Drawing.Point(15, 49);
            this.dtg_ShowMauSac.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_ShowMauSac.Name = "dtg_ShowMauSac";
            this.dtg_ShowMauSac.RowHeadersWidth = 51;
            this.dtg_ShowMauSac.RowTemplate.Height = 29;
            this.dtg_ShowMauSac.Size = new System.Drawing.Size(779, 261);
            this.dtg_ShowMauSac.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_TimKiem);
            this.panel3.Controls.Add(this.dtg_ShowChucVu);
            this.panel3.Controls.Add(this.txt_TimKiem);
            this.panel3.Controls.Add(this.dtg_ShowMauSac);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1196, 678);
            this.panel3.TabIndex = 18;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(15, 376);
            this.tb_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.PlaceholderText = "Tìm kiếm";
            this.tb_TimKiem.Size = new System.Drawing.Size(374, 31);
            this.tb_TimKiem.TabIndex = 14;

            // 
            // dtg_ShowChucVu
            // 
            this.dtg_ShowChucVu.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtg_ShowChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ShowChucVu.Location = new System.Drawing.Point(15, 429);
            this.dtg_ShowChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_ShowChucVu.Name = "dtg_ShowChucVu";
            this.dtg_ShowChucVu.RowHeadersWidth = 51;
            this.dtg_ShowChucVu.RowTemplate.Height = 29;
            this.dtg_ShowChucVu.Size = new System.Drawing.Size(779, 245);
            this.dtg_ShowChucVu.TabIndex = 13;

            // 
            // FrmPhuongThucTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1196, 678);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPhuongThucTT";
            this.Text = "FrmPhuongThucTT";
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowMauSac)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox2;
        private Button btn_LamMoi;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private GroupBox groupBox1;
        private RadioButton rbtn_KHD;
        private RadioButton rbtn_HD;
        private TextBox txt_Ten;
        private TextBox txt_Ma;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox txt_TimKiem;
        private DataGridView dtg_ShowMauSac;
        private Panel panel3;
        private DataGridView dtg_ShowChucVu;
        private TextBox tb_TimKiem;
    }
}