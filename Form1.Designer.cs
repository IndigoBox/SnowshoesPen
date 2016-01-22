namespace SnowshoesPen
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
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.titleDoc = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.insertLabel = new System.Windows.Forms.Label();
            this.layoutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainText.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.Location = new System.Drawing.Point(0, 138);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(1280, 582);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "";
            // 
            // titleDoc
            // 
            this.titleDoc.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleDoc.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.titleDoc.Location = new System.Drawing.Point(128, 0);
            this.titleDoc.Name = "titleDoc";
            this.titleDoc.Size = new System.Drawing.Size(1024, 59);
            this.titleDoc.TabIndex = 2;
            this.titleDoc.Text = "New Pen Document";
            this.titleDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileLabel
            // 
            this.fileLabel.Font = new System.Drawing.Font("Roboto", 9.875F);
            this.fileLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.fileLabel.Location = new System.Drawing.Point(-9, 73);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(253, 50);
            this.fileLabel.TabIndex = 3;
            this.fileLabel.Text = "FILE";
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileLabel.Click += new System.EventHandler(this.fileLabel_Click);
            // 
            // formatLabel
            // 
            this.formatLabel.Font = new System.Drawing.Font("Roboto", 9.875F);
            this.formatLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.formatLabel.Location = new System.Drawing.Point(250, 73);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(253, 50);
            this.formatLabel.TabIndex = 4;
            this.formatLabel.Text = "FORMAT";
            this.formatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.formatLabel.Click += new System.EventHandler(this.formatLabel_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.Font = new System.Drawing.Font("Roboto", 9.875F);
            this.aboutLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.aboutLabel.Location = new System.Drawing.Point(1027, 73);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(253, 50);
            this.aboutLabel.TabIndex = 6;
            this.aboutLabel.Text = "ABOUT";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // insertLabel
            // 
            this.insertLabel.Font = new System.Drawing.Font("Roboto", 9.875F);
            this.insertLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.insertLabel.Location = new System.Drawing.Point(509, 73);
            this.insertLabel.Name = "insertLabel";
            this.insertLabel.Size = new System.Drawing.Size(253, 50);
            this.insertLabel.TabIndex = 5;
            this.insertLabel.Text = "INSERT";
            this.insertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.insertLabel.Click += new System.EventHandler(this.insertLabel_Click);
            // 
            // layoutLabel
            // 
            this.layoutLabel.Font = new System.Drawing.Font("Roboto", 9.875F);
            this.layoutLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.layoutLabel.Location = new System.Drawing.Point(768, 73);
            this.layoutLabel.Name = "layoutLabel";
            this.layoutLabel.Size = new System.Drawing.Size(253, 50);
            this.layoutLabel.TabIndex = 7;
            this.layoutLabel.Text = "LAYOUT";
            this.layoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutLabel.Click += new System.EventHandler(this.layoutLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.layoutLabel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.insertLabel);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.titleDoc);
            this.Controls.Add(this.mainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainText;
        private System.Windows.Forms.Label titleDoc;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label insertLabel;
        private System.Windows.Forms.Label layoutLabel;
    }
}

