namespace LibrarySystemVersion2
{
    partial class MyBook
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
            this.numericUpDownReturnBookScore = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelBookCount = new System.Windows.Forms.Label();
            this.ButtonReturnBook = new System.Windows.Forms.Button();
            this.PictureBoxBookImage = new System.Windows.Forms.PictureBox();
            this.PanelImage = new System.Windows.Forms.Panel();
            this.LabelBorrowCount = new System.Windows.Forms.Label();
            this.LabelBookCategory = new System.Windows.Forms.Label();
            this.LabelISBN = new System.Windows.Forms.Label();
            this.LabelBookID = new System.Windows.Forms.Label();
            this.LabelBookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.LabelBookPress = new System.Windows.Forms.Label();
            this.PanelBook = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelBorrowID = new System.Windows.Forms.Label();
            this.numericUpDownReturnBookCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelBookBorrowCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReturnBookScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBookImage)).BeginInit();
            this.PanelImage.SuspendLayout();
            this.panel.SuspendLayout();
            this.PanelBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReturnBookCount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownReturnBookScore
            // 
            this.numericUpDownReturnBookScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.numericUpDownReturnBookScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.numericUpDownReturnBookScore.Location = new System.Drawing.Point(93, 515);
            this.numericUpDownReturnBookScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownReturnBookScore.Name = "numericUpDownReturnBookScore";
            this.numericUpDownReturnBookScore.ReadOnly = true;
            this.numericUpDownReturnBookScore.Size = new System.Drawing.Size(69, 25);
            this.numericUpDownReturnBookScore.TabIndex = 18;
            this.numericUpDownReturnBookScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(14, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "ISBN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(21, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "类别:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(21, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "数量:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "出版社:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(21, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "书名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "图书ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "借阅量:";
            // 
            // LabelBookCount
            // 
            this.LabelBookCount.AutoSize = true;
            this.LabelBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBookCount.Location = new System.Drawing.Point(68, 75);
            this.LabelBookCount.Name = "LabelBookCount";
            this.LabelBookCount.Size = new System.Drawing.Size(0, 20);
            this.LabelBookCount.TabIndex = 8;
            // 
            // ButtonReturnBook
            // 
            this.ButtonReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ButtonReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonReturnBook.Location = new System.Drawing.Point(179, 463);
            this.ButtonReturnBook.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonReturnBook.Name = "ButtonReturnBook";
            this.ButtonReturnBook.Size = new System.Drawing.Size(99, 77);
            this.ButtonReturnBook.TabIndex = 14;
            this.ButtonReturnBook.Text = "书籍归还";
            this.ButtonReturnBook.UseVisualStyleBackColor = false;
            this.ButtonReturnBook.Click += new System.EventHandler(this.ButtonReturnBook_Click);
            // 
            // PictureBoxBookImage
            // 
            this.PictureBoxBookImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxBookImage.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxBookImage.Name = "PictureBoxBookImage";
            this.PictureBoxBookImage.Size = new System.Drawing.Size(283, 198);
            this.PictureBoxBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxBookImage.TabIndex = 0;
            this.PictureBoxBookImage.TabStop = false;
            // 
            // PanelImage
            // 
            this.PanelImage.Controls.Add(this.PictureBoxBookImage);
            this.PanelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelImage.Location = new System.Drawing.Point(0, 0);
            this.PanelImage.Name = "PanelImage";
            this.PanelImage.Size = new System.Drawing.Size(283, 198);
            this.PanelImage.TabIndex = 4;
            // 
            // LabelBorrowCount
            // 
            this.LabelBorrowCount.AutoSize = true;
            this.LabelBorrowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBorrowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBorrowCount.Location = new System.Drawing.Point(69, 135);
            this.LabelBorrowCount.Name = "LabelBorrowCount";
            this.LabelBorrowCount.Size = new System.Drawing.Size(0, 20);
            this.LabelBorrowCount.TabIndex = 7;
            // 
            // LabelBookCategory
            // 
            this.LabelBookCategory.AutoSize = true;
            this.LabelBookCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBookCategory.Location = new System.Drawing.Point(68, 95);
            this.LabelBookCategory.Name = "LabelBookCategory";
            this.LabelBookCategory.Size = new System.Drawing.Size(0, 20);
            this.LabelBookCategory.TabIndex = 6;
            // 
            // LabelISBN
            // 
            this.LabelISBN.AutoSize = true;
            this.LabelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelISBN.Location = new System.Drawing.Point(68, 115);
            this.LabelISBN.Name = "LabelISBN";
            this.LabelISBN.Size = new System.Drawing.Size(0, 20);
            this.LabelISBN.TabIndex = 5;
            // 
            // LabelBookID
            // 
            this.LabelBookID.AutoSize = true;
            this.LabelBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBookID.Location = new System.Drawing.Point(68, 15);
            this.LabelBookID.Name = "LabelBookID";
            this.LabelBookID.Size = new System.Drawing.Size(0, 20);
            this.LabelBookID.TabIndex = 2;
            // 
            // LabelBookName
            // 
            this.LabelBookName.AutoSize = true;
            this.LabelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBookName.Location = new System.Drawing.Point(68, 35);
            this.LabelBookName.Name = "LabelBookName";
            this.LabelBookName.Size = new System.Drawing.Size(0, 20);
            this.LabelBookName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(-1, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "书籍打分:";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.LabelBookCount);
            this.panel.Controls.Add(this.LabelBorrowCount);
            this.panel.Controls.Add(this.LabelBookCategory);
            this.panel.Controls.Add(this.LabelISBN);
            this.panel.Controls.Add(this.LabelBookPress);
            this.panel.Controls.Add(this.LabelBookID);
            this.panel.Controls.Add(this.LabelBookName);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 204);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(283, 189);
            this.panel.TabIndex = 5;
            // 
            // LabelBookPress
            // 
            this.LabelBookPress.AutoSize = true;
            this.LabelBookPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookPress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBookPress.Location = new System.Drawing.Point(68, 55);
            this.LabelBookPress.Name = "LabelBookPress";
            this.LabelBookPress.Size = new System.Drawing.Size(0, 20);
            this.LabelBookPress.TabIndex = 4;
            // 
            // PanelBook
            // 
            this.PanelBook.Controls.Add(this.panel);
            this.PanelBook.Controls.Add(this.PanelImage);
            this.PanelBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBook.Location = new System.Drawing.Point(0, 0);
            this.PanelBook.Name = "PanelBook";
            this.PanelBook.Size = new System.Drawing.Size(283, 393);
            this.PanelBook.TabIndex = 13;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView.Location = new System.Drawing.Point(283, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(522, 577);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(-1, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "借阅ID:";
            // 
            // LabelBorrowID
            // 
            this.LabelBorrowID.AutoSize = true;
            this.LabelBorrowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBorrowID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBorrowID.Location = new System.Drawing.Point(69, 396);
            this.LabelBorrowID.Name = "LabelBorrowID";
            this.LabelBorrowID.Size = new System.Drawing.Size(0, 20);
            this.LabelBorrowID.TabIndex = 19;
            // 
            // numericUpDownReturnBookCount
            // 
            this.numericUpDownReturnBookCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.numericUpDownReturnBookCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.numericUpDownReturnBookCount.Location = new System.Drawing.Point(93, 458);
            this.numericUpDownReturnBookCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownReturnBookCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownReturnBookCount.Name = "numericUpDownReturnBookCount";
            this.numericUpDownReturnBookCount.ReadOnly = true;
            this.numericUpDownReturnBookCount.Size = new System.Drawing.Size(69, 25);
            this.numericUpDownReturnBookCount.TabIndex = 21;
            this.numericUpDownReturnBookCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownReturnBookCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label10.Location = new System.Drawing.Point(-4, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "还书数量:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label11.Location = new System.Drawing.Point(-2, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "借阅量:";
            // 
            // LabelBookBorrowCount
            // 
            this.LabelBookBorrowCount.AutoSize = true;
            this.LabelBookBorrowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookBorrowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelBookBorrowCount.Location = new System.Drawing.Point(72, 430);
            this.LabelBookBorrowCount.Name = "LabelBookBorrowCount";
            this.LabelBookBorrowCount.Size = new System.Drawing.Size(99, 20);
            this.LabelBookBorrowCount.TabIndex = 16;
            this.LabelBookBorrowCount.Text = "我的借书量";
            // 
            // MyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(805, 577);
            this.Controls.Add(this.LabelBookBorrowCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownReturnBookCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LabelBorrowID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownReturnBookScore);
            this.Controls.Add(this.ButtonReturnBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelBook);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyBook";
            this.Text = "MyBook";
            this.Load += new System.EventHandler(this.MyBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReturnBookScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBookImage)).EndInit();
            this.PanelImage.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.PanelBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReturnBookCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownReturnBookScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelBookCount;
        private System.Windows.Forms.Button ButtonReturnBook;
        private System.Windows.Forms.PictureBox PictureBoxBookImage;
        private System.Windows.Forms.Panel PanelImage;
        private System.Windows.Forms.Label LabelBorrowCount;
        private System.Windows.Forms.Label LabelBookCategory;
        private System.Windows.Forms.Label LabelISBN;
        private System.Windows.Forms.Label LabelBookID;
        private System.Windows.Forms.Label LabelBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label LabelBookPress;
        private System.Windows.Forms.Panel PanelBook;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelBorrowID;
        private System.Windows.Forms.NumericUpDown numericUpDownReturnBookCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelBookBorrowCount;
    }
}