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
    public partial class AdminUserModify : Form
    {
        public AdminUserModify()
        {
            InitializeComponent();
        }

        private void AdminUserModify_Load(object sender, EventArgs e)
        {
            DButil.UserQueryAllSimple(dataGridView);
        }

        private void TextBoxModifyAccount_MouseLeaveClick(object sender, EventArgs e)
        {
            User user = null;
            try
            {   
                int id = Convert.ToInt32(TextBoxUserModifyAccount.Text);
        
                if (!DButil.UserExistsByID(id))
                {

                    return;
                }
                user = DButil.UserQueryByID(id);
                LabelModifyName.Text = "姓名:" + user.UserName;
                LabelModifyUserBorrowCount.Text = "借阅量:" + user.UserBorrowCount.ToString();
                LabelIsFrozen.Text = "是否冻结:" + user.UserIsFrozen.ToString();
                TextBoxUserBorrowAccount.Text = user.UserBorrowCount.ToString();
                if (user.UserIsFrozen)
                {
                    RadioButtonAlterFrozen.Text = "解冻";
                }
                else
                {
                    RadioButtonAlterFrozen.Text = "冻结";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的ID");
                TextBoxUserModifyAccount.Text = string.Empty;
            }
           

        }

        private void ButtonUserModify_Click(object sender, EventArgs e)
        {   
            User user=null;
            int id = Convert.ToInt32(TextBoxUserModifyAccount.Text);
            int borrowcount = Convert.ToInt32(TextBoxUserBorrowAccount.Text);
            bool isfrozen=false; 
            if(RadioButtonAlterFrozen.Text.Equals("解冻"))
            {
                if(RadioButtonAlterFrozen.Checked)
                {
                    isfrozen = false;
                }
            }
            if (RadioButtonAlterFrozen.Text.Equals("冻结"))
            {
                if (RadioButtonAlterFrozen.Checked)
                {
                    isfrozen = true;
                }
            }

            if(DButil.UserAlterByID(id, borrowcount, isfrozen))
            {
                MessageBox.Show("修改权限成功！");
                DButil.UserQueryAllSimple(dataGridView);
                user = DButil.UserQueryByID(id);
                if(!user.UserIsFrozen)               
                    RadioButtonAlterFrozen.Text = "冻结";               
                else               
                   RadioButtonAlterFrozen.Text = "解冻";
                
                LabelModifyName.Text = "姓名:" + user.UserName;
                LabelModifyUserBorrowCount.Text = "借阅量:" + user.UserBorrowCount.ToString();
                LabelIsFrozen.Text = "是否冻结:" + user.UserIsFrozen.ToString();
                TextBoxUserBorrowAccount.Text = user.UserBorrowCount.ToString();
                RadioButtonAlterFrozen.Checked = false;
            }


        }

        private void TextBoxUserModifyAccount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
