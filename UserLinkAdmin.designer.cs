namespace LibrarySystemVersion2
{
    partial class UserLinkAdmin
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
            this.BtnSent = new System.Windows.Forms.Button();
            this.UserToAdminThink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(65, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "请输入您想对管理员说的话：";
            // 
            // BtnSent
            // 
            this.BtnSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSent.Location = new System.Drawing.Point(956, 714);
            this.BtnSent.Name = "BtnSent";
            this.BtnSent.Size = new System.Drawing.Size(152, 69);
            this.BtnSent.TabIndex = 10;
            this.BtnSent.Text = "发送";
            this.BtnSent.UseVisualStyleBackColor = true;
            this.BtnSent.Click += new System.EventHandler(this.BtnSent_Click);
            // 
            // UserToAdminThink
            // 
            this.UserToAdminThink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UserToAdminThink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserToAdminThink.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserToAdminThink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UserToAdminThink.Location = new System.Drawing.Point(69, 378);
            this.UserToAdminThink.Multiline = true;
            this.UserToAdminThink.Name = "UserToAdminThink";
            this.UserToAdminThink.Size = new System.Drawing.Size(778, 405);
            this.UserToAdminThink.TabIndex = 9;
            this.UserToAdminThink.Text = "在此处输入您的想法";
            this.UserToAdminThink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 22.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(418, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "联系管理员";
            // 
            // UserLinkAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1207, 923);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSent);
            this.Controls.Add(this.UserToAdminThink);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLinkAdmin";
            this.Text = "UserLinkAdmin";
            this.Load += new System.EventHandler(this.UserLinkAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSent;
        private System.Windows.Forms.TextBox UserToAdminThink;
        private System.Windows.Forms.Label label1;
    }
}