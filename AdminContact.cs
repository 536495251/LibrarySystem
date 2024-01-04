using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystemVersion2
{
    public partial class AdminContact : Form
    {
        Message message=null;
        bool isDelete = false;
        public AdminContact()
        {
            InitializeComponent();
        }

        private void AdminContact_Load(object sender, EventArgs e)
        {
            DButil.AdminAcceptMessage(dataGridView);

        }

        private void CellClick_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                isDelete = true;
                this.LabelMessageID.Text = this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                message=DButil.FindMessageByID(Convert.ToInt32(LabelMessageID.Text));
                richTextBoxMessage.Text = message.message;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!isDelete)
            {
                MessageBox.Show("请选择要删除的消息！");
                return;
            }
            if(DButil.MessageDeleteByID(Convert.ToInt32(LabelMessageID.Text)))
            {
                MessageBox.Show("删除成功！");
                DButil.AdminAcceptMessage(dataGridView);
            }
            else
            {
                MessageBox.Show("删除异常！");
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            
        }
    }
}
