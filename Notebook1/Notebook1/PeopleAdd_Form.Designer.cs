namespace Notebook1
{
    partial class PeopleAdd_Form
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
            this.Name_label = new System.Windows.Forms.Label();
            this.DataBirth_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.TelephoneNumber_label = new System.Windows.Forms.Label();
            this.Work_label = new System.Windows.Forms.Label();
            this.Post_label = new System.Windows.Forms.Label();
            this.FriendsPost_label = new System.Windows.Forms.Label();
            this.Meeting_label = new System.Windows.Forms.Label();
            this.Qualities_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.DataOfBirth_textBox = new System.Windows.Forms.TextBox();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.TelephoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.Work_textBox = new System.Windows.Forms.TextBox();
            this.Post_textBox = new System.Windows.Forms.TextBox();
            this.FriendsPost_textBox = new System.Windows.Forms.TextBox();
            this.Meeting_textBox = new System.Windows.Forms.TextBox();
            this.Qualities_textBox = new System.Windows.Forms.TextBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.ErrorBox_label = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(12, 17);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(43, 13);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Ф.И.О.";
            // 
            // DataBirth_label
            // 
            this.DataBirth_label.AutoSize = true;
            this.DataBirth_label.Location = new System.Drawing.Point(12, 43);
            this.DataBirth_label.Name = "DataBirth_label";
            this.DataBirth_label.Size = new System.Drawing.Size(86, 13);
            this.DataBirth_label.TabIndex = 2;
            this.DataBirth_label.Text = "Дата рождения";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(12, 69);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(38, 13);
            this.Address_label.TabIndex = 3;
            this.Address_label.Text = "Адрес";
            // 
            // TelephoneNumber_label
            // 
            this.TelephoneNumber_label.AutoSize = true;
            this.TelephoneNumber_label.Location = new System.Drawing.Point(12, 95);
            this.TelephoneNumber_label.Name = "TelephoneNumber_label";
            this.TelephoneNumber_label.Size = new System.Drawing.Size(96, 13);
            this.TelephoneNumber_label.TabIndex = 4;
            this.TelephoneNumber_label.Text = "Номер телефона ";
            // 
            // Work_label
            // 
            this.Work_label.AutoSize = true;
            this.Work_label.Location = new System.Drawing.Point(12, 121);
            this.Work_label.Name = "Work_label";
            this.Work_label.Size = new System.Drawing.Size(79, 13);
            this.Work_label.TabIndex = 5;
            this.Work_label.Text = "Место работы";
            // 
            // Post_label
            // 
            this.Post_label.AutoSize = true;
            this.Post_label.Location = new System.Drawing.Point(12, 147);
            this.Post_label.Name = "Post_label";
            this.Post_label.Size = new System.Drawing.Size(65, 13);
            this.Post_label.TabIndex = 6;
            this.Post_label.Text = "Должность";
            // 
            // FriendsPost_label
            // 
            this.FriendsPost_label.AutoSize = true;
            this.FriendsPost_label.Location = new System.Drawing.Point(12, 170);
            this.FriendsPost_label.Name = "FriendsPost_label";
            this.FriendsPost_label.Size = new System.Drawing.Size(125, 26);
            this.FriendsPost_label.TabIndex = 7;
            this.FriendsPost_label.Text = "Должность знакомых, \r\nколлег, родственников";
            // 
            // Meeting_label
            // 
            this.Meeting_label.AutoSize = true;
            this.Meeting_label.Location = new System.Drawing.Point(12, 204);
            this.Meeting_label.Name = "Meeting_label";
            this.Meeting_label.Size = new System.Drawing.Size(119, 13);
            this.Meeting_label.TabIndex = 8;
            this.Meeting_label.Text = "Характер знакомства";
            // 
            // Qualities_label
            // 
            this.Qualities_label.AutoSize = true;
            this.Qualities_label.Location = new System.Drawing.Point(12, 230);
            this.Qualities_label.Name = "Qualities_label";
            this.Qualities_label.Size = new System.Drawing.Size(103, 13);
            this.Qualities_label.TabIndex = 9;
            this.Qualities_label.Text = "Деловые качества";
            this.Qualities_label.Click += new System.EventHandler(this.label10_Click);
            // 
            // Name_textBox
            // 
            this.Name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_textBox.Location = new System.Drawing.Point(151, 14);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(300, 20);
            this.Name_textBox.TabIndex = 10;
            // 
            // DataOfBirth_textBox
            // 
            this.DataOfBirth_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataOfBirth_textBox.Location = new System.Drawing.Point(151, 40);
            this.DataOfBirth_textBox.Name = "DataOfBirth_textBox";
            this.DataOfBirth_textBox.Size = new System.Drawing.Size(300, 20);
            this.DataOfBirth_textBox.TabIndex = 11;
            this.DataOfBirth_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Address_textBox
            // 
            this.Address_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_textBox.Location = new System.Drawing.Point(151, 66);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(300, 20);
            this.Address_textBox.TabIndex = 12;
            // 
            // TelephoneNumber_textBox
            // 
            this.TelephoneNumber_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TelephoneNumber_textBox.Location = new System.Drawing.Point(151, 92);
            this.TelephoneNumber_textBox.Name = "TelephoneNumber_textBox";
            this.TelephoneNumber_textBox.Size = new System.Drawing.Size(300, 20);
            this.TelephoneNumber_textBox.TabIndex = 13;
            // 
            // Work_textBox
            // 
            this.Work_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Work_textBox.Location = new System.Drawing.Point(151, 118);
            this.Work_textBox.Name = "Work_textBox";
            this.Work_textBox.Size = new System.Drawing.Size(300, 20);
            this.Work_textBox.TabIndex = 14;
            // 
            // Post_textBox
            // 
            this.Post_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Post_textBox.Location = new System.Drawing.Point(151, 144);
            this.Post_textBox.Name = "Post_textBox";
            this.Post_textBox.Size = new System.Drawing.Size(300, 20);
            this.Post_textBox.TabIndex = 15;
            this.Post_textBox.TextChanged += new System.EventHandler(this.TeoneNumber_textBox_TextChanged);
            // 
            // FriendsPost_textBox
            // 
            this.FriendsPost_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FriendsPost_textBox.Location = new System.Drawing.Point(151, 173);
            this.FriendsPost_textBox.Name = "FriendsPost_textBox";
            this.FriendsPost_textBox.Size = new System.Drawing.Size(300, 20);
            this.FriendsPost_textBox.TabIndex = 16;
            // 
            // Meeting_textBox
            // 
            this.Meeting_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Meeting_textBox.Location = new System.Drawing.Point(151, 201);
            this.Meeting_textBox.Name = "Meeting_textBox";
            this.Meeting_textBox.Size = new System.Drawing.Size(300, 20);
            this.Meeting_textBox.TabIndex = 17;
            // 
            // Qualities_textBox
            // 
            this.Qualities_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Qualities_textBox.Location = new System.Drawing.Point(151, 227);
            this.Qualities_textBox.Name = "Qualities_textBox";
            this.Qualities_textBox.Size = new System.Drawing.Size(300, 20);
            this.Qualities_textBox.TabIndex = 18;
            // 
            // OK_btn
            // 
            this.OK_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OK_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK_btn.Location = new System.Drawing.Point(0, 0);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(89, 31);
            this.OK_btn.TabIndex = 19;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_btn.Location = new System.Drawing.Point(0, 0);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(87, 31);
            this.Cancel_btn.TabIndex = 20;
            this.Cancel_btn.Text = "Отмена";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cansel_btn_Click);
            // 
            // ErrorBox_label
            // 
            this.ErrorBox_label.AutoSize = true;
            this.ErrorBox_label.Location = new System.Drawing.Point(151, 254);
            this.ErrorBox_label.Name = "ErrorBox_label";
            this.ErrorBox_label.Size = new System.Drawing.Size(0, 13);
            this.ErrorBox_label.TabIndex = 21;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(154, 269);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OK_btn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Cancel_btn);
            this.splitContainer1.Size = new System.Drawing.Size(180, 31);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 22;
            // 
            // PeopleAdd_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ErrorBox_label);
            this.Controls.Add(this.Qualities_textBox);
            this.Controls.Add(this.Meeting_textBox);
            this.Controls.Add(this.FriendsPost_textBox);
            this.Controls.Add(this.Post_textBox);
            this.Controls.Add(this.Work_textBox);
            this.Controls.Add(this.TelephoneNumber_textBox);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.DataOfBirth_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Qualities_label);
            this.Controls.Add(this.Meeting_label);
            this.Controls.Add(this.FriendsPost_label);
            this.Controls.Add(this.Post_label);
            this.Controls.Add(this.Work_label);
            this.Controls.Add(this.TelephoneNumber_label);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.DataBirth_label);
            this.Controls.Add(this.Name_label);
            this.Name = "PeopleAdd_Form";
            this.Text = "Добавление данных";
            this.Load += new System.EventHandler(this.PeopleAdd_Form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label DataBirth_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label TelephoneNumber_label;
        private System.Windows.Forms.Label Work_label;
        private System.Windows.Forms.Label Post_label;
        private System.Windows.Forms.Label FriendsPost_label;
        private System.Windows.Forms.Label Meeting_label;
        private System.Windows.Forms.Label Qualities_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox DataOfBirth_textBox;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.TextBox TelephoneNumber_textBox;
        private System.Windows.Forms.TextBox Work_textBox;
        private System.Windows.Forms.TextBox Post_textBox;
        private System.Windows.Forms.TextBox FriendsPost_textBox;
        private System.Windows.Forms.TextBox Meeting_textBox;
        private System.Windows.Forms.TextBox Qualities_textBox;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label ErrorBox_label;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}