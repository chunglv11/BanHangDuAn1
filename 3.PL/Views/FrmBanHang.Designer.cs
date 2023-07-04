namespace _3.PL.Views
{
    partial class FrmBanHang
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
            components = new System.ComponentModel.Container();
            panelFil = new Panel();
            panelTrai = new Panel();
            groupBox3 = new GroupBox();
            flowPanelSp = new FlowLayoutPanel();
            groupBox4 = new GroupBox();
            tb_TimKiem = new TextBox();
            cbb_LoaiSP = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtg_GioHang = new DataGridView();
            groupBox1 = new GroupBox();
            ptb_QR = new PictureBox();
            dtg_DonHang = new DataGridView();
            panelPhai = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            timer1 = new System.Windows.Forms.Timer(components);
            panelFil.SuspendLayout();
            panelTrai.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_QR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_DonHang).BeginInit();
            panelPhai.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panelFil
            // 
            panelFil.Controls.Add(panelTrai);
            panelFil.Controls.Add(panelPhai);
            panelFil.Dock = DockStyle.Fill;
            panelFil.Location = new Point(0, 0);
            panelFil.Name = "panelFil";
            panelFil.Size = new Size(1345, 922);
            panelFil.TabIndex = 0;
            // 
            // panelTrai
            // 
            panelTrai.Controls.Add(groupBox3);
            panelTrai.Controls.Add(groupBox4);
            panelTrai.Controls.Add(groupBox2);
            panelTrai.Controls.Add(groupBox1);
            panelTrai.Dock = DockStyle.Fill;
            panelTrai.Location = new Point(0, 0);
            panelTrai.Name = "panelTrai";
            panelTrai.Size = new Size(1043, 922);
            panelTrai.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowPanelSp);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 613);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1043, 309);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // flowPanelSp
            // 
            flowPanelSp.Dock = DockStyle.Fill;
            flowPanelSp.Location = new Point(3, 23);
            flowPanelSp.Name = "flowPanelSp";
            flowPanelSp.Size = new Size(1037, 283);
            flowPanelSp.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tb_TimKiem);
            groupBox4.Controls.Add(cbb_LoaiSP);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 538);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1043, 75);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // tb_TimKiem
            // 
            tb_TimKiem.Location = new Point(641, 30);
            tb_TimKiem.Name = "tb_TimKiem";
            tb_TimKiem.Size = new Size(313, 27);
            tb_TimKiem.TabIndex = 3;
            // 
            // cbb_LoaiSP
            // 
            cbb_LoaiSP.FormattingEnabled = true;
            cbb_LoaiSP.Location = new Point(161, 32);
            cbb_LoaiSP.Name = "cbb_LoaiSP";
            cbb_LoaiSP.Size = new Size(293, 28);
            cbb_LoaiSP.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 35);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh mục sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_GioHang);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 269);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1043, 269);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // dtg_GioHang
            // 
            dtg_GioHang.BackgroundColor = SystemColors.ControlLight;
            dtg_GioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_GioHang.Dock = DockStyle.Left;
            dtg_GioHang.Location = new Point(3, 23);
            dtg_GioHang.Name = "dtg_GioHang";
            dtg_GioHang.RowHeadersWidth = 51;
            dtg_GioHang.RowTemplate.Height = 29;
            dtg_GioHang.Size = new Size(754, 243);
            dtg_GioHang.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ptb_QR);
            groupBox1.Controls.Add(dtg_DonHang);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1043, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách đơn hàng";
            // 
            // ptb_QR
            // 
            ptb_QR.BackColor = Color.MistyRose;
            ptb_QR.Location = new Point(756, 26);
            ptb_QR.Name = "ptb_QR";
            ptb_QR.Size = new Size(198, 179);
            ptb_QR.TabIndex = 1;
            ptb_QR.TabStop = false;
            // 
            // dtg_DonHang
            // 
            dtg_DonHang.BackgroundColor = SystemColors.ControlLight;
            dtg_DonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DonHang.Dock = DockStyle.Left;
            dtg_DonHang.Location = new Point(3, 23);
            dtg_DonHang.Name = "dtg_DonHang";
            dtg_DonHang.RowHeadersWidth = 51;
            dtg_DonHang.RowTemplate.Height = 29;
            dtg_DonHang.Size = new Size(670, 243);
            dtg_DonHang.TabIndex = 0;
            // 
            // panelPhai
            // 
            panelPhai.Controls.Add(tabControl1);
            panelPhai.Dock = DockStyle.Right;
            panelPhai.Location = new Point(1043, 0);
            panelPhai.Name = "panelPhai";
            panelPhai.Size = new Size(302, 922);
            panelPhai.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(250, 125);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(242, 92);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 92);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1345, 922);
            Controls.Add(panelFil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmBanHang";
            Text = "FrmBanHang";
            panelFil.ResumeLayout(false);
            panelTrai.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_QR).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_DonHang).EndInit();
            panelPhai.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.CodeDom.CodeTypeReference guna2AnimateWindow1;
        private Panel panelFil;
        private Panel panelPhai;
        private Panel panelTrai;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dtg_DonHang;
        private DataGridView dtg_GioHang;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox4;
        private ComboBox cbb_LoaiSP;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox tb_TimKiem;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowPanelSp;
        private PictureBox ptb_QR;
    }
}