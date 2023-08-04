namespace _3.PL.Views
{
    partial class FrmThongTin
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
            panelFill = new Panel();
            button1 = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            lb_GioiTinh = new Label();
            LblSex = new Label();
            panel4 = new Panel();
            groupBox4 = new GroupBox();
            lb_CV = new Label();
            LblRole = new Label();
            s = new GroupBox();
            lb_Email = new Label();
            LblCCCD = new Label();
            g1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            LblDob = new Label();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            lb_HoTen = new Label();
            LblName = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tb_Ten = new Label();
            tb_MaNV = new Label();
            ptb_Avt = new PictureBox();
            panelFill.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox4.SuspendLayout();
            s.SuspendLayout();
            g1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Avt).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(button1);
            panelFill.Controls.Add(groupBox1);
            panelFill.Controls.Add(tableLayoutPanel4);
            panelFill.Controls.Add(ptb_Avt);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(865, 745);
            panelFill.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(195, 646);
            button1.Name = "button1";
            button1.Size = new Size(159, 87);
            button1.TabIndex = 8;
            button1.Text = "Đổi mật khẩu";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(21, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 430);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox5, 0, 2);
            tableLayoutPanel3.Controls.Add(panel4, 0, 1);
            tableLayoutPanel3.Controls.Add(s, 0, 4);
            tableLayoutPanel3.Controls.Add(g1, 0, 3);
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Location = new Point(41, 52);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(0, 0, 10, 0);
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(456, 372);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lb_GioiTinh);
            groupBox5.Controls.Add(LblSex);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(3, 143);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(440, 64);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Giới tính";
            // 
            // lb_GioiTinh
            // 
            lb_GioiTinh.AutoSize = true;
            lb_GioiTinh.Location = new Point(19, 30);
            lb_GioiTinh.Name = "lb_GioiTinh";
            lb_GioiTinh.Size = new Size(27, 28);
            lb_GioiTinh.TabIndex = 1;
            lb_GioiTinh.Text = "...";
            // 
            // LblSex
            // 
            LblSex.AutoSize = true;
            LblSex.Dock = DockStyle.Left;
            LblSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblSex.Location = new Point(3, 30);
            LblSex.Name = "LblSex";
            LblSex.Padding = new Padding(5);
            LblSex.Size = new Size(10, 38);
            LblSex.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 70);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(3);
            panel4.Size = new Size(446, 70);
            panel4.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lb_CV);
            groupBox4.Controls.Add(LblRole);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(440, 64);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức vụ";
            // 
            // lb_CV
            // 
            lb_CV.AutoSize = true;
            lb_CV.Location = new Point(19, 33);
            lb_CV.Name = "lb_CV";
            lb_CV.Size = new Size(27, 28);
            lb_CV.TabIndex = 1;
            lb_CV.Text = "...";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Dock = DockStyle.Left;
            LblRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblRole.Location = new Point(3, 30);
            LblRole.Name = "LblRole";
            LblRole.Padding = new Padding(5);
            LblRole.Size = new Size(10, 38);
            LblRole.TabIndex = 0;
            // 
            // s
            // 
            s.Controls.Add(lb_Email);
            s.Controls.Add(LblCCCD);
            s.Dock = DockStyle.Fill;
            s.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            s.Location = new Point(3, 304);
            s.Name = "s";
            s.Size = new Size(440, 57);
            s.TabIndex = 5;
            s.TabStop = false;
            s.Text = "Email";
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Location = new Point(19, 26);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(27, 28);
            lb_Email.TabIndex = 1;
            lb_Email.Text = "...";
            // 
            // LblCCCD
            // 
            LblCCCD.AutoSize = true;
            LblCCCD.Dock = DockStyle.Left;
            LblCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblCCCD.Location = new Point(3, 30);
            LblCCCD.Name = "LblCCCD";
            LblCCCD.Padding = new Padding(5);
            LblCCCD.Size = new Size(10, 38);
            LblCCCD.TabIndex = 0;
            // 
            // g1
            // 
            g1.Controls.Add(dateTimePicker1);
            g1.Controls.Add(LblDob);
            g1.Dock = DockStyle.Fill;
            g1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            g1.Location = new Point(3, 213);
            g1.Name = "g1";
            g1.Size = new Size(440, 85);
            g1.TabIndex = 7;
            g1.TabStop = false;
            g1.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(19, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 1;
            // 
            // LblDob
            // 
            LblDob.AutoSize = true;
            LblDob.Dock = DockStyle.Left;
            LblDob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblDob.Location = new Point(3, 30);
            LblDob.Name = "LblDob";
            LblDob.Padding = new Padding(5);
            LblDob.Size = new Size(10, 38);
            LblDob.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(3);
            panel3.Size = new Size(446, 70);
            panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lb_HoTen);
            groupBox2.Controls.Add(LblName);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 64);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Họ và tên";
           
            // 
            // lb_HoTen
            // 
            lb_HoTen.AutoSize = true;
            lb_HoTen.Location = new Point(19, 30);
            lb_HoTen.Name = "lb_HoTen";
            lb_HoTen.Size = new Size(27, 28);
            lb_HoTen.TabIndex = 1;
            lb_HoTen.Text = "...";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Dock = DockStyle.Left;
            LblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblName.Location = new Point(3, 30);
            LblName.Name = "LblName";
            LblName.Padding = new Padding(5);
            LblName.Size = new Size(10, 38);
            LblName.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tb_Ten, 0, 1);
            tableLayoutPanel4.Controls.Add(tb_MaNV, 0, 0);
            tableLayoutPanel4.Location = new Point(459, 46);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel4.Size = new Size(388, 127);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // tb_Ten
            // 
            tb_Ten.AutoSize = true;
            tb_Ten.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Ten.ForeColor = Color.FromArgb(87, 96, 106);
            tb_Ten.Location = new Point(3, 63);
            tb_Ten.Name = "tb_Ten";
            tb_Ten.Size = new Size(122, 41);
            tb_Ten.TabIndex = 1;
            tb_Ten.Text = "Chunglv";
            // 
            // tb_MaNV
            // 
            tb_MaNV.AutoSize = true;
            tb_MaNV.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tb_MaNV.Location = new Point(3, 0);
            tb_MaNV.Name = "tb_MaNV";
            tb_MaNV.Size = new Size(100, 54);
            tb_MaNV.TabIndex = 0;
            tb_MaNV.Text = "NV1";
            // 
            // ptb_Avt
            // 
            ptb_Avt.BackColor = Color.WhiteSmoke;
            ptb_Avt.Location = new Point(171, 12);
            ptb_Avt.Name = "ptb_Avt";
            ptb_Avt.Size = new Size(223, 178);
            ptb_Avt.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Avt.TabIndex = 0;
            ptb_Avt.TabStop = false;
            // 
            // FrmThongTin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(865, 745);
            Controls.Add(panelFill);
            Name = "FrmThongTin";
            Text = "FrmThongTin";
            panelFill.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            s.ResumeLayout(false);
            s.PerformLayout();
            g1.ResumeLayout(false);
            g1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Avt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private TableLayoutPanel tableLayoutPanel4;
        private Label tb_Ten;
        private Label tb_MaNV;
        private PictureBox ptb_Avt;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox g1;
        private Label LblDob;
        private GroupBox groupBox5;
        private Label LblSex;
        private Panel panel4;
        private GroupBox groupBox4;
        private Label LblRole;
        private Panel panel3;
        private GroupBox groupBox2;
        private Label LblName;
        private GroupBox s;
        private Label LblCCCD;
        private Label lb_CV;
        private Label lb_HoTen;
        private Label lb_GioiTinh;
        private Label lb_Email;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}