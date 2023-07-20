using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmQuanLyNhanVien : Form
    {
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        private Form activeForm;
        private void ChangeForm(Form childForm)
        {
            if (activeForm != null)
            {

                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelFill.Controls.Add(childForm);

            childForm.Show();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmNhanVien());
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmChucVu());
        }

        private void phươngThứcThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmPhuongThucTT());
        }
    }
}
