namespace SnowshoesPen
{
    partial class Start_NonPS
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
            this.titleText = new System.Windows.Forms.Label();
            this.subgreet = new System.Windows.Forms.Label();
            this.proceedBttn = new System.Windows.Forms.Button();
            this.jumpRightIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Open Sans", 20.25F);
            this.titleText.ForeColor = System.Drawing.Color.SteelBlue;
            this.titleText.Location = new System.Drawing.Point(252, 102);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(133, 37);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Hi, there!";
            // 
            // subgreet
            // 
            this.subgreet.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.subgreet.ForeColor = System.Drawing.Color.Gray;
            this.subgreet.Location = new System.Drawing.Point(12, 148);
            this.subgreet.Name = "subgreet";
            this.subgreet.Size = new System.Drawing.Size(613, 63);
            this.subgreet.TabIndex = 1;
            this.subgreet.Text = "I don\'t think we\'ve met before, and it doesn\'t look like you are using Snowshoes." +
    " Help me get to know you a little better.";
            this.subgreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proceedBttn
            // 
            this.proceedBttn.BackColor = System.Drawing.Color.SteelBlue;
            this.proceedBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedBttn.Font = new System.Drawing.Font("Open Sans", 10.25F);
            this.proceedBttn.ForeColor = System.Drawing.Color.White;
            this.proceedBttn.Location = new System.Drawing.Point(246, 224);
            this.proceedBttn.Name = "proceedBttn";
            this.proceedBttn.Size = new System.Drawing.Size(144, 35);
            this.proceedBttn.TabIndex = 2;
            this.proceedBttn.Text = "Absolutely, sure.";
            this.proceedBttn.UseVisualStyleBackColor = false;
            // 
            // jumpRightIn
            // 
            this.jumpRightIn.AutoSize = true;
            this.jumpRightIn.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumpRightIn.ForeColor = System.Drawing.Color.SteelBlue;
            this.jumpRightIn.Location = new System.Drawing.Point(155, 398);
            this.jumpRightIn.Name = "jumpRightIn";
            this.jumpRightIn.Size = new System.Drawing.Size(326, 18);
            this.jumpRightIn.TabIndex = 3;
            this.jumpRightIn.Text = "I just want to write something quickly...let\'s do this later.";
            this.jumpRightIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jumpRightIn.Click += new System.EventHandler(this.jumpRightIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(608, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Start_NonPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(637, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jumpRightIn);
            this.Controls.Add(this.proceedBttn);
            this.Controls.Add(this.subgreet);
            this.Controls.Add(this.titleText);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start_NonPS";
            this.Text = "Start_NonPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label subgreet;
        private System.Windows.Forms.Button proceedBttn;
        private System.Windows.Forms.Label jumpRightIn;
        private System.Windows.Forms.Label label1;
    }
}