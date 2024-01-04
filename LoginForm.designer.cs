namespace LibrarySystemVersion2
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TextBoxUserAccount = new System.Windows.Forms.TextBox();
            this.TextBoxUserPassword = new System.Windows.Forms.TextBox();
            this.RadioButtonUser = new System.Windows.Forms.RadioButton();
            this.RadioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.ButtonSignin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "账  户:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(34, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "密  码:";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonLogin.Location = new System.Drawing.Point(38, 363);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(124, 65);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "登  录";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TextBoxUserAccount
            // 
            this.TextBoxUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TextBoxUserAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.TextBoxUserAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TextBoxUserAccount.Location = new System.Drawing.Point(127, 96);
            this.TextBoxUserAccount.Name = "TextBoxUserAccount";
            this.TextBoxUserAccount.Size = new System.Drawing.Size(243, 27);
            this.TextBoxUserAccount.TabIndex = 5;
            // 
            // TextBoxUserPassword
            // 
            this.TextBoxUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TextBoxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.TextBoxUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TextBoxUserPassword.Location = new System.Drawing.Point(127, 184);
            this.TextBoxUserPassword.Name = "TextBoxUserPassword";
            this.TextBoxUserPassword.Size = new System.Drawing.Size(243, 27);
            this.TextBoxUserPassword.TabIndex = 6;
            this.TextBoxUserPassword.UseSystemPasswordChar = true;
            // 
            // RadioButtonUser
            // 
            this.RadioButtonUser.AutoSize = true;
            this.RadioButtonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.RadioButtonUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RadioButtonUser.Location = new System.Drawing.Point(233, 290);
            this.RadioButtonUser.Name = "RadioButtonUser";
            this.RadioButtonUser.Size = new System.Drawing.Size(78, 24);
            this.RadioButtonUser.TabIndex = 7;
            this.RadioButtonUser.TabStop = true;
            this.RadioButtonUser.Text = "用  户";
            this.RadioButtonUser.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAdmin
            // 
            this.RadioButtonAdmin.AutoSize = true;
            this.RadioButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.RadioButtonAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RadioButtonAdmin.Location = new System.Drawing.Point(38, 290);
            this.RadioButtonAdmin.Name = "RadioButtonAdmin";
            this.RadioButtonAdmin.Size = new System.Drawing.Size(96, 24);
            this.RadioButtonAdmin.TabIndex = 8;
            this.RadioButtonAdmin.TabStop = true;
            this.RadioButtonAdmin.Text = "管 理 员";
            this.RadioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // ButtonSignin
            // 
            this.ButtonSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonSignin.FlatAppearance.BorderSize = 0;
            this.ButtonSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtonSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonSignin.Location = new System.Drawing.Point(233, 363);
            this.ButtonSignin.Name = "ButtonSignin";
            this.ButtonSignin.Size = new System.Drawing.Size(124, 65);
            this.ButtonSignin.TabIndex = 9;
            this.ButtonSignin.Text = "注  册";
            this.ButtonSignin.UseVisualStyleBackColor = false;
            this.ButtonSignin.Click += new System.EventHandler(this.ButtonSignin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "南昌大学科技学院图书管理系统";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(392, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonSignin);
            this.Controls.Add(this.RadioButtonAdmin);
            this.Controls.Add(this.RadioButtonUser);
            this.Controls.Add(this.TextBoxUserPassword);
            this.Controls.Add(this.TextBoxUserAccount);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox TextBoxUserAccount;
        private System.Windows.Forms.TextBox TextBoxUserPassword;
        private System.Windows.Forms.RadioButton RadioButtonUser;
        private System.Windows.Forms.RadioButton RadioButtonAdmin;
        private System.Windows.Forms.Button ButtonSignin;
        private System.Windows.Forms.Label label3;
    }
}