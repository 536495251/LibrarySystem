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
    public partial class AdminBook : Form
    {
        public AdminBook()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.AdminBookPanel.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminBookAdd adminBookAdd = new AdminBookAdd();

            adminBookAdd.TopLevel = false;
            adminBookAdd.Parent = AdminBookPanel;

            AdminBookPanel.Controls.Add(adminBookAdd);

            adminBookAdd.Show();
        }

        private void AdminBookPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.AdminBookPanel.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminBookDelete adminBookDelete = new AdminBookDelete();

            adminBookDelete.TopLevel = false;
            adminBookDelete.Parent = AdminBookPanel;

            AdminBookPanel.Controls.Add(adminBookDelete);

            adminBookDelete.Show();
        }

        private void ButtonAlter_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.AdminBookPanel.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminBookModify adminBookModify = new AdminBookModify();

            adminBookModify.TopLevel = false;
            adminBookModify.Parent = AdminBookPanel;

            AdminBookPanel.Controls.Add(adminBookModify);

            adminBookModify.Show();
        }

        private void ButtonQuery_Click_1(object sender, EventArgs e)
        {
            foreach (Control f in this.AdminBookPanel.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            AdminBookQuery adminBookQuery = new AdminBookQuery();

            adminBookQuery.TopLevel = false;
            adminBookQuery.Parent = AdminBookPanel;

            AdminBookPanel.Controls.Add(adminBookQuery);

            adminBookQuery.Show();
        }
    }
}
