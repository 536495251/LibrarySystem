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
    public partial class AdminBookAdd : Form
    {
        public Book AddBook;
        public AdminBookAdd()
        {
            InitializeComponent();

        }
        public AdminBookAdd(Book book)
        {
            this.AddBook = book;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool ok = true;
            //string BookName = textBoxBookAdd.Text;
            int BookNum = Convert.ToInt32(numericUpDown1.Text);

            //string BookPress = textBoxPress.Text;
            //string BookCategory = comboBoxCategory.Text;    //comboBox


            //int BookISBN = Convert.ToInt32(textBoxISBN.Text.Trim());


            //string BookIntroduce = textBoxRemake.Text;
            // pictrueBox

            try
            {
                BookNum = int.Parse(numericUpDown1.Text);
                if (textBoxBookAdd.Text == string.Empty || textBoxPress.Text == string.Empty || textBoxISBN.Text == string.Empty || comboBoxCategory.Text == string.Empty || textBoxRemake.Text == string.Empty || pictureBox1.Image == null)
                {
                    ok = false;
                    MessageBox.Show("要添加的图书信息都不能为空");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的图书数量！");
                ok = false;
            }

            Book book = new Book(textBoxBookAdd.Text, textBoxPress.Text, Convert.ToInt32(numericUpDown1.Text), Convert.ToInt32(textBoxISBN.Text,16), comboBoxCategory.Text, textBoxRemake.Text, pictureBox1.Image);


            if (ok)
            {
                if (DButil.BookAdd(book.Name, book.Count, book.Press, book.Category, book.ISBN, book.Remake, book.Image))
                {
                    MessageBox.Show("添加成功！");
                    textBoxBookAdd.Text = string.Empty;
                    textBoxPress.Text = string.Empty;
                    textBoxRemake.Text = string.Empty;
                    textBoxISBN.Text = string.Empty;
                    //comboBoxCategory.Text= string.Empty;
                    comboBoxCategory.SelectedIndex = 0;
                    pictureBox1.Image = null;
                    numericUpDown1.Value=1;

                }
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void Category_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSelectPic_Click(object sender, EventArgs e)
        {
            //string strImage = "";
            //
            //openFileDialog1.FileName 用户选中的文件名（路径）
            //openFileDialog1.FileNames 用户选择的多个文件
            //openFileDialog1.Filter 文件后缀 过滤器
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }



        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void AdminBookAdd_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("杂志期刊");
            comboBoxCategory.Items.Add("计算机");
            comboBoxCategory.Items.Add("精品小说");
            comboBoxCategory.Items.Add("文学");
            comboBoxCategory.Items.Add("经济理财");
            comboBoxCategory.Items.Add("科学技术");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBoxBookAdd.Text= string.Empty;
            textBoxPress.Text= string.Empty;
            textBoxRemake.Text= string.Empty;
            //comboBoxCategory.Text= string.Empty;
            comboBoxCategory.SelectedIndex=0;
            pictureBox1.Image= null;
            numericUpDown1.ResetText();

        }

        private void textBoxRemake_TextChanged(object sender, EventArgs e)
        {
            
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
                for (int i =0;i< length; i++)
                {
                    isbn += hexEncoding[i];
                }
                return Math.Abs((Convert.ToInt32(isbn, 16))).ToString();
            }
                        
        }

        private void textBoxISBN_MouseClick(object sender, MouseEventArgs e)
        {
                 
           textBoxISBN.Text=getISBN(textBoxBookAdd.Text);
                    
        }
    }
}
