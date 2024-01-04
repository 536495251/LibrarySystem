namespace LibrarySystemVersion2
{
    partial class UserHome
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
            this.ButtonFindBook = new System.Windows.Forms.Button();
            this.ButtonAllBook = new System.Windows.Forms.Button();
            this.ButtonRecommendBook = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.TextBoxFindBook = new System.Windows.Forms.TextBox();
            this.PanelViewBook = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonFindBook
            // 
            this.ButtonFindBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFindBook.Location = new System.Drawing.Point(703, 2);
            this.ButtonFindBook.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonFindBook.Name = "ButtonFindBook";
            this.ButtonFindBook.Size = new System.Drawing.Size(100, 64);
            this.ButtonFindBook.TabIndex = 2;
            this.ButtonFindBook.Text = "查找书籍";
            this.ButtonFindBook.UseVisualStyleBackColor = true;
            this.ButtonFindBook.Click += new System.EventHandler(this.ButtonFindBook_Click);
            // 
            // ButtonAllBook
            // 
            this.ButtonAllBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAllBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAllBook.Location = new System.Drawing.Point(200, 0);
            this.ButtonAllBook.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAllBook.Name = "ButtonAllBook";
            this.ButtonAllBook.Size = new System.Drawing.Size(200, 64);
            this.ButtonAllBook.TabIndex = 3;
            this.ButtonAllBook.Text = "全部图书";
            this.ButtonAllBook.UseVisualStyleBackColor = true;
            this.ButtonAllBook.Click += new System.EventHandler(this.ButtonAllBook_Click);
            // 
            // ButtonRecommendBook
            // 
            this.ButtonRecommendBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonRecommendBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRecommendBook.Location = new System.Drawing.Point(0, 0);
            this.ButtonRecommendBook.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRecommendBook.Name = "ButtonRecommendBook";
            this.ButtonRecommendBook.Size = new System.Drawing.Size(200, 64);
            this.ButtonRecommendBook.TabIndex = 4;
            this.ButtonRecommendBook.Text = "推荐图书";
            this.ButtonRecommendBook.UseVisualStyleBackColor = true;
            this.ButtonRecommendBook.Click += new System.EventHandler(this.ButtonRecommendBook_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PanelMenu.Controls.Add(this.TextBoxFindBook);
            this.PanelMenu.Controls.Add(this.ButtonAllBook);
            this.PanelMenu.Controls.Add(this.ButtonRecommendBook);
            this.PanelMenu.Controls.Add(this.ButtonFindBook);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(805, 64);
            this.PanelMenu.TabIndex = 6;
            // 
            // TextBoxFindBook
            // 
            this.TextBoxFindBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TextBoxFindBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.TextBoxFindBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TextBoxFindBook.Location = new System.Drawing.Point(469, 19);
            this.TextBoxFindBook.Name = "TextBoxFindBook";
            this.TextBoxFindBook.Size = new System.Drawing.Size(229, 27);
            this.TextBoxFindBook.TabIndex = 6;
            this.TextBoxFindBook.Text = "输入书名或出版社";
            this.TextBoxFindBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxFindBook_MouseClick);
            // 
            // PanelViewBook
            // 
            this.PanelViewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PanelViewBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelViewBook.Location = new System.Drawing.Point(0, 67);
            this.PanelViewBook.Margin = new System.Windows.Forms.Padding(2);
            this.PanelViewBook.Name = "PanelViewBook";
            this.PanelViewBook.Size = new System.Drawing.Size(805, 510);
            this.PanelViewBook.TabIndex = 7;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(805, 577);
            this.Controls.Add(this.PanelViewBook);
            this.Controls.Add(this.PanelMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonFindBook;
        private System.Windows.Forms.Button ButtonAllBook;
        private System.Windows.Forms.Button ButtonRecommendBook;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelViewBook;
        private System.Windows.Forms.TextBox TextBoxFindBook;
    }
}