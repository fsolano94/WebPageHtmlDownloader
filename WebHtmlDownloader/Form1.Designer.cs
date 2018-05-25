namespace WebHtmlDownloader
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlButton = new System.Windows.Forms.Button();
            this.GetContentButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ContentTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(253, 21);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(276, 20);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = "Enter Url here";
            // 
            // urlButton
            // 
            this.urlButton.Location = new System.Drawing.Point(160, 18);
            this.urlButton.Name = "urlButton";
            this.urlButton.Size = new System.Drawing.Size(75, 23);
            this.urlButton.TabIndex = 1;
            this.urlButton.Text = "url";
            this.urlButton.UseVisualStyleBackColor = true;
            // 
            // GetContentButton
            // 
            this.GetContentButton.Location = new System.Drawing.Point(598, 78);
            this.GetContentButton.Name = "GetContentButton";
            this.GetContentButton.Size = new System.Drawing.Size(75, 23);
            this.GetContentButton.TabIndex = 3;
            this.GetContentButton.Text = "Get Content";
            this.GetContentButton.UseVisualStyleBackColor = true;
            this.GetContentButton.Click += new System.EventHandler(this.GetContentButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(598, 305);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(253, 78);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(276, 250);
            this.ContentTextBox.TabIndex = 5;
            this.ContentTextBox.Text = "Content";
            this.ContentTextBox.TextChanged += new System.EventHandler(this.ContentTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 516);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GetContentButton);
            this.Controls.Add(this.urlButton);
            this.Controls.Add(this.urlTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button urlButton;
        private System.Windows.Forms.Button GetContentButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RichTextBox ContentTextBox;
    }
}

