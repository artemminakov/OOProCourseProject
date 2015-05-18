namespace Notebook1
{
    partial class BirthForm
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
            this.OK_button = new System.Windows.Forms.Button();
            this.OK_label = new System.Windows.Forms.Label();
            this.Birth_label = new System.Windows.Forms.TextBox();
            this.buttonNo = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            this.OK_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK_button.Location = new System.Drawing.Point(0, 0);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 2;
            this.OK_button.Text = "Да";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // OK_label
            // 
            this.OK_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OK_label.AutoSize = true;
            this.OK_label.Location = new System.Drawing.Point(12, 145);
            this.OK_label.Name = "OK_label";
            this.OK_label.Size = new System.Drawing.Size(142, 13);
            this.OK_label.TabIndex = 3;
            this.OK_label.Text = "Отправить поздравления?";
            // 
            // Birth_label
            // 
            this.Birth_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Birth_label.Location = new System.Drawing.Point(0, 0);
            this.Birth_label.Multiline = true;
            this.Birth_label.Name = "Birth_label";
            this.Birth_label.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Birth_label.Size = new System.Drawing.Size(234, 142);
            this.Birth_label.TabIndex = 4;
            // 
            // buttonNo
            // 
            this.buttonNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNo.Location = new System.Drawing.Point(0, 0);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 5;
            this.buttonNo.Text = "Нет";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(36, 177);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OK_button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonNo);
            this.splitContainer1.Size = new System.Drawing.Size(154, 23);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 6;
            // 
            // BirthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 212);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Birth_label);
            this.Controls.Add(this.OK_label);
            this.Name = "BirthForm";
            this.Text = "День рождения";
            this.Load += new System.EventHandler(this.BirthForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label OK_label;
        private System.Windows.Forms.TextBox Birth_label;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}