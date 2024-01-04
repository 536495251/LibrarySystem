namespace LibrarySystemVersion2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonContactAdmin = new System.Windows.Forms.Button();
            this.ButtonUserIfo = new System.Windows.Forms.Button();
            this.ButtonMyBooks = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.ButtonExit);
            this.panel1.Controls.Add(this.ButtonContactAdmin);
            this.panel1.Controls.Add(this.ButtonUserIfo);
            this.panel1.Controls.Add(this.ButtonMyBooks);
            this.panel1.Controls.Add(this.ButtonHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 577);
            this.panel1.TabIndex = 0;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonExit.Location = new System.Drawing.Point(0, 525);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(213, 52);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "退出";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonContactAdmin
            // 
            this.ButtonContactAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonContactAdmin.FlatAppearance.BorderSize = 0;
            this.ButtonContactAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonContactAdmin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonContactAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonContactAdmin.Location = new System.Drawing.Point(0, 300);
            this.ButtonContactAdmin.Name = "ButtonContactAdmin";
            this.ButtonContactAdmin.Size = new System.Drawing.Size(213, 52);
            this.ButtonContactAdmin.TabIndex = 4;
            this.ButtonContactAdmin.Text = "联系管理员";
            this.ButtonContactAdmin.UseVisualStyleBackColor = true;
            this.ButtonContactAdmin.Click += new System.EventHandler(this.ButtonContactAdmin_Click_1);
            // 
            // ButtonUserIfo
            // 
            this.ButtonUserIfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonUserIfo.FlatAppearance.BorderSize = 0;
            this.ButtonUserIfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUserIfo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUserIfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonUserIfo.Location = new System.Drawing.Point(0, 248);
            this.ButtonUserIfo.Name = "ButtonUserIfo";
            this.ButtonUserIfo.Size = new System.Drawing.Size(213, 52);
            this.ButtonUserIfo.TabIndex = 3;
            this.ButtonUserIfo.Text = "用户信息";
            this.ButtonUserIfo.UseVisualStyleBackColor = true;
            this.ButtonUserIfo.Click += new System.EventHandler(this.ButtonUserIfo_Click);
            // 
            // ButtonMyBooks
            // 
            this.ButtonMyBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonMyBooks.FlatAppearance.BorderSize = 0;
            this.ButtonMyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMyBooks.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMyBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonMyBooks.Location = new System.Drawing.Point(0, 196);
            this.ButtonMyBooks.Name = "ButtonMyBooks";
            this.ButtonMyBooks.Size = new System.Drawing.Size(213, 52);
            this.ButtonMyBooks.TabIndex = 2;
            this.ButtonMyBooks.Text = "我的图书";
            this.ButtonMyBooks.UseVisualStyleBackColor = true;
            this.ButtonMyBooks.Click += new System.EventHandler(this.ButtonMyBooks_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonHome.Location = new System.Drawing.Point(0, 144);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(213, 52);
            this.ButtonHome.TabIndex = 1;
            this.ButtonHome.Text = "主页";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.UserNameLabel);
            this.panel2.Controls.Add(this.LabelUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 144);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(80, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 7;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UserNameLabel.Location = new System.Drawing.Point(33, 113);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(0, 20);
            this.UserNameLabel.TabIndex = 6;
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LabelUserName.Location = new System.Drawing.Point(3, 82);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(189, 20);
            this.LabelUserName.TabIndex = 1;
            this.LabelUserName.Text = "图书管理系统用户界面";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelForm
            // 
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(213, 0);
            this.PanelForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(804, 577);
            this.PanelForm.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1017, 577);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Button ButtonUserIfo;
        private System.Windows.Forms.Button ButtonMyBooks;
        private System.Windows.Forms.Button ButtonContactAdmin;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label5;
    }
}

