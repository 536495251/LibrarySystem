namespace LibrarySystemVersion2
{
    partial class UserHomeFindBook
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.PanelBook = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelBookCount = new System.Windows.Forms.Label();
            this.LabelBorrowCount = new System.Windows.Forms.Label();
            this.LabelBookCategory = new System.Windows.Forms.Label();
            this.LabelISBN = new System.Windows.Forms.Label();
            this.LabelBookPress = new System.Windows.Forms.Label();
            this.LabelBookID = new System.Windows.Forms.Label();
            this.LabelBookName = new System.Windows.Forms.Label();
            this.PanelImage = new System.Windows.Forms.Panel();
            this.PictureBoxBookImage = new System.Windows.Forms.PictureBox();
            this.ButtonBorrowBook = new System.Windows.Forms.Button();
            this.DateTimePickerReturnBookDate = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownBorrowCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.PanelBook.SuspendLayout();
            this.panel.SuspendLayout();
            this.PanelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorrowCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView.Location = new System.Drawing.Point(283, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(522, 510);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // PanelBook
            // 
            this.PanelBook.Controls.Add(this.panel);
            this.PanelBook.Controls.Add(this.PanelImage);
            this.PanelBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBook.Location = new System.Drawing.Point(0, 0);
            this.PanelBook.Name = "PanelBook";
            this.PanelBook.Size = new System.Drawing.Size(283, 393);
            this.PanelBook.TabIndex = 1;
            this.PanelBook.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBook_Paint);
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
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.LabelBookCount.Click += new System.EventHandler(this.LabelBookCount_Click);
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
            this.LabelBorrowCount.Click += new System.EventHandler(this.LabelBorrowCount_Click);
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
            this.LabelBookCategory.Click += new System.EventHandler(this.LabelBookCategory_Click);
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
            this.LabelISBN.Click += new System.EventHandler(this.LabelISBN_Click);
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
            this.LabelBookPress.Click += new System.EventHandler(this.LabelBookPress_Click);
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
            this.LabelBookID.Click += new System.EventHandler(this.LabelBookID_Click);
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
            this.LabelBookName.Click += new System.EventHandler(this.LabelBookName_Click);
            // 
            // PanelImage
            // 
            this.PanelImage.Controls.Add(this.PictureBoxBookImage);
            this.PanelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelImage.Location = new System.Drawing.Point(0, 0);
            this.PanelImage.Name = "PanelImage";
            this.PanelImage.Size = new System.Drawing.Size(283, 198);
            this.PanelImage.TabIndex = 4;
            this.PanelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelImage_Paint);
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
            this.PictureBoxBookImage.Click += new System.EventHandler(this.PictureBoxBookImage_Click);
            // 
            // ButtonBorrowBook
            // 
            this.ButtonBorrowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ButtonBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBorrowBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonBorrowBook.Location = new System.Drawing.Point(179, 435);
            this.ButtonBorrowBook.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonBorrowBook.Name = "ButtonBorrowBook";
            this.ButtonBorrowBook.Size = new System.Drawing.Size(99, 64);
            this.ButtonBorrowBook.TabIndex = 3;
            this.ButtonBorrowBook.Text = "借阅该书籍";
            this.ButtonBorrowBook.UseVisualStyleBackColor = false;
            this.ButtonBorrowBook.Click += new System.EventHandler(this.ButtonBorrowBook_Click);
            // 
            // DateTimePickerReturnBookDate
            // 
            this.DateTimePickerReturnBookDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerReturnBookDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.DateTimePickerReturnBookDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.DateTimePickerReturnBookDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.DateTimePickerReturnBookDate.Location = new System.Drawing.Point(96, 399);
            this.DateTimePickerReturnBookDate.Name = "DateTimePickerReturnBookDate";
            this.DateTimePickerReturnBookDate.Size = new System.Drawing.Size(187, 25);
            this.DateTimePickerReturnBookDate.TabIndex = 4;
            this.DateTimePickerReturnBookDate.ValueChanged += new System.EventHandler(this.DateTimePickerReturnBookDate_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label.Location = new System.Drawing.Point(2, 403);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(87, 20);
            this.label.TabIndex = 9;
            this.label.Text = "归还日期:";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(2, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "借阅数量:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownBorrowCount
            // 
            this.numericUpDownBorrowCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.numericUpDownBorrowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.numericUpDownBorrowCount.Location = new System.Drawing.Point(96, 462);
            this.numericUpDownBorrowCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBorrowCount.Name = "numericUpDownBorrowCount";
            this.numericUpDownBorrowCount.ReadOnly = true;
            this.numericUpDownBorrowCount.Size = new System.Drawing.Size(69, 25);
            this.numericUpDownBorrowCount.TabIndex = 11;
            this.numericUpDownBorrowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownBorrowCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBorrowCount.ValueChanged += new System.EventHandler(this.numericUpDownBorrowCount_ValueChanged);
            // 
            // UserHomeFindBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(805, 510);
            this.Controls.Add(this.numericUpDownBorrowCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.DateTimePickerReturnBookDate);
            this.Controls.Add(this.ButtonBorrowBook);
            this.Controls.Add(this.PanelBook);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserHomeFindBook";
            this.Text = "UserHomeFindBook";
            this.Load += new System.EventHandler(this.UserHomeFindBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.PanelBook.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.PanelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorrowCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel PanelBook;
        private System.Windows.Forms.Button ButtonBorrowBook;
        private System.Windows.Forms.Panel PanelImage;
        private System.Windows.Forms.PictureBox PictureBoxBookImage;
        private System.Windows.Forms.Label LabelBookName;
        private System.Windows.Forms.Label LabelBookID;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label LabelBookCategory;
        private System.Windows.Forms.Label LabelISBN;
        private System.Windows.Forms.Label LabelBookPress;
        private System.Windows.Forms.Label LabelBorrowCount;
        private System.Windows.Forms.Label LabelBookCount;
        private System.Windows.Forms.DateTimePicker DateTimePickerReturnBookDate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownBorrowCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}