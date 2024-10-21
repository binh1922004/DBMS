using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiem.Entity
{
    public partial class MenuBase : Form
    {
        public MenuBase()
        {
            InitializeComponent();
        }
        private Form activeForm;
        private void btn_1_Click(object sender, EventArgs e)
        {
            //thay Form = Form đang cần hiện lên.
            openChildForm(new Form());
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Form.Controls.Add(childForm);
            pnl_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
