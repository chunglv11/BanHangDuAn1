namespace _3.PL.Views
{
    partial class FrmLayLaiMK
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
            label1 = new Label();
            label2 = new Label();
            tb_pass = new TextBox();
            tb_nhaplai = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập lại mật khẩu";
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(186, 56);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(282, 27);
            tb_pass.TabIndex = 4;
            // 
            // tb_nhaplai
            // 
            tb_nhaplai.Location = new Point(186, 132);
            tb_nhaplai.Name = "tb_nhaplai";
            tb_nhaplai.Size = new Size(282, 27);
            tb_nhaplai.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(18, 221);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(374, 221);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Quay lại";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmLayLaiMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 315);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tb_nhaplai);
            Controls.Add(tb_pass);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLayLaiMK";
            Text = "FrmLayLaiMK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_pass;
        private TextBox tb_nhaplai;
        private Button button1;
        private Button button2;
    }
}