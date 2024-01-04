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
    public partial class AdminBookDelete : Form
    {
        public AdminBookDelete()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminBookDelete_Load(object sender, EventArgs e)
        {
            DButil.BookQueryAll(dataGridView1);
        }

        private void TextBoxUserDeleteAccount_MouseLeave(object sender, EventArgs e)
        {
            Book book = null;
            try
            {
                int id = Convert.ToInt32(TextBoxBookDeleteAccount.Text);
                if (!DButil.BookExistsByID(id))
                {
                    MessageBox.Show("id不存在");
                    TextBoxBookDeleteAccount.Text = string.Empty;
                    LabelBookName.Text = string.Empty;
                    LabelBookPress.Text = string.Empty;
                    LabelBookCount.Text = string.Empty;
                    LabelBookISBN.Text = string.Empty;
                    LabelBookCategory.Text = string.Empty;
                    pictureBox1.Image = null;
                    return;
                }
                book = DButil.BookQueryByID(id);
                LabelBookName.Text = "书名:" + book.Name;
                LabelBookPress.Text = "出版社:" + book.Press;
                LabelBookCount.Text = "数量:" + book.Count.ToString();
                LabelBookISBN.Text = "ISBN:" +book.ISBN;
                LabelBookCategory.Text = "类别:" + book.Category;
 
                pictureBox1.Image = book.Image;
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的ID");
                TextBoxBookDeleteAccount.Text = string.Empty;
            }
        }

        private void ButtonBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TextBoxBookDeleteAccount.Text);

                if (!DButil.BookExistsByID(id))
                {
                    MessageBox.Show("id不存在");
                    TextBoxBookDeleteAccount.Text = string.Empty;
                    LabelBookName.Text = string.Empty;
                    LabelBookPress.Text = string.Empty;
                    LabelBookCount.Text = string.Empty;
                    LabelBookISBN.Text = string.Empty;
                    LabelBookCategory.Text = string.Empty;
                    pictureBox1.Image = null;
                    return;
                }
                if (DButil.BookDeleteByID(id))
                {
                    DButil.BookQueryAll(dataGridView1);
                    MessageBox.Show("删除成功！");
                    TextBoxBookDeleteAccount.Text = string.Empty;
                    LabelBookName.Text = string.Empty;
                    LabelBookPress.Text = string.Empty;
                    LabelBookCount.Text = string.Empty;
                    LabelBookISBN.Text = string.Empty;
                    LabelBookCategory.Text = string.Empty;
                    pictureBox1.Image = null;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的ID");
                TextBoxBookDeleteAccount.Text = string.Empty;
            }
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
