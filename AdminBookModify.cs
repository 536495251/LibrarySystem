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
    public partial class AdminBookModify : Form
    {
        public AdminBookModify()
        {
            InitializeComponent();
        }



        private void AdminBookModify_Load(object sender, EventArgs e)
        {
            DButil.BookQueryAllSimple(dataGridView1);

            comboBoxModifyCategory.Items.Add("杂志期刊");
            comboBoxModifyCategory.Items.Add("计算机");
            comboBoxModifyCategory.Items.Add("精品小说");
            comboBoxModifyCategory.Items.Add("文学");
            comboBoxModifyCategory.Items.Add("经济理财");
            comboBoxModifyCategory.Items.Add("科学技术");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxBookModifyAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxBookModifyAccount_MouseLeave_1(object sender, EventArgs e)
        {
            Book book = null;
            try
            {
                int id = Convert.ToInt32(TextBoxBookModifyAccount.Text);

                if (!DButil.BookExistsByID(id))
                {
                    MessageBox.Show("ID不存在");
                    return;
                }
                book = DButil.BookQueryByID(id);
                LabelModifyName.Text = "书名:" + book.Name;
                LabelModifyBookPress.Text = "出版社:" + book.Press;
                LabelModifyBookCount.Text = "数量:" + book.Count.ToString();
                LabelModifyBookISBN.Text = "ISBN:" + book.ISBN.ToString();
                LabelModifyBookCategory.Text = "类别:" + book.Category;
                //LabelModifyBookRemark.Text = "介绍:" + book.Remark;
                pictureBox1.Image = book.Image;

                textBoxModifyBookName.Text = book.Name;
                textBoxModifyBookPress.Text = book.Press;
                textBoxModifyBookISBN.Text = book.ISBN.ToString();
                comboBoxModifyCategory.SelectedItem=book.Category;
                //comboBoxModifyCategory.SelectedText=book.Category;
                pictureBox2.Image = book.Image;
                numericUpDown1.Value= book.Count;

            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的ID");
                TextBoxBookModifyAccount.Text = string.Empty;
            }
        }

        private void LabelModifyBookRemark_Click(object sender, EventArgs e)
        {

        }

        private void BtnModifySave_Click(object sender, EventArgs e)
        {
            Book book = null;
            bool ok = true;
            //int BookNum = Convert.ToInt32(numericUpDown1.Text);
            
            try
            {
                if(TextBoxBookModifyAccount.Text == string.Empty)
                {
                    ok = false;
                    MessageBox.Show("请先输入要修改的ID"); 
                    return;
                }
                if(textBoxModifyBookName.Text == string.Empty || textBoxModifyBookPress.Text == string.Empty || textBoxModifyBookISBN.Text.Trim() == string.Empty)
                {
                    ok= false;
                    MessageBox.Show("书名、出版社、ISBN，不能为空");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的图书数量！");
                ok = false;
            }
            book = new Book(textBoxModifyBookName.Text, textBoxModifyBookPress.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBoxModifyBookISBN.Text, 16), comboBoxModifyCategory.Text, pictureBox1.Image);
            if (ok)
            {
                if (DButil.BookAlterByID(Convert.ToInt32(TextBoxBookModifyAccount.Text), textBoxModifyBookName.Text, textBoxModifyBookPress.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBoxModifyBookISBN.Text,16), comboBoxModifyCategory.Text, pictureBox2.Image))
                {
                    MessageBox.Show("修改成功！");
                    DButil.BookQueryAllSimple(dataGridView1);
                    book = DButil.BookQueryByID(Convert.ToInt32(TextBoxBookModifyAccount.Text));

                    LabelModifyName.Text = "书名:" + book.Name;
                    LabelModifyBookPress.Text = "出版社:" + book.Press;
                    LabelModifyBookCount.Text = "数量:" + book.Count;
                    LabelModifyBookCategory.Text = "类别:" + book.Category;
                    LabelModifyBookISBN.Text = "ISBN:" + book.ISBN;
                    pictureBox1.Image = book.Image;
                }
            }
            
        
        }

        private void BtnModifySelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg)|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void BtnModifyClear_Click(object sender, EventArgs e)
        {
            textBoxModifyBookName.Text = string.Empty;
            textBoxModifyBookPress.Text = string.Empty;
            textBoxModifyBookISBN.Text = string.Empty;
            //comboBoxCategory.Text= string.Empty;
            comboBoxModifyCategory.SelectedIndex = 0;
            pictureBox2.Image = null;
            numericUpDown1.ResetText();
        }
        private string getISBN(string bookName)
        {
            if (string.IsNullOrEmpty(bookName))
            {
                return String.Empty;
            }
            else
            {
             
                Encoding encoding = Encoding.UTF8;
                byte[] bytes = encoding.GetBytes(bookName);
                string hexEncoding = BitConverter.ToString(bytes).Replace("-", "").ToLower();
                string isbn = "";
                int length = Math.Min(hexEncoding.Length, 6);
                for (int i = 0; i < length; i++)
                {
                    isbn += hexEncoding[i];
                }
                return Math.Abs((Convert.ToInt32(isbn, 16))).ToString();
            }

        }

        private void textBoxModifyBookISBN_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxModifyBookISBN.Text = getISBN(textBoxModifyBookName.Text);
        }
    }
}
