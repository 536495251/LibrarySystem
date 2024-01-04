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
    public partial class AdminForm : Form
    {   
        int count = 0;
        Admin Admin;
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.Admin = admin;
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMyBooks_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelForm.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminBook adminbook = new AdminBook();
         
            adminbook.TopLevel = false;
         
            adminbook.Parent = PanelForm;
            
            PanelForm.Controls.Add(adminbook);
                                  
            adminbook.Show();
            
           

        }

        private void ButtonUserIfo_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelForm.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminUser adminuser = new AdminUser();

            adminuser.TopLevel = false;

            adminuser.Parent = PanelForm;

            PanelForm.Controls.Add(adminuser);

            adminuser.Show();
        }

        private void ButtonContact_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelForm.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminContact admincontact = new AdminContact();

            admincontact.TopLevel = false;

            admincontact.Parent = PanelForm;

            PanelForm.Controls.Add(admincontact);

            admincontact.Show();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelForm.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminHome adminHome = new AdminHome();

            adminHome.TopLevel = false;
            adminHome.Parent = PanelForm;

            PanelForm.Controls.Add(adminHome);

            adminHome.Show();



            
        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ButtonHome_Click(sender, e);
        }
    }
}
