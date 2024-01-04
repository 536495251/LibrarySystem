using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemVersion2
{
    public partial class ModifyInfo : Form
    {
        User user= null;
        public ModifyInfo()
        {
            InitializeComponent();
        }
        public ModifyInfo(User user)
        {
            InitializeComponent();
            this.user= user;
        }

        private void ModifyInfo_Load(object sender, EventArgs e)
        {
            ModifyUserName.Text = user.UserName;
            ModifyUserSex.Text = user.UserSex;
            ModifyUserAge.Text = user.UserAge.ToString();
            ModifyUserAddress.Text = user.UserAddress;
            ModifyUserTel.Text = user.UserTelephone;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool k=true;
            if (ModifyUserName.Text == string.Empty || ModifyUserSex.Text == string.Empty || ModifyUserAge.Text == string.Empty || ModifyUserAddress.Text == string.Empty || ModifyUserTel.Text == string.Empty)
            {
                k = false;
                MessageBox.Show("不能为空", "消息");
            }

            if (ModifyUserSex.Text.Trim().Equals("男")  || ModifyUserSex.Text.Trim().Equals("女"))
            {
            }
            else
            {
                k = false;
                MessageBox.Show("请输入男或女","消息");
            }

            int age = 0;
            try
            {
                age = int.Parse(ModifyUserAge.Text);
                if (age < 0 || age >= 100)
                {
                    k = false;
                    ModifyUserAge.Text = string.Empty;
                    MessageBox.Show("请输入正确的年龄！");
                }
            }
            catch (FormatException)
            {
                k = false;
                ModifyUserAge.Text = string.Empty;
                MessageBox.Show("请输入正确的年龄！");
            }
            if (ModifyUserTel.Text.Length != 11)
            {
                k = false;
                MessageBox.Show("电话号码输入有误！");
            }
            if (k == true)
            {
                user.UserName = ModifyUserName.Text;
                user.UserSex = ModifyUserSex.Text;
                user.UserAge = Convert.ToInt32(ModifyUserAge.Text);
                user.UserAddress = ModifyUserAddress.Text;
                user.UserTelephone = ModifyUserTel.Text;
                if (DButil.UserAlter(user))
                {
                    user=DButil.Finduser(user.UserAccount,user.UserPassword);
                    
                    ModifyUserName.Text = user.UserName;
                    ModifyUserSex.Text = user.UserSex;
                    ModifyUserAge.Text = user.UserAge.ToString();
                    ModifyUserAddress.Text = user.UserAddress;
                    ModifyUserTel.Text = user.UserTelephone;

                    MessageBox.Show("信息更改成功", "消息");
                    //this.Close();
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
