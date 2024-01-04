namespace LibrarySystemVersion2
{
    partial class AdminBookQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxBookQuery = new System.Windows.Forms.TextBox();
            this.BtnBookQuery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBookQuery
            // 
            this.textBoxBookQuery.Location = new System.Drawing.Point(894, 43);
            this.textBoxBookQuery.Name = "textBoxBookQuery";
            this.textBoxBookQuery.Size = new System.Drawing.Size(215, 35);
            this.textBoxBookQuery.TabIndex = 0;
            this.textBoxBookQuery.Text = "模糊查询书名";
            this.textBoxBookQuery.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBookQuery_MouseClick);
            this.textBoxBookQuery.TextChanged += new System.EventHandler(this.textBoxBookQuery_TextChanged);
            // 
            // BtnBookQuery
            // 
            this.BtnBookQuery.Location = new System.Drawing.Point(1135, 37);
            this.BtnBookQuery.Name = "BtnBookQuery";
            this.BtnBookQuery.Size = new System.Drawing.Size(123, 41);
            this.BtnBookQuery.TabIndex = 1;
            this.BtnBookQuery.Text = "查询";
            this.BtnBookQuery.UseVisualStyleBackColor = true;
            this.BtnBookQuery.Click += new System.EventHandler(this.BtnBookQuery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1270, 569);
            this.dataGridView1.TabIndex = 2;
            // 
            // AdminBookQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1270, 688);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnBookQuery);
            this.Controls.Add(this.textBoxBookQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminBookQuery";
            this.Text = "AdminBookQuery";
            this.Load += new System.EventHandler(this.AdminBookQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBookQuery;
        private System.Windows.Forms.Button BtnBookQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}