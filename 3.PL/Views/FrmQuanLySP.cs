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
    public partial class FrmQuanLySP : Form
    {
        public FrmQuanLySP()
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
        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmSanPhamCT());
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmSanPham());
        }

        private void kíchCỡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmKichCo());
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmMauSac());
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmNxs());
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmLoaiSP());
        }
    }
}
