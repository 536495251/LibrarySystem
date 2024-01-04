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
    public partial class MyBook : Form
    {
        bool isReturn = false;
        User user = null;
        int userid;
        public MyBook()
        {
            InitializeComponent();
        }
        public MyBook(User user)
        {
            InitializeComponent();
            this.user = DButil.Finduser(user.UserAccount,user.UserPassword);
            this.userid=DButil.FinduserID(user.UserAccount, user.UserPassword);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (e.RowIndex >= 0)
            {
                isReturn = true;
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                LabelBorrowID.Text = selectedRow.Cells[0].Value.ToString();
                LabelBookID.Text = selectedRow.Cells[1].Value.ToString();
                Book book = DButil.BookQueryByID(Convert.ToInt32(LabelBookID.Text));
                LabelBookName.Text = book.Name;
                LabelBookPress.Text = book.Press;
                LabelBookCount.Text = book.Count.ToString();
                LabelISBN.Text = book.ISBN.ToString();
                LabelBookCategory.Text = book.Remake;
                // 我的借书量
                LabelBookBorrowCount.Text= selectedRow.Cells[4].Value.ToString();
                LabelBorrowCount.Text = book.BorrowCount.ToString();
                PictureBoxBookImage.Image = book.Image;
                numericUpDownReturnBookCount.Maximum= Convert.ToDecimal(LabelBookBorrowCount.Text);
            }
        }

        private void MyBook_Load(object sender, EventArgs e)
        {
            DButil.BookBorrowQuery(userid, dataGridView);
        }

        private void ButtonReturnBook_Click(object sender, EventArgs e)
        {   
            if(!isReturn)
            {
                MessageBox.Show("请选择要归还的图书！");
                return;
            }
            if (DButil.ReturnBook(Convert.ToInt32(LabelBorrowID.Text), userid, Convert.ToInt32(LabelBookID.Text), Convert.ToInt32(numericUpDownReturnBookCount.Value), Convert.ToInt32(numericUpDownReturnBookScore.Value), DateTime.Now)) ;
            { 
                DButil.BookBorrowQuery(userid, dataGridView);
                isReturn = false;
                MessageBox.Show("还书成功！");
            }
        }
    }
}
