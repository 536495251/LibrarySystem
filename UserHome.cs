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
    public partial class UserHome : Form
    {
        public User user;
        public UserHome()
        {
            InitializeComponent();
        }
        public UserHome(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ButtonRecommendBook_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelViewBook.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            UserHomeRecommendBook userHomeRecommendBook = new UserHomeRecommendBook(user);
            userHomeRecommendBook.TopLevel = false;
            userHomeRecommendBook.Parent = PanelViewBook;
            PanelViewBook.Controls.Add(userHomeRecommendBook);
            userHomeRecommendBook.Show();
        }

        private void ButtonAllBook_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelViewBook.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            UserHomeFindAllBook userHomeFindAllBook = new UserHomeFindAllBook();
            userHomeFindAllBook.TopLevel = false;
            userHomeFindAllBook.Parent = PanelViewBook;
            PanelViewBook.Controls.Add(userHomeFindAllBook);
            userHomeFindAllBook.Show();
        }

        private void ButtonFindBook_Click(object sender, EventArgs e)
        {
            foreach (Control f in this.PanelViewBook.Controls)
            {
                if (f is Form)
                {
                    ((Form)f).Close();
                }
            }
            string findbooktext = TextBoxFindBook.Text;
            bool findbookbyname = true;
            if (findbooktext.Contains("出版"))
            {
                findbookbyname = false;
            }
            UserHomeFindBook userHomeFindBook = new UserHomeFindBook(user,findbooktext, findbookbyname);
            userHomeFindBook.TopLevel = false;
            userHomeFindBook.Parent = PanelViewBook;
            PanelViewBook.Controls.Add(userHomeFindBook);
            userHomeFindBook.Show();
            TextBoxFindBook.Text = "请输入书名或出版社";

        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            ButtonAllBook_Click(sender, e);
        }

        private void TextBoxFindBook_MouseEnter(object sender, EventArgs e)
        {
    
        }

        private void TextBoxFindBook_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void TextBoxFindBook_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxFindBook.Text =String.Empty;
        }
    }
}
