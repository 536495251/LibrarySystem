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
    public partial class Form1 : Form
    {
        public User user;
        public Form1(User user)
        {
            this.user = user;
            InitializeComponent();
            //LabelUserName.Text = this.user.UserName;
            UserNameLabel.Text = this.user.UserName;
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {

            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
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
            //子窗体对象
            UserHome userHome = new UserHome(user);
            userHome.TopLevel = false;
            userHome.Parent = PanelForm;
            PanelForm.Controls.Add(userHome);
            userHome.Show();
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
            //子窗体对象
            MyBook myBook = new MyBook(user);
            myBook.TopLevel = false;
            myBook.Parent = PanelForm;
            PanelForm.Controls.Add(myBook);
            myBook.Show();
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
            //子窗体对象
            UserInfo userInfo = new UserInfo(user);
            userInfo.TopLevel = false;
            userInfo.Parent = PanelForm;
            PanelForm.Controls.Add(userInfo);
            userInfo.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonHome_Click(sender, e);
        }

        private void ButtonContactAdmin_Click_1(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelForm.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            //子窗体对象
            UserLinkAdmin userLinkAdmin = new UserLinkAdmin(user);
            userLinkAdmin.TopLevel = false;
            userLinkAdmin.Parent = PanelForm;
            PanelForm.Controls.Add(userLinkAdmin);
            userLinkAdmin.Show();
        }
    }
}
