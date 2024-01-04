namespace LibrarySystemVersion2
{
    partial class AdminUser
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
            this.ButtonModifyUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonDeleteUser = new System.Windows.Forms.Button();
            this.ButtonQuery = new System.Windows.Forms.Button();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonModifyUser
            // 
            this.ButtonModifyUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ButtonModifyUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonModifyUser.FlatAppearance.BorderSize = 0;
            this.ButtonModifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonModifyUser.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonModifyUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonModifyUser.Location = new System.Drawing.Point(0, 0);
            this.ButtonModifyUser.Name = "ButtonModifyUser";
            this.ButtonModifyUser.Size = new System.Drawing.Size(282, 100);
            this.ButtonModifyUser.TabIndex = 3;
            this.ButtonModifyUser.Text = "修改用户权限";
            this.ButtonModifyUser.UseVisualStyleBackColor = false;
            this.ButtonModifyUser.Click += new System.EventHandler(this.ButtonModifyUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonDeleteUser);
            this.panel1.Controls.Add(this.ButtonQuery);
            this.panel1.Controls.Add(this.ButtonModifyUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 100);
            this.panel1.TabIndex = 5;
            // 
            // ButtonDeleteUser
            // 
            this.ButtonDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ButtonDeleteUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonDeleteUser.FlatAppearance.BorderSize = 0;
            this.ButtonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteUser.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonDeleteUser.Location = new System.Drawing.Point(564, 0);
            this.ButtonDeleteUser.Name = "ButtonDeleteUser";
            this.ButtonDeleteUser.Size = new System.Drawing.Size(282, 100);
            this.ButtonDeleteUser.TabIndex = 6;
            this.ButtonDeleteUser.Text = "删除用户";
            this.ButtonDeleteUser.UseVisualStyleBackColor = false;
            this.ButtonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // ButtonQuery
            // 
            this.ButtonQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ButtonQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonQuery.FlatAppearance.BorderSize = 0;
            this.ButtonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuery.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonQuery.Location = new System.Drawing.Point(282, 0);
            this.ButtonQuery.Name = "ButtonQuery";
            this.ButtonQuery.Size = new System.Drawing.Size(282, 100);
            this.ButtonQuery.TabIndex = 4;
            this.ButtonQuery.Text = "查询用户";
            this.ButtonQuery.UseVisualStyleBackColor = false;
            this.ButtonQuery.Click += new System.EventHandler(this.ButtonQuery_Click);
            // 
            // PanelForm
            // 
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(0, 100);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(847, 430);
            this.PanelForm.TabIndex = 6;
            // 
            // AdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(847, 530);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUser";
            this.Text = "AdminUser";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonModifyUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonDeleteUser;
        private System.Windows.Forms.Button ButtonQuery;
        private System.Windows.Forms.Panel PanelForm;
    }
}