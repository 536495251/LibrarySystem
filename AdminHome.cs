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
    public partial class AdminHome : Form
    {
        bool isReturn = false;
        User user = null;
        Book book = null;
        Borrow borrow = null;
        public AdminHome()
        {
            InitializeComponent();
        }

        private void PanelAdminHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            //显示借阅表
            dataGridView1.Visible=true;
            dataGridView2.Visible= false;
            DButil.AdminQueryAllBorrow(dataGridView1);
           
        }

        private void BtnAdminBorrow_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible= true;
            dataGridView2.Visible = false;
            DButil.AdminQueryAllBorrow(dataGridView1);
            //清空还书Label
            LabelReturnID.Text = string.Empty;
            LabelBorrowBookID2.Text = string.Empty;
            LabelReturnBookScore.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void BtnAdminReturn_Click(object sender, EventArgs e)
        {   
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            DButil.AdminQueryAllReturn(dataGridView2);
            //清空借书Label
            LabelBookID.Text = string.Empty;
            LabelBorrowBookID.Text = string.Empty;
            LabelUserID.Text = string.Empty;
            LabelUserName.Text = string.Empty;
            LabelBookCount.Text = string.Empty;
            LabelBorrowDate.Text = string.Empty;
            LabelBorrowDate2.Text = string.Empty;
            LabelReturnDate.Text = string.Empty;
            LabelReturnDate2.Text = string.Empty;
            pictureBox1.Image = null;



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isReturn = true;
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                
                LabelReturnID.Text = "还书ID:"+selectedRow.Cells[0].Value.ToString();
                LabelBorrowBookID2.Text = "借书ID:" + selectedRow.Cells[1].Value.ToString();
                LabelReturnBookScore.Text = "书籍分数:" + selectedRow.Cells[2].Value.ToString();
                LabelReturnAcDate.Text = "还书时间:" + selectedRow.Cells[3].Value.ToString();
                borrow = DButil.BookQueryByBorrowID(Convert.ToInt32(selectedRow.Cells[1].Value));
                book = DButil.BookQueryByID(Convert.ToInt32(borrow.BookID));
                pictureBox1.Image = book.Image;
                DateTime acReturnDate = Convert.ToDateTime(selectedRow.Cells[3].Value);
                TimeSpan SubTime = acReturnDate.Subtract(borrow.ReturnDate);

                //判断是否要冻结该账户
                if (SubTime.TotalMilliseconds >= 0)
                {
                    DialogResult result = MessageBox.Show("该用户还书已经逾期\n是否冻结该用户？", "冻结提示", MessageBoxButtons.YesNo);

                    // 根据用户的选择执行相应的操作
                    if (result == DialogResult.Yes)
                    {
                        DButil.UserFrozenByID(borrow.UserID, true);
                        MessageBox.Show("该用户已经被冻结！");
                    }
                    else if(result == DialogResult.No)
                    {
                        MessageBox.Show("该用户不被被冻结");
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isReturn = true;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                LabelBookID.Text = "还书ID:" + selectedRow.Cells[1].Value.ToString();
                LabelBorrowBookID.Text = "借书ID:" + selectedRow.Cells[0].Value.ToString();
                LabelUserID.Text = "读者ID:" + selectedRow.Cells[2].Value.ToString();
                user = DButil.UserQueryByID(Convert.ToInt32(selectedRow.Cells[2].Value));
                LabelUserName.Text = "读者名:" + user.UserName;
                LabelBookCount.Text = "借阅数量:" + selectedRow.Cells[5].Value.ToString();
                LabelBorrowDate.Text = "借书时间:";
                LabelBorrowDate2.Text = selectedRow.Cells[3].Value.ToString();
                LabelReturnDate.Text = "还书时间:";
                LabelReturnDate2.Text = selectedRow.Cells[4].Value.ToString();
                book = DButil.BookQueryByID(Convert.ToInt32(selectedRow.Cells[1].Value));
                pictureBox1.Image = book.Image;
                if(Convert.ToInt32(selectedRow.Cells[5].Value)==0)
                {
                    DialogResult result = MessageBox.Show("该用户已经全部还书\n是否删除该记录？\n如果删除将影响到用户的推荐图书！", "删除提示", MessageBoxButtons.YesNo);

                    // 根据用户的选择执行相应的操作
                    if (result == DialogResult.Yes)
                    {
                        if(DButil.BorrowDelete(Convert.ToInt32(selectedRow.Cells[0].Value)))
                        MessageBox.Show("该借阅记录已经被删除！");
                        BtnAdminBorrow_Click(sender, e);

                    }
                    if(result == DialogResult.No)
                    {
                        MessageBox.Show("该借阅记录依然保留");
                    }
                }

            }
        }
    }
}
