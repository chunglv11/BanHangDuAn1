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
<<<<<<< Updated upstream
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> Stashed changes
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbb_Loc = new System.Windows.Forms.ComboBox();
            this.dtg_ShowKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
<<<<<<< Updated upstream
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_KHD = new System.Windows.Forms.RadioButton();
            this.rbtn_HD = new System.Windows.Forms.RadioButton();
            this.txt_Diem = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
=======
            this.txb_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_KHD = new System.Windows.Forms.RadioButton();
            this.rbtn_HD = new System.Windows.Forms.RadioButton();
            this.txb_diem = new System.Windows.Forms.TextBox();
            this.txb_hoten = new System.Windows.Forms.TextBox();
>>>>>>> Stashed changes
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg_KicCo = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KicCo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Cbb_Loc);
            this.panel2.Controls.Add(this.dtg_ShowKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 396);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 340);
            this.panel2.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 21);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Tìm kiếm...";
            this.textBox2.Size = new System.Drawing.Size(308, 31);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(482, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lọc theo trạng thái:";
            // 
            // Cbb_Loc
            // 
            this.Cbb_Loc.FormattingEnabled = true;
            this.Cbb_Loc.Items.AddRange(new object[] {
            "Khách vãng lai",
            "Khách quen"});
            this.Cbb_Loc.Location = new System.Drawing.Point(689, 21);
            this.Cbb_Loc.Margin = new System.Windows.Forms.Padding(4);
            this.Cbb_Loc.Name = "Cbb_Loc";
            this.Cbb_Loc.Size = new System.Drawing.Size(188, 33);
            this.Cbb_Loc.TabIndex = 11;
            // 
            // dtg_ShowKhachHang
            // 
            this.dtg_ShowKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLight;
<<<<<<< Updated upstream
            this.dtg_ShowKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
=======
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ShowKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_ShowKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_ShowKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
>>>>>>> Stashed changes
            this.dtg_ShowKhachHang.Location = new System.Drawing.Point(15, 69);
            this.dtg_ShowKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_ShowKhachHang.Name = "dtg_ShowKhachHang";
            this.dtg_ShowKhachHang.RowHeadersWidth = 51;
            this.dtg_ShowKhachHang.RowTemplate.Height = 29;
            this.dtg_ShowKhachHang.Size = new System.Drawing.Size(862, 241);
            this.dtg_ShowKhachHang.TabIndex = 9;
<<<<<<< Updated upstream
            this.dtg_ShowKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowKhachHang_CellClick);
=======
>>>>>>> Stashed changes
            this.dtg_ShowKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ShowKhachHang_CellContentClick);
            // 
            // groupBox1
            // 
<<<<<<< Updated upstream
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbtn_KHD);
            this.groupBox1.Controls.Add(this.rbtn_HD);
            this.groupBox1.Controls.Add(this.txt_Diem);
            this.groupBox1.Controls.Add(this.txt_Ma);
=======
            this.groupBox1.Controls.Add(this.txb_sdt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbtn_KHD);
            this.groupBox1.Controls.Add(this.rbtn_HD);
            this.groupBox1.Controls.Add(this.txb_diem);
            this.groupBox1.Controls.Add(this.txb_hoten);
>>>>>>> Stashed changes
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
            this.groupBox1.Size = new System.Drawing.Size(1196, 274);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
<<<<<<< Updated upstream
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(166, 162);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(342, 35);
            this.txt_sdt.TabIndex = 10;
=======
            // txb_sdt
            // 
            this.txb_sdt.Location = new System.Drawing.Point(166, 162);
            this.txb_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txb_sdt.Name = "txb_sdt";
            this.txb_sdt.Size = new System.Drawing.Size(342, 35);
            this.txb_sdt.TabIndex = 10;
