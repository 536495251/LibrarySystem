using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemVersion2
{
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
        }

        private void ButtonModifyUser_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelForm.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminUserModify adminmodify = new AdminUserModify();

            adminmodify.TopLevel = false;

            adminmodify.Parent = PanelForm;

            PanelForm.Controls.Add(adminmodify);

            adminmodify.Show();
        }

        private void ButtonQuery_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelForm.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminUserQuery adminquery = new AdminUserQuery();

            adminquery.TopLevel = false;

            adminquery.Parent = PanelForm;

            PanelForm.Controls.Add(adminquery);

            adminquery.Show();
        }

        private void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelForm.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminUserDelete admindelete = new AdminUserDelete();

            admindelete.TopLevel = false;

            admindelete.Parent = PanelForm;

            PanelForm.Controls.Add(admindelete);

            admindelete.Show();
        }
    }
}
