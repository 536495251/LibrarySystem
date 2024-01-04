namespace LibrarySystemVersion2
{
    partial class AdminBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonQuery = new System.Windows.Forms.Button();
            this.ButtonAlter = new System.Windows.Forms.Button();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.AdminBookPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.ButtonQuery);
            this.panel1.Controls.Add(this.ButtonAlter);
            this.panel1.Controls.Add(this.ButtonDel);
            this.panel1.Controls.Add(this.ButtonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 160);
            this.panel1.TabIndex = 0;
            // 
            // ButtonQuery
            // 
            this.ButtonQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonQuery.FlatAppearance.BorderSize = 0;
            this.ButtonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuery.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonQuery.Location = new System.Drawing.Point(948, 0);
            this.ButtonQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonQuery.Name = "ButtonQuery";
            this.ButtonQuery.Size = new System.Drawing.Size(316, 160);
            this.ButtonQuery.TabIndex = 5;
            this.ButtonQuery.Text = "查询图书";
            this.ButtonQuery.UseVisualStyleBackColor = true;
            this.ButtonQuery.Click += new System.EventHandler(this.ButtonQuery_Click_1);
            // 
            // ButtonAlter
            // 
            this.ButtonAlter.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAlter.FlatAppearance.BorderSize = 0;
            this.ButtonAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAlter.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAlter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonAlter.Location = new System.Drawing.Point(632, 0);
            this.ButtonAlter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAlter.Name = "ButtonAlter";
            this.ButtonAlter.Size = new System.Drawing.Size(316, 160);
            this.ButtonAlter.TabIndex = 4;
            this.ButtonAlter.Text = "修改图书";
            this.ButtonAlter.UseVisualStyleBackColor = true;
            this.ButtonAlter.Click += new System.EventHandler(this.ButtonAlter_Click);
            // 
            // ButtonDel
            // 
            this.ButtonDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonDel.FlatAppearance.BorderSize = 0;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonDel.Location = new System.Drawing.Point(316, 0);
            this.ButtonDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(316, 160);
            this.ButtonDel.TabIndex = 3;
            this.ButtonDel.Text = "下架图书";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonAdd.Location = new System.Drawing.Point(0, 0);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(316, 160);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "添加图书";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // AdminBookPanel
            // 
            this.AdminBookPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminBookPanel.Location = new System.Drawing.Point(0, 160);
            this.AdminBookPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminBookPanel.Name = "AdminBookPanel";
            this.AdminBookPanel.Size = new System.Drawing.Size(1270, 688);
            this.AdminBookPanel.TabIndex = 1;
            this.AdminBookPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminBookPanel_Paint);
            // 
            // AdminBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1270, 848);
            this.Controls.Add(this.AdminBookPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminBook";
            this.Text = "AdminBook";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonQuery;
        private System.Windows.Forms.Button ButtonAlter;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Panel AdminBookPanel;
    }
}