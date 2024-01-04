using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemVersion2
{
    public partial class UserHomeFindBook : Form
    {
        string findbooktext;
        bool findbookbyname;
        User user;
        int id;
        bool isBorrow=false;
        public UserHomeFindBook()
        {
            InitializeComponent();
        }
        public UserHomeFindBook(User user, string findbooktext, bool findbookbyname)
        {
            InitializeComponent();
            this.user = user;
            this.findbooktext = findbooktext;
            this.findbookbyname = findbookbyname;
        }

        private void UserHomeFindBook_Load(object sender, EventArgs e)
        {
            if (findbookbyname)
            {
                DButil.BookQuery(dataGridView, findbooktext, null);
            }
            else
            {
                DButil.BookQuery(dataGridView, null, findbooktext);
            }
            id=DButil.FinduserID(user.UserAccount, user.UserPassword);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {   
                isBorrow = true;
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                string BookRemake = selectedRow.Cells[6].Value.ToString();
                MessageBox.Show(BookRemake, "图书介绍");
                LabelBookID.Text= selectedRow.Cells[0].Value.ToString();
                LabelBookName.Text = selectedRow.Cells[1].Value.ToString();
                LabelBookPress.Text = selectedRow.Cells[2].Value.ToString();
                LabelBookCount.Text = selectedRow.Cells[3].Value.ToString();
                LabelISBN.Text = selectedRow.Cells[4].Value.ToString();
                LabelBookCategory.Text = selectedRow.Cells[5].Value.ToString();
                LabelBorrowCount.Text = selectedRow.Cells[7].Value.ToString();
                byte[] imageDataBytes = (byte[])selectedRow.Cells["BookImage"].Value;

                using (MemoryStream ms = new MemoryStream(imageDataBytes))
                {
                    Image imageData = Image.FromStream(ms);
                    PictureBoxBookImage.Image = imageData;
                }
              
            }
        }

        private void ButtonBorrowBook_Click(object sender, EventArgs e)
        {
            if(!isBorrow)
            {
                MessageBox.Show("请选择要借阅的图书！");
                return;
            }
            user = DButil.Finduser(user.UserAccount, user.UserPassword);
            if(numericUpDownBorrowCount.Value==0)
            {
                MessageBox.Show("该书籍不能能被借阅" + numericUpDownBorrowCount.Value+"本");
                return;
            }
            if (Convert.ToInt32( numericUpDownBorrowCount.Value)>Convert.ToInt32(LabelBookCount.Text))
            {
                MessageBox.Show("该书籍能被借阅的数量小于" + numericUpDownBorrowCount.Value);
                return;
            }
            if (Convert.ToInt32(numericUpDownBorrowCount.Value) > user.UserBorrowCount)
            {
                MessageBox.Show("用户借阅量不够，请联系管理员！");
                return;
            }
            if (user.UserIsFrozen)
            {
                MessageBox.Show("你已经被冻结了，请抓紧时间联系管理员！");
                return;
            }
            if (DButil.BookBorrow(Convert.ToInt32(LabelBookID.Text), id, DateTime.Now, DateTimePickerReturnBookDate.Value, Convert.ToInt32(numericUpDownBorrowCount.Value)))
            {
                if (findbookbyname)
                {
                    DButil.BookQuery(dataGridView, findbooktext, null);
                }
                else
                {
                    DButil.BookQuery(dataGridView, null, findbooktext);
                }
                MessageBox.Show("借阅成功！\n祝您阅读愉快！");
                isBorrow = false;
            }
            else
            {
                MessageBox.Show("借阅失败！");
            }
        }

        private void PictureBoxBookImage_Click(object sender, EventArgs e)
        {

        }

        private void PanelBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LabelBookCount_Click(object sender, EventArgs e)
        {

        }

        private void LabelBorrowCount_Click(object sender, EventArgs e)
        {

        }

        private void LabelBookCategory_Click(object sender, EventArgs e)
        {

        }

        private void LabelISBN_Click(object sender, EventArgs e)
        {

        }

        private void LabelBookPress_Click(object sender, EventArgs e)
        {

        }

        private void LabelBookID_Click(object sender, EventArgs e)
        {

        }

        private void LabelBookName_Click(object sender, EventArgs e)
        {

        }

        private void PanelImage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DateTimePickerReturnBookDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownBorrowCount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
