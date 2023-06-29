namespace _3.PL.Views
{
    partial class FrmQuanLySP
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
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            kíchCỡToolStripMenuItem = new ToolStripMenuItem();
            màuSắcToolStripMenuItem = new ToolStripMenuItem();
            nhàSảnXuấtToolStripMenuItem = new ToolStripMenuItem();
            loạiSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            panelFill = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SeaShell;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýSảnPhẩmToolStripMenuItem, sảnPhẩmToolStripMenuItem, kíchCỡToolStripMenuItem, màuSắcToolStripMenuItem, nhàSảnXuấtToolStripMenuItem, loạiSảnPhẩmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1345, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(141, 24);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(89, 24);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // kíchCỡToolStripMenuItem
            // 
            kíchCỡToolStripMenuItem.Name = "kíchCỡToolStripMenuItem";
            kíchCỡToolStripMenuItem.Size = new Size(71, 24);
            kíchCỡToolStripMenuItem.Text = "Kích cỡ";
            kíchCỡToolStripMenuItem.Click += kíchCỡToolStripMenuItem_Click;
            // 
            // màuSắcToolStripMenuItem
            // 
            màuSắcToolStripMenuItem.Name = "màuSắcToolStripMenuItem";
            màuSắcToolStripMenuItem.Size = new Size(77, 24);
            màuSắcToolStripMenuItem.Text = "Màu sắc";
            màuSắcToolStripMenuItem.Click += màuSắcToolStripMenuItem_Click;
            // 
            // nhàSảnXuấtToolStripMenuItem
            // 
            nhàSảnXuấtToolStripMenuItem.Name = "nhàSảnXuấtToolStripMenuItem";
            nhàSảnXuấtToolStripMenuItem.Size = new Size(108, 24);
            nhàSảnXuấtToolStripMenuItem.Text = "Nhà sản xuất";
            nhàSảnXuấtToolStripMenuItem.Click += nhàSảnXuấtToolStripMenuItem_Click;
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            loạiSảnPhẩmToolStripMenuItem.Size = new Size(119, 24);
            loạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm";
            loạiSảnPhẩmToolStripMenuItem.Click += loạiSảnPhẩmToolStripMenuItem_Click;
            // 
            // panelFill
            // 
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 28);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(1345, 894);
            panelFill.TabIndex = 1;
            // 
            // FrmQuanLySP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1345, 922);
            Controls.Add(panelFill);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmQuanLySP";
            Text = "FrmQuanLySP";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem kíchCỡToolStripMenuItem;
        private ToolStripMenuItem màuSắcToolStripMenuItem;
        private ToolStripMenuItem nhàSảnXuấtToolStripMenuItem;
        private ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private Panel panelFill;
    }
}