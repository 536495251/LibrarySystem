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
    public partial class UserHomeFindAllBook : Form
    {
        public UserHomeFindAllBook()
        {
            InitializeComponent();
        }

        private void UserHomeFindAllBook_Load(object sender, EventArgs e)
        {
            DButil.BookQueryAll(dataGridView);
            DButil.AdjustDataGridView(dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex >= 0)
        {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                string BookName = selectedRow.Cells[2].Value.ToString();
                string findbooktext = BookName;
                bool findbookbyname = true;
                MessageBox.Show("请在搜索框输入书名:" + findbooktext + "进行借阅");
        }
        }
    }
}
