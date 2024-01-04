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
    public partial class LoginForm : Form
    {
        public  User LoginUser;
        public Admin LoginAdmin;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(User user)
        {   
            this.LoginUser = user;
            InitializeComponent();
            TextBoxUserAccount.Text = user.UserAccount;
            TextBoxUserPassword.Text = user.UserPassword;
            RadioButtonUser.Checked = true;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string account =TextBoxUserAccount.Text;
            string password = TextBoxUserPassword.Text;
           
            if(RadioButtonAdmin.Checked)
            {
               if(DButil.LoginAdmin(account,password))
                {
                    // 进入管理员界面
                    LoginAdmin=new Admin(account,password);
                    AdminForm adminform = new AdminForm(LoginAdmin);
                    this.Hide();
                    adminform.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("账号或密码错误！");
                }

            }
            else if(RadioButtonUser.Checked)
            {
                if (DButil.LoginUser(account, password))
                {
                     // 进入用户界面
                    LoginUser = DButil.Finduser(account, password);
                    Form1 form1 = new Form1(LoginUser);                  
                    this.Hide();
                    form1.ShowDialog();
                    this.Dispose(); 

                    
                }
                else
                {
                    MessageBox.Show("账号或密码错误！");
                }
            }
            else
            {
                if(account.Trim() == ""|| password == "")
                {
                    MessageBox.Show("请输入账号和密码");
                }
                if(RadioButtonUser.Checked==false && RadioButtonAdmin.Checked==false)
                {
                    MessageBox.Show("请选择登录方式！");
                }
               

            }
        }

        private void ButtonSignin_Click(object sender, EventArgs e)
        {
            
            SigninForm signinForm = new SigninForm();
            this.Hide();
            signinForm.ShowDialog();
            this.Dispose();
          
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
