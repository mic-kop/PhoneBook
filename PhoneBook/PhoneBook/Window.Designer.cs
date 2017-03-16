namespace PhoneBook
{
    partial class Window
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_exit);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "New contact";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_newcontact);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(84, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(215, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_name);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(84, 33);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(215, 22);
            this.textBoxSurname.TabIndex = 2;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBox_name);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(84, 61);
            this.textBoxNumber.MaxLength = 9;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(215, 22);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBox_name);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(81, 86);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 17);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "number";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(21, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(435, 290);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(250, 429);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(206, 29);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(234, 105);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(222, 22);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "search";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Window";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label4;
    }
}