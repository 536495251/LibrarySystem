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
    public partial class UserInfo : Form
    {
        User user=null;
        public UserInfo()
        {
            InitializeComponent();
        }
        public UserInfo(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            UserName.Text = user.UserName;
            Sex.Text = user.UserSex;
            Age.Text = user.UserAge.ToString();
            UserAddress.Text = user.UserAddress;
            UserTel.Text=user.UserTelephone;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ModifyInfoBtn_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.ModifyPanel.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            //子窗体对象
            ModifyInfo modifyInfo= new ModifyInfo(user);
            modifyInfo.TopLevel = false;
            modifyInfo.Parent = ModifyPanel;
            ModifyPanel.Controls.Add(modifyInfo);
            modifyInfo.Show();
        }

        private void Age_Click(object sender, EventArgs e)
        {

        }

        private void Sex_Click(object sender, EventArgs e)
        {

        }

        private void UserAddress_Click(object sender, EventArgs e)
        {

        }

        private void UserTel_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FlushUserInfo_Click(object sender, EventArgs e)
        {
            bool k = true;
            if (user.UserName == string.Empty || user.UserName == string.Empty || user.UserAge.ToString() == string.Empty || user.UserAddress == string.Empty || user.UserTelephone == string.Empty)
            {
                k = false;
                MessageBox.Show("不能为空", "消息");
            }

            if (user.UserSex.Trim().Equals("男") || user.UserSex.Trim().Equals("女"))
            {
            }
            else
            {
                k = false;
                MessageBox.Show("请输入男或女", "消息");
            }

            int age = 0;
            try
            {
                age = int.Parse(user.UserAge.ToString());
                if (age < 0 || age >= 100)
                {
                    k = false;
                    MessageBox.Show("请输入正确的年龄！");
                }
            }
            catch (FormatException)
            {
                k = false;
                MessageBox.Show("请输入正确的年龄！");
            }
            if (user.UserTelephone.Length != 11)
            {
                k = false;
                MessageBox.Show("电话号码输入有误！");
            }
            if (k == true)
            {
                user = DButil.Finduser(user.UserAccount, user.UserPassword);
                UserName.Text= user.UserName;
                Sex.Text = user.UserSex;
                Age.Text = user.UserAge.ToString();
                UserAddress.Text = user.UserAddress;
                UserTel.Text = user.UserTelephone;
            }
        }
    }
}
