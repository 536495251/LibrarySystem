using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemVersion2
{
    public partial class UserLinkAdmin : Form
    {
        User user=null;
        int id;
        public UserLinkAdmin(User user)
        {
            InitializeComponent();
            id = DButil.FinduserID(user.UserAccount,user.UserPassword);
        }

        private void UserLinkAdmin_Load(object sender, EventArgs e)
        {

        }

        private void ClearAll_Click(object sender, MouseEventArgs e)
        {
            UserToAdminThink.Text= string.Empty;
        }

        //发送消息给数据库 MessageTable
        private void BtnSent_Click(object sender, EventArgs e)
        {
            //防止重复点击
            BtnSent.Enabled = false;
            DateTime date= DateTime.Now;
            Message message = new Message(UserToAdminThink.Text,id,date);
            DButil.UserSentMessage(message);
            MessageBox.Show("发送成功!", "消息");

            Thread.Sleep(5000);
            Application.DoEvents();
            BtnSent.Enabled = true;
        }
    }
}
