using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystemVersion2
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }

        private void ButtonUserSignin_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string account=TextBoxSetUserAccount.Text;
            string password= TextBoxSetUserPassword.Text;
            if (!TextBoxConfirmUserPassword.Text.Equals(password))
            {
                MessageBox.Show("两次输入的密码不一致！");
                ok = false; 
            }
            string name=TextBoxUserName.Text;
            string sex=null;
            
            if (RadioButtonMan.Checked)
            {
              sex = "男";
            }
            else if (RadioButtonWomen.Checked) 
            {
                sex = "女";
            }
            else
            {
                MessageBox.Show("选择性别！");
                ok = false;
            }
            int age = 0;
            try
            { 

                 age = int.Parse(TextBoxUserAge.Text);
                if (age < 0||age>=100) 
                {
                    MessageBox.Show("请输入正确的年龄！");
                    ok = false;
                }
            }
            catch(FormatException) {
                MessageBox.Show("请输入正确的年龄！");
                ok = false;
            }
            string address=TextBoxUserAdress.Text;
            string telephone=null;
            if (TextBoxUserTelephone.Text.Length!=11) 
            {
                MessageBox.Show("电话号码输入有误！");
                ok = false;
            }
            else
            {
                telephone = TextBoxUserTelephone.Text;
            }
            if (ok)
            {
                if (DButil.SigninUser(account, password, name, sex, age, address, telephone))
                {
                    int count = 10;
                    bool isfrozen = false;
                    User SigninUser=new User(account,password, name, sex, telephone,address,age, count,isfrozen);
                    LoginForm loginForm = new LoginForm(SigninUser);
                    this.Hide();
                    loginForm.ShowDialog();
                    this.Dispose();
                    
                }
            }
            else 
            {
                MessageBox.Show("注册失败！");
            }
        }

        private void TextBoxUserAdress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
