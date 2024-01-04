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
    public partial class AdminUserDelete : Form
    {
        public AdminUserDelete()
        {
            InitializeComponent();
        }

        private void AdminUserDelete_Load(object sender, EventArgs e)
        {
            DButil.UserQueryAll(dataGridView);
        }

        private void TextBoxDeleteUserAccount_MouseLeaveClick(object sender, EventArgs e)
        {
            User user = null;
            try
            { 
                int id = Convert.ToInt32(TextBoxUserDeleteAccount.Text);
                if (!DButil.UserExistsByID(id))
                {
                    MessageBox.Show("id不存在");
                    TextBoxUserDeleteAccount.Text = string.Empty;
                    LabelUserAccount.Text = string.Empty;
                    LabelUserAddress.Text = string.Empty;
                    LabelUserAge.Text = string.Empty;
                    LabelUserName.Text = string.Empty;
                    LabelUserSex.Text = string.Empty;
                    LabelUserTel.Text = string.Empty;
                    return;
                }
                user = DButil.UserQueryByID(id);
                LabelUserAccount.Text = "账号:" + user.UserAccount;
                LabelUserAddress.Text = "地址:" + user.UserAddress;
                LabelUserAge.Text = "年龄:" + user.UserAge.ToString();
                LabelUserName.Text = "姓名：:" + user.UserName;
                LabelUserSex.Text = "性别:" + user.UserSex;
                LabelUserTel.Text = "电话:" + user.UserTelephone;
            }
            catch(FormatException) 
            {
                MessageBox.Show("请输入正确的ID");
                TextBoxUserDeleteAccount.Text = string.Empty;
            }
            
        }

        private void ButtonUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TextBoxUserDeleteAccount.Text);
                
                if (!DButil.UserExistsByID(id))
                {
                    MessageBox.Show("id不存在");
                    return;
                }
               if(DButil.UserDeleteByID(id))
                {
                    DButil.UserQueryAll(dataGridView);
                    MessageBox.Show("删除成功！");
                    TextBoxUserDeleteAccount.Text= string.Empty;
                    LabelUserAccount.Text = string.Empty;
                    LabelUserAddress.Text = string.Empty;
                    LabelUserAge.Text = string.Empty;
                    LabelUserName.Text = string.Empty;
                    LabelUserSex.Text = string.Empty;
                    LabelUserTel.Text = string.Empty;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的ID");
                TextBoxUserDeleteAccount.Text = string.Empty;
            }
        }
    }
}
