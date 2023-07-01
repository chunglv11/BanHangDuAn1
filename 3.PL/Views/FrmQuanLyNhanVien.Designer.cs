namespace _3.PL.Views
{
    partial class FrmQuanLyNhanVien
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
            menuStrip1 = new MenuStrip();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            chứcVụToolStripMenuItem = new ToolStripMenuItem();
            panelFill = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SeaShell;
            menuStrip1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem, chứcVụToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1345, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(110, 29);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // chứcVụToolStripMenuItem
            // 
            chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            chứcVụToolStripMenuItem.Size = new Size(91, 29);
            chứcVụToolStripMenuItem.Text = "Chức vụ";
            chứcVụToolStripMenuItem.Click += chứcVụToolStripMenuItem_Click;
            // 
            // panelFill
            // 
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 33);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(1345, 889);
            panelFill.TabIndex = 1;
            // 
            // FrmQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1345, 922);
            Controls.Add(panelFill);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmQuanLyNhanVien";
            Text = "FrmQuanLyNhanVien";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem chứcVụToolStripMenuItem;
        private Panel panelFill;
    }
}