namespace _3.PL.Views
{
    partial class FrmDangNhap
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
            vbButton1 = new CustomButton.VBButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // vbButton1
            // 
            vbButton1.BackColor = Color.MediumSlateBlue;
            vbButton1.BackgroundColor = Color.MediumSlateBlue;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 20;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.ForeColor = Color.White;
            vbButton1.Location = new Point(144, 356);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(188, 50);
            vbButton1.TabIndex = 0;
            vbButton1.Text = "Đăng nhập";
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 426);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(vbButton1);
            panel2.Location = new Point(300, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 426);
            panel2.TabIndex = 2;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmDangNhap";
            Text = "FrmDangNhap";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomButton.VBButton vbButton1;
        private Panel panel1;
        private Panel panel2;
    }
}