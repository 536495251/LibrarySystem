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
    public partial class AdminUserQuery : Form
    {
        public AdminUserQuery()
        {
            InitializeComponent();
        }

        private void AdminUserQuery_Load(object sender, EventArgs e)
        {
            DButil.UserQueryAll(dataGridView);
        }

        private void ButtonUserQuery_Click(object sender, EventArgs e)
        {
            string account = TextBoxUserAccount.Text; 
            string name = TextBoxUserName.Text;
            string tel = TextBoxUserTel.Text;
            string address = TextBoxUserAddress.Text;

            DButil.UserQuery(dataGridView, account, name, tel, address);

        }

        private void ButtonClaer_Click(object sender, EventArgs e)
        {
            TextBoxUserAccount.Text = "";
            TextBoxUserName.Text = "";
            TextBoxUserTel.Text = "";
            TextBoxUserAddress.Text = "";
        }
    }
}
