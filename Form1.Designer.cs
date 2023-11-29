namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Gender = new System.Windows.Forms.Label();
            this.PhoneNo = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 9);
            this.label1.MinimumSize = new System.Drawing.Size(150, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Book";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 286);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 747);
            this.panel1.TabIndex = 10;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(649, 400);
            this.Gender.MinimumSize = new System.Drawing.Size(150, 50);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(150, 50);
            this.Gender.TabIndex = 1;
            this.Gender.Text = "Gender";
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNo.Location = new System.Drawing.Point(649, 333);
            this.PhoneNo.MinimumSize = new System.Drawing.Size(150, 50);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(150, 50);
            this.PhoneNo.TabIndex = 2;
            this.PhoneNo.Text = "PhoneNo";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(649, 258);
            this.LastName.MinimumSize = new System.Drawing.Size(150, 50);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(150, 50);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(649, 188);
            this.FirstName.MinimumSize = new System.Drawing.Size(150, 50);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(150, 50);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "FirstName";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(775, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 30);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(775, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 30);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(775, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(319, 30);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(775, 400);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(319, 30);
            this.textBox4.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Teal;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(719, 504);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 42);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Coral;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(857, 504);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(101, 42);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Crimson;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(993, 504);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 42);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.multiply;
            this.button1.Location = new System.Drawing.Point(1152, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1200, 746);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.PhoneNo);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label PhoneNo;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
    }
}

