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
            vbButton1 = new CustomButton.VBButton();
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
            vbButton1.Location = new Point(70, 661);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(188, 50);
            vbButton1.TabIndex = 0;
            vbButton1.Text = "vbButton1";
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // FrmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1363, 969);
            Controls.Add(vbButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBanHang";
            Text = "FrmBanHang";
            ResumeLayout(false);
        }

        #endregion

        private CustomButton.VBButton vbButton1;
    }
}