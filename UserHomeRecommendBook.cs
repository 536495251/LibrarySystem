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
    public partial class UserHomeRecommendBook : Form
    {
        User user;
        int id;
        int[] recommendBook;
        int i;
        Book book;
        int length;
        int bookID;
        public UserHomeRecommendBook()
        {
            InitializeComponent();
        }
        public UserHomeRecommendBook(User user)
        {
            InitializeComponent();
            this.user = user;
            this.id = DButil.FinduserID(user.UserAccount, user.UserPassword);
            this.recommendBook = DButil.CollaborativeFilteringRecommendation(id);
            //this.recommendBook = DButil.CollaborativeFilteringRecommendation(id,0.5);
            this.i = 0;
            this.length = recommendBook.Length;
        }

        private void UserHomeRecommendBook_Load(object sender, EventArgs e)
        {
            if (recommendBook is null)
            {
                MessageBox.Show("null");
            }
            /*foreach(var i in recommendBook)
            {
                MessageBox.Show(i.ToString());
            }*/
            try
            {
                bookID = recommendBook[i];
                book = DButil.BookQueryByID(bookID);
                UpdateLabel(bookID, book);
            }catch(Exception ex)
            {
                DialogResult result = MessageBox.Show("暂时无书籍推荐，请去借阅归还书籍！", "提示", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                  
                   
                }
            }
           
        }
        private void UpdateLabel(int id, Book book)
        {
            richTextBoxBookRemark.Text= book.Remake;
            LabelBookID.Text = id.ToString();
            LabelBookName.Text = book.Name;
            LabelBookPress.Text = book.Press;
            LabelBookCount.Text = book.Count.ToString();
            LabelISBN.Text = book.ISBN.ToString();
            LabelBookCategory.Text = book.Category;
            LabelBorrowCount.Text = book.BorrowCount.ToString();
            pictureBox1.Image = book.Image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            bookID = recommendBook[i++ % length];
            book = DButil.BookQueryByID(bookID);
            UpdateLabel(bookID,book);
        }

        private void ButtonBorrowBook_Click(object sender, EventArgs e)
        {          
            user = DButil.Finduser(user.UserAccount, user.UserPassword);
            if (numericUpDownBorrowCount.Value == 0)
            {
                MessageBox.Show("该书籍不能能被借阅" + numericUpDownBorrowCount.Value + "本");
                return;
            }
            if (Convert.ToInt32(numericUpDownBorrowCount.Value) > Convert.ToInt32(LabelBookCount.Text))
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
                // 借阅成功！
                ButtonNext_Click(sender,e);
            }
            else
            {
                MessageBox.Show("借阅失败！");
            }
        }
    }
    
}
