namespace LibrarySystemVersion2
{
    partial class AdminBookAdd
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
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.textBoxBookAdd = new System.Windows.Forms.TextBox();
            this.textBoxPress = new System.Windows.Forms.TextBox();
            this.BookPressLabel = new System.Windows.Forms.Label();
            this.textBoxRemake = new System.Windows.Forms.TextBox();
            this.RemakeLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.BookCountLabel = new System.Windows.Forms.Label();
            this.BookImageLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClearAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.BtnSelectPic = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BookNameLabel.Location = new System.Drawing.Point(29, 85);
            this.BookNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(52, 15);
            this.BookNameLabel.TabIndex = 0;
            this.BookNameLabel.Text = "书名：";
            // 
            // textBoxBookAdd
            // 
            this.textBoxBookAdd.Location = new System.Drawing.Point(80, 83);
            this.textBoxBookAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBookAdd.Name = "textBoxBookAdd";
            this.textBoxBookAdd.Size = new System.Drawing.Size(140, 25);
            this.textBoxBookAdd.TabIndex = 1;
            // 
            // textBoxPress
            // 
            this.textBoxPress.Location = new System.Drawing.Point(80, 161);
            this.textBoxPress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPress.Name = "textBoxPress";
            this.textBoxPress.Size = new System.Drawing.Size(140, 25);
            this.textBoxPress.TabIndex = 9;
            // 
            // BookPressLabel
            // 
            this.BookPressLabel.AutoSize = true;
            this.BookPressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BookPressLabel.Location = new System.Drawing.Point(13, 162);
            this.BookPressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookPressLabel.Name = "BookPressLabel";
            this.BookPressLabel.Size = new System.Drawing.Size(67, 15);
            this.BookPressLabel.TabIndex = 8;
            this.BookPressLabel.Text = "出版社：";
            // 
            // textBoxRemake
            // 
            this.textBoxRemake.Location = new System.Drawing.Point(327, 129);
            this.textBoxRemake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRemake.Multiline = true;
            this.textBoxRemake.Name = "textBoxRemake";
            this.textBoxRemake.Size = new System.Drawing.Size(187, 135);
            this.textBoxRemake.TabIndex = 13;
            this.textBoxRemake.TextChanged += new System.EventHandler(this.textBoxRemake_TextChanged);
            // 
            // RemakeLabel
            // 
            this.RemakeLabel.AutoSize = true;
            this.RemakeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RemakeLabel.Location = new System.Drawing.Point(247, 131);
            this.RemakeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemakeLabel.Name = "RemakeLabel";
            this.RemakeLabel.Size = new System.Drawing.Size(82, 15);
            this.RemakeLabel.TabIndex = 12;
            this.RemakeLabel.Text = "书籍介绍：";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CategoryLabel.Location = new System.Drawing.Point(29, 236);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 15);
            this.CategoryLabel.TabIndex = 10;
            this.CategoryLabel.Text = "类别：";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(582, 83);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(140, 25);
            this.textBoxISBN.TabIndex = 17;
            this.textBoxISBN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxISBN_MouseClick);
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ISBNLabel.Location = new System.Drawing.Point(531, 85);
            this.ISBNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(54, 15);
            this.ISBNLabel.TabIndex = 16;
            this.ISBNLabel.Text = "ISBN：";
            // 
            // BookCountLabel
            // 
            this.BookCountLabel.AutoSize = true;
            this.BookCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BookCountLabel.Location = new System.Drawing.Point(279, 84);
            this.BookCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookCountLabel.Name = "BookCountLabel";
            this.BookCountLabel.Size = new System.Drawing.Size(52, 15);
            this.BookCountLabel.TabIndex = 14;
            this.BookCountLabel.Text = "数量：";
            // 
            // BookImageLabel
            // 
            this.BookImageLabel.AutoSize = true;
            this.BookImageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BookImageLabel.Location = new System.Drawing.Point(529, 129);
            this.BookImageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookImageLabel.Name = "BookImageLabel";
            this.BookImageLabel.Size = new System.Drawing.Size(52, 15);
            this.BookImageLabel.TabIndex = 20;
            this.BookImageLabel.Text = "图片：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(582, 129);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnSave.Location = new System.Drawing.Point(515, 318);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 41);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClearAdd
            // 
            this.BtnClearAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnClearAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnClearAdd.Location = new System.Drawing.Point(673, 318);
            this.BtnClearAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClearAdd.Name = "BtnClearAdd";
            this.BtnClearAdd.Size = new System.Drawing.Size(117, 41);
            this.BtnClearAdd.TabIndex = 25;
            this.BtnClearAdd.Text = "清空";
            this.BtnClearAdd.UseVisualStyleBackColor = false;
            this.BtnClearAdd.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(331, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "添 加 图 书";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DisplayMember = "Items";
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(80, 236);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(140, 23);
            this.comboBoxCategory.TabIndex = 28;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.Category_Click);
            // 
            // BtnSelectPic
            // 
            this.BtnSelectPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnSelectPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnSelectPic.Location = new System.Drawing.Point(725, 236);
            this.BtnSelectPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSelectPic.Name = "BtnSelectPic";
            this.BtnSelectPic.Size = new System.Drawing.Size(81, 26);
            this.BtnSelectPic.TabIndex = 29;
            this.BtnSelectPic.Text = "选择图片";
            this.BtnSelectPic.UseVisualStyleBackColor = false;
            this.BtnSelectPic.Click += new System.EventHandler(this.BtnSelectPic_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(327, 83);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(164, 25);
            this.numericUpDown1.TabIndex = 30;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AdminBookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(829, 386);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.BtnSelectPic);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClearAdd);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BookImageLabel);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.BookCountLabel);
            this.Controls.Add(this.textBoxRemake);
            this.Controls.Add(this.RemakeLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.textBoxPress);
            this.Controls.Add(this.BookPressLabel);
            this.Controls.Add(this.textBoxBookAdd);
            this.Controls.Add(this.BookNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminBookAdd";
            this.Text = "AdminBookAdd";
            this.Load += new System.EventHandler(this.AdminBookAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.TextBox textBoxBookAdd;
        private System.Windows.Forms.TextBox textBoxPress;
        private System.Windows.Forms.Label BookPressLabel;
        private System.Windows.Forms.TextBox textBoxRemake;
        private System.Windows.Forms.Label RemakeLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label BookCountLabel;
        private System.Windows.Forms.Label BookImageLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClearAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button BtnSelectPic;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}