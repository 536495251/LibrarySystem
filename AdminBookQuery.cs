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
    public partial class AdminBookQuery : Form
    {
        public AdminBookQuery()
        {
            InitializeComponent();
        }

        private void AdminBookQuery_Load(object sender, EventArgs e)
        {
            DButil.BookQueryAll(dataGridView1);
        }

        private void textBoxBookQuery_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxBookQuery_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxBookQuery.Text = string.Empty;
        }

        private void BtnBookQuery_Click(object sender, EventArgs e)
        {
            DButil.BookQueryByName(dataGridView1, textBoxBookQuery.Text);
        }
    }
}
