namespace Notebook1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOfBirth_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelephoneNumber_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FriendsPost_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meeting_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualities_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Coulmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AddPeople_button = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.ClearAll_button = new System.Windows.Forms.Button();
            this.ClearSelect_button = new System.Windows.Forms.Button();
            this.Sort_comboBox = new System.Windows.Forms.ComboBox();
            this.Sort_button = new System.Windows.Forms.Button();
            this.Find_textBox = new System.Windows.Forms.TextBox();
            this.Find_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 412);
            this.splitContainer1.SplitterDistance = 813;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_column,
            this.DataOfBirth_Column,
            this.Address_Column,
            this.TelephoneNumber_Column,
            this.Work_Column,
            this.Post_Column,
            this.FriendsPost_Column,
            this.Meeting_Column,
            this.Qualities_Column,
            this.Date_Coulmn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name_column
            // 
            this.Name_column.HeaderText = "Ф.И.О.";
            this.Name_column.Name = "Name_column";
            // 
            // DataOfBirth_Column
            // 
            this.DataOfBirth_Column.HeaderText = "Дата рождения";
            this.DataOfBirth_Column.Name = "DataOfBirth_Column";
            // 
            // Address_Column
            // 
            this.Address_Column.HeaderText = "Адрес";
            this.Address_Column.Name = "Address_Column";
            // 
            // TelephoneNumber_Column
            // 
            this.TelephoneNumber_Column.HeaderText = "Номер телефона";
            this.TelephoneNumber_Column.Name = "TelephoneNumber_Column";
            // 
            // Work_Column
            // 
            this.Work_Column.HeaderText = "Место работы";
            this.Work_Column.Name = "Work_Column";
            // 
            // Post_Column
            // 
            this.Post_Column.HeaderText = "Должность";
            this.Post_Column.Name = "Post_Column";
            // 
            // FriendsPost_Column
            // 
            this.FriendsPost_Column.HeaderText = "Должность знакомых, коллег, родственников";
            this.FriendsPost_Column.Name = "FriendsPost_Column";
            // 
            // Meeting_Column
            // 
            this.Meeting_Column.HeaderText = "Характер знакомства";
            this.Meeting_Column.Name = "Meeting_Column";
            // 
            // Qualities_Column
            // 
            this.Qualities_Column.HeaderText = "Деловые качества";
            this.Qualities_Column.Name = "Qualities_Column";
            // 
            // Date_Coulmn
            // 
            this.Date_Coulmn.HeaderText = "Date";
            this.Date_Coulmn.Name = "Date_Coulmn";
            this.Date_Coulmn.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(169, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Закрыть";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "Справка";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.AddPeople_button);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(211, 412);
            this.splitContainer2.SplitterDistance = 39;
            this.splitContainer2.TabIndex = 0;
            // 
            // AddPeople_button
            // 
            this.AddPeople_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPeople_button.Location = new System.Drawing.Point(0, 0);
            this.AddPeople_button.Name = "AddPeople_button";
            this.AddPeople_button.Size = new System.Drawing.Size(211, 39);
            this.AddPeople_button.TabIndex = 0;
            this.AddPeople_button.Text = "Добавить";
            this.AddPeople_button.UseVisualStyleBackColor = true;
            this.AddPeople_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Sort_comboBox);
            this.splitContainer3.Panel2.Controls.Add(this.Sort_button);
            this.splitContainer3.Panel2.Controls.Add(this.Find_textBox);
            this.splitContainer3.Panel2.Controls.Add(this.Find_button);
            this.splitContainer3.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel2_Paint);
            this.splitContainer3.Size = new System.Drawing.Size(211, 369);
            this.splitContainer3.SplitterDistance = 39;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.ClearAll_button);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.ClearSelect_button);
            this.splitContainer4.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer4_Panel2_Paint);
            this.splitContainer4.Size = new System.Drawing.Size(211, 39);
            this.splitContainer4.SplitterDistance = 100;
            this.splitContainer4.TabIndex = 4;
            // 
            // ClearAll_button
            // 
            this.ClearAll_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearAll_button.Location = new System.Drawing.Point(0, 0);
            this.ClearAll_button.Name = "ClearAll_button";
            this.ClearAll_button.Size = new System.Drawing.Size(100, 39);
            this.ClearAll_button.TabIndex = 2;
            this.ClearAll_button.Text = "Удалить все";
            this.ClearAll_button.UseVisualStyleBackColor = true;
            this.ClearAll_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearSelect_button
            // 
            this.ClearSelect_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearSelect_button.Location = new System.Drawing.Point(0, 0);
            this.ClearSelect_button.Name = "ClearSelect_button";
            this.ClearSelect_button.Size = new System.Drawing.Size(107, 39);
            this.ClearSelect_button.TabIndex = 3;
            this.ClearSelect_button.Text = "Удалить";
            this.ClearSelect_button.UseVisualStyleBackColor = true;
            this.ClearSelect_button.Click += new System.EventHandler(this.ClearSelect_button_Click);
            // 
            // Sort_comboBox
            // 
            this.Sort_comboBox.FormattingEnabled = true;
            this.Sort_comboBox.Items.AddRange(new object[] {
            "Ф.И.О.",
            "Дата рождения",
            "Адрес",
            "Номер телефона",
            "Место работы",
            "Должность",
            "Должность знакомых",
            "Характер знакомства",
            "Деловые качества",
            "Дата последней корректировки"});
            this.Sort_comboBox.Location = new System.Drawing.Point(25, 112);
            this.Sort_comboBox.Name = "Sort_comboBox";
            this.Sort_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Sort_comboBox.TabIndex = 4;
            // 
            // Sort_button
            // 
            this.Sort_button.Location = new System.Drawing.Point(4, 77);
            this.Sort_button.Name = "Sort_button";
            this.Sort_button.Size = new System.Drawing.Size(83, 23);
            this.Sort_button.TabIndex = 2;
            this.Sort_button.Text = "Сортировать";
            this.Sort_button.UseVisualStyleBackColor = true;
            this.Sort_button.Click += new System.EventHandler(this.Sort_button_Click);
            // 
            // Find_textBox
            // 
            this.Find_textBox.Location = new System.Drawing.Point(32, 46);
            this.Find_textBox.Name = "Find_textBox";
            this.Find_textBox.Size = new System.Drawing.Size(100, 20);
            this.Find_textBox.TabIndex = 1;
            // 
            // Find_button
            // 
            this.Find_button.Location = new System.Drawing.Point(3, 3);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(75, 23);
            this.Find_button.TabIndex = 0;
            this.Find_button.Text = "Поиск";
            this.Find_button.UseVisualStyleBackColor = true;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 412);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button AddPeople_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearSelect_button;
        private System.Windows.Forms.Button ClearAll_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.TextBox Find_textBox;
        private System.Windows.Forms.Button Sort_button;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ComboBox Sort_comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOfBirth_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephoneNumber_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriendsPost_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meeting_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualities_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Coulmn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

