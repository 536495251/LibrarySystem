namespace LibrarySystemVersion2
{
    partial class AdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelAdminHome = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAdminReturn = new System.Windows.Forms.Button();
            this.BtnAdminBorrow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelReturnAcDate = new System.Windows.Forms.Label();
            this.LabelBorrowBookID2 = new System.Windows.Forms.Label();
            this.LabelReturnBookScore = new System.Windows.Forms.Label();
            this.LabelReturnID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelReturnDate2 = new System.Windows.Forms.Label();
            this.LabelBorrowDate2 = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelBookID = new System.Windows.Forms.Label();
            this.LabelUserID = new System.Windows.Forms.Label();
            this.LabelBookCount = new System.Windows.Forms.Label();
            this.LabelBorrowDate = new System.Windows.Forms.Label();
            this.LabelReturnDate = new System.Windows.Forms.Label();
            this.LabelBorrowBookID = new System.Windows.Forms.Label();
            this.PanelAdminHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAdminHome
            // 
            this.PanelAdminHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PanelAdminHome.Controls.Add(this.dataGridView2);
            this.PanelAdminHome.Controls.Add(this.dataGridView1);
            this.PanelAdminHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelAdminHome.Location = new System.Drawing.Point(0, 0);
            this.PanelAdminHome.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAdminHome.Name = "PanelAdminHome";
            this.PanelAdminHome.Size = new System.Drawing.Size(617, 530);
            this.PanelAdminHome.TabIndex = 0;
            this.PanelAdminHome.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelAdminHome_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(617, 530);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(617, 530);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnAdminReturn
            // 
            this.BtnAdminReturn.Location = new System.Drawing.Point(627, 8);
            this.BtnAdminReturn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdminReturn.Name = "BtnAdminReturn";
            this.BtnAdminReturn.Size = new System.Drawing.Size(100, 39);
            this.BtnAdminReturn.TabIndex = 1;
            this.BtnAdminReturn.Text = "归还管理";
            this.BtnAdminReturn.UseVisualStyleBackColor = true;
            this.BtnAdminReturn.Click += new System.EventHandler(this.BtnAdminReturn_Click);
            // 
            // BtnAdminBorrow
            // 
            this.BtnAdminBorrow.Location = new System.Drawing.Point(739, 8);
            this.BtnAdminBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdminBorrow.Name = "BtnAdminBorrow";
            this.BtnAdminBorrow.Size = new System.Drawing.Size(95, 39);
            this.BtnAdminBorrow.TabIndex = 2;
            this.BtnAdminBorrow.Text = "借阅管理";
            this.BtnAdminBorrow.UseVisualStyleBackColor = true;
            this.BtnAdminBorrow.Click += new System.EventHandler(this.BtnAdminBorrow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelReturnAcDate);
            this.panel1.Controls.Add(this.LabelBorrowBookID2);
            this.panel1.Controls.Add(this.LabelReturnBookScore);
            this.panel1.Controls.Add(this.LabelReturnID);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LabelReturnDate2);
            this.panel1.Controls.Add(this.LabelBorrowDate2);
            this.panel1.Controls.Add(this.LabelUserName);
            this.panel1.Controls.Add(this.LabelBookID);
            this.panel1.Controls.Add(this.LabelUserID);
            this.panel1.Controls.Add(this.LabelBookCount);
            this.panel1.Controls.Add(this.LabelBorrowDate);
            this.panel1.Controls.Add(this.LabelReturnDate);
            this.panel1.Controls.Add(this.LabelBorrowBookID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(617, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 479);
            this.panel1.TabIndex = 3;
            // 
            // LabelReturnAcDate
            // 
            this.LabelReturnAcDate.AutoSize = true;
            this.LabelReturnAcDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelReturnAcDate.Location = new System.Drawing.Point(24, 137);
            this.LabelReturnAcDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReturnAcDate.Name = "LabelReturnAcDate";
            this.LabelReturnAcDate.Size = new System.Drawing.Size(0, 15);
            this.LabelReturnAcDate.TabIndex = 13;
            // 
            // LabelBorrowBookID2
            // 
            this.LabelBorrowBookID2.AutoSize = true;
            this.LabelBorrowBookID2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBorrowBookID2.Location = new System.Drawing.Point(24, 36);
            this.LabelBorrowBookID2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBorrowBookID2.Name = "LabelBorrowBookID2";
            this.LabelBorrowBookID2.Size = new System.Drawing.Size(0, 15);
            this.LabelBorrowBookID2.TabIndex = 12;
            // 
            // LabelReturnBookScore
            // 
            this.LabelReturnBookScore.AutoSize = true;
            this.LabelReturnBookScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelReturnBookScore.Location = new System.Drawing.Point(23, 102);
            this.LabelReturnBookScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReturnBookScore.Name = "LabelReturnBookScore";
            this.LabelReturnBookScore.Size = new System.Drawing.Size(0, 15);
            this.LabelReturnBookScore.TabIndex = 11;
            // 
            // LabelReturnID
            // 
            this.LabelReturnID.AutoSize = true;
            this.LabelReturnID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelReturnID.Location = new System.Drawing.Point(23, 71);
            this.LabelReturnID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReturnID.Name = "LabelReturnID";
            this.LabelReturnID.Size = new System.Drawing.Size(0, 15);
            this.LabelReturnID.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 323);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LabelReturnDate2
            // 
            this.LabelReturnDate2.AutoSize = true;
            this.LabelReturnDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelReturnDate2.Location = new System.Drawing.Point(23, 297);
            this.LabelReturnDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReturnDate2.Name = "LabelReturnDate2";
            this.LabelReturnDate2.Size = new System.Drawing.Size(0, 15);
            this.LabelReturnDate2.TabIndex = 8;
            // 
            // LabelBorrowDate2
            // 
            this.LabelBorrowDate2.AutoSize = true;
            this.LabelBorrowDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBorrowDate2.Location = new System.Drawing.Point(24, 233);
            this.LabelBorrowDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBorrowDate2.Name = "LabelBorrowDate2";
            this.LabelBorrowDate2.Size = new System.Drawing.Size(0, 15);
            this.LabelBorrowDate2.TabIndex = 7;
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelUserName.Location = new System.Drawing.Point(23, 137);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(0, 15);
            this.LabelUserName.TabIndex = 6;
            // 
            // LabelBookID
            // 
            this.LabelBookID.AutoSize = true;
            this.LabelBookID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBookID.Location = new System.Drawing.Point(23, 71);
            this.LabelBookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBookID.Name = "LabelBookID";
            this.LabelBookID.Size = new System.Drawing.Size(0, 15);
            this.LabelBookID.TabIndex = 5;
            // 
            // LabelUserID
            // 
            this.LabelUserID.AutoSize = true;
            this.LabelUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelUserID.Location = new System.Drawing.Point(23, 102);
            this.LabelUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUserID.Name = "LabelUserID";
            this.LabelUserID.Size = new System.Drawing.Size(0, 15);
            this.LabelUserID.TabIndex = 4;
            // 
            // LabelBookCount
            // 
            this.LabelBookCount.AutoSize = true;
            this.LabelBookCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBookCount.Location = new System.Drawing.Point(23, 169);
            this.LabelBookCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBookCount.Name = "LabelBookCount";
            this.LabelBookCount.Size = new System.Drawing.Size(0, 15);
            this.LabelBookCount.TabIndex = 3;
            // 
            // LabelBorrowDate
            // 
            this.LabelBorrowDate.AutoSize = true;
            this.LabelBorrowDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBorrowDate.Location = new System.Drawing.Point(23, 203);
            this.LabelBorrowDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBorrowDate.Name = "LabelBorrowDate";
            this.LabelBorrowDate.Size = new System.Drawing.Size(0, 15);
            this.LabelBorrowDate.TabIndex = 2;
            // 
            // LabelReturnDate
            // 
            this.LabelReturnDate.AutoSize = true;
            this.LabelReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelReturnDate.Location = new System.Drawing.Point(24, 267);
            this.LabelReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelReturnDate.Name = "LabelReturnDate";
            this.LabelReturnDate.Size = new System.Drawing.Size(0, 15);
            this.LabelReturnDate.TabIndex = 1;
            // 
            // LabelBorrowBookID
            // 
            this.LabelBorrowBookID.AutoSize = true;
            this.LabelBorrowBookID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBorrowBookID.Location = new System.Drawing.Point(23, 36);
            this.LabelBorrowBookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBorrowBookID.Name = "LabelBorrowBookID";
            this.LabelBorrowBookID.Size = new System.Drawing.Size(0, 15);
            this.LabelBorrowBookID.TabIndex = 0;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(847, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAdminBorrow);
            this.Controls.Add(this.BtnAdminReturn);
            this.Controls.Add(this.PanelAdminHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.PanelAdminHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAdminHome;
        private System.Windows.Forms.Button BtnAdminReturn;
        private System.Windows.Forms.Button BtnAdminBorrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelBookID;
        private System.Windows.Forms.Label LabelUserID;
        private System.Windows.Forms.Label LabelBookCount;
        private System.Windows.Forms.Label LabelBorrowDate;
        private System.Windows.Forms.Label LabelReturnDate;
        private System.Windows.Forms.Label LabelBorrowBookID;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label LabelReturnDate2;
        private System.Windows.Forms.Label LabelBorrowDate2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelReturnBookScore;
        private System.Windows.Forms.Label LabelReturnID;
        private System.Windows.Forms.Label LabelBorrowBookID2;
        private System.Windows.Forms.Label LabelReturnAcDate;
    }
}