>>>>>>> Stashed changes
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số điện thoại:";
            // 
            // rbtn_KHD
            // 
            this.rbtn_KHD.AutoSize = true;
            this.rbtn_KHD.Location = new System.Drawing.Point(356, 219);
            this.rbtn_KHD.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_KHD.Name = "rbtn_KHD";
            this.rbtn_KHD.Size = new System.Drawing.Size(150, 34);
            this.rbtn_KHD.TabIndex = 8;
            this.rbtn_KHD.TabStop = true;
            this.rbtn_KHD.Text = "Khách quen";
            this.rbtn_KHD.UseVisualStyleBackColor = true;
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
            // 
            // rbtn_HD
            // 
            this.rbtn_HD.AutoSize = true;
            this.rbtn_HD.Location = new System.Drawing.Point(166, 216);
            this.rbtn_HD.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_HD.Name = "rbtn_HD";
            this.rbtn_HD.Size = new System.Drawing.Size(176, 34);
            this.rbtn_HD.TabIndex = 7;
            this.rbtn_HD.TabStop = true;
            this.rbtn_HD.Text = "Khách vãng lai";
            this.rbtn_HD.UseVisualStyleBackColor = true;
<<<<<<< Updated upstream
            
            // 
            // txt_Diem
            // 
            this.txt_Diem.Location = new System.Drawing.Point(166, 100);
            this.txt_Diem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.Size = new System.Drawing.Size(342, 35);
            this.txt_Diem.TabIndex = 5;
=======
            // 
            // txb_diem
            // 
            this.txb_diem.Location = new System.Drawing.Point(166, 100);
            this.txb_diem.Margin = new System.Windows.Forms.Padding(4);
            this.txb_diem.Name = "txb_diem";
            this.txb_diem.Size = new System.Drawing.Size(342, 35);
            this.txb_diem.TabIndex = 5;
>>>>>>> Stashed changes
            // 
            // txb_hoten
            // 
<<<<<<< Updated upstream
            this.txt_Ma.Location = new System.Drawing.Point(168, 42);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(340, 35);
            this.txt_Ma.TabIndex = 4;
=======
            this.txb_hoten.Location = new System.Drawing.Point(168, 42);
            this.txb_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.txb_hoten.Name = "txb_hoten";
            this.txb_hoten.Size = new System.Drawing.Size(340, 35);
            this.txb_hoten.TabIndex = 4;
>>>>>>> Stashed changes
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 219);
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
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm:";
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
<<<<<<< Updated upstream
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
=======
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
=======
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
>>>>>>> Stashed changes
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
            this.groupBox2.Size = new System.Drawing.Size(1196, 122);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 122);
            this.panel1.TabIndex = 16;
            // 
            // dtg_KicCo
            // 
            this.dtg_KicCo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
<<<<<<< Updated upstream
            this.dtg_KicCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
=======
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_KicCo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_KicCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_KicCo.DefaultCellStyle = dataGridViewCellStyle4;
>>>>>>> Stashed changes
            this.dtg_KicCo.Location = new System.Drawing.Point(15, 49);
            this.dtg_KicCo.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_KicCo.Name = "dtg_KicCo";
            this.dtg_KicCo.RowHeadersWidth = 51;
            this.dtg_KicCo.RowTemplate.Height = 29;
            this.dtg_KicCo.Size = new System.Drawing.Size(779, 245);
            this.dtg_KicCo.TabIndex = 8;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(15, 8);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(308, 31);
            this.txt_TimKiem.TabIndex = 7;
            this.txt_TimKiem.Text = "Tìm kiếm...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dtg_KicCo);
            this.panel3.Controls.Add(this.txt_TimKiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1196, 274);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1196, 274);
            this.panel4.TabIndex = 10;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1196, 736);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ShowKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_KicCo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox1;
        private RadioButton rbtn_KHD;
        private RadioButton rbtn_HD;
<<<<<<< Updated upstream
        private TextBox txt_Diem;
        private TextBox txt_Ma;
=======
        private TextBox txb_diem;
        private TextBox txb_hoten;
>>>>>>> Stashed changes
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_LamMoi;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private GroupBox groupBox2;
        private Panel panel1;
        private DataGridView dtg_KicCo;
        private TextBox txt_TimKiem;
        private Panel panel3;
<<<<<<< Updated upstream
        private TextBox txt_sdt;
=======
        private TextBox txb_sdt;
>>>>>>> Stashed changes
        private Label label4;
        private DataGridView dtg_ShowKhachHang;
        private Panel panel4;
        private ComboBox Cbb_Loc;
        private Label label5;
        private TextBox textBox2;
    }
}