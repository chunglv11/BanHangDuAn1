namespace _3.PL.Views
{
    partial class FrmAddCart
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
            lb_Tensp = new Label();
            label2 = new Label();
            tb_SoLuong = new TextBox();
            btn_Them = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm:";
            // 
            // lb_Tensp
            // 
            lb_Tensp.AutoSize = true;
            lb_Tensp.Location = new Point(142, 40);
            lb_Tensp.Name = "lb_Tensp";
            lb_Tensp.Size = new Size(18, 20);
            lb_Tensp.TabIndex = 1;
            lb_Tensp.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 84);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Số lượng";
            // 
            // tb_SoLuong
            // 
            tb_SoLuong.Location = new Point(142, 81);
            tb_SoLuong.Name = "tb_SoLuong";
            tb_SoLuong.Size = new Size(233, 27);
            tb_SoLuong.TabIndex = 3;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(176, 141);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(113, 40);
            btn_Them.TabIndex = 4;
            btn_Them.Text = "Thêm vào giỏ";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // FrmAddCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(452, 227);
            Controls.Add(btn_Them);
            Controls.Add(tb_SoLuong);
            Controls.Add(label2);
            Controls.Add(lb_Tensp);
            Controls.Add(label1);
            Name = "FrmAddCart";
            Text = "FrmAddCart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_Tensp;
        private Label label2;
        private TextBox tb_SoLuong;
        private Button btn_Them;
    }
}