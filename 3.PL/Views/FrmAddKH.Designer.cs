namespace _3.PL.Views
{
    partial class FrmAddKH
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
            groupBox2 = new GroupBox();
            btn_Them = new Button();
            txb_sdt = new TextBox();
            label4 = new Label();
            rbtn_Quen = new RadioButton();
            rbtn_Vang = new RadioButton();
            txb_hoten = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txb_sdt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(rbtn_Quen);
            groupBox1.Controls.Add(rbtn_Vang);
            groupBox1.Controls.Add(txb_hoten);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(754, 219);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(462, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 98);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
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
            // txb_sdt
            // 
            txb_sdt.Location = new Point(134, 82);
            txb_sdt.Name = "txb_sdt";
            txb_sdt.Size = new Size(274, 30);
            txb_sdt.TabIndex = 10;
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
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 239);
            panel2.TabIndex = 20;
            // 
            // FrmAddKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(775, 239);
            Controls.Add(panel2);
            Name = "FrmAddKH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddKH";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txb_sdt;
        private Label label4;
        private RadioButton rbtn_Quen;
        private RadioButton rbtn_Vang;
        private TextBox txb_hoten;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_Them;
        private Panel panel2;
    }
}