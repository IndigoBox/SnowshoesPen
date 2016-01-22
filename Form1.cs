using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace SnowshoesPen
{
    public partial class Form1 : Form 
    {
        int l1, l2, l3, l4, l5;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {

            if (fileLabel.Visible)
            {

                aboutLabel.ForeColor = Color.DeepSkyBlue;

                fileLabel.Visible = false;
                formatLabel.Visible = false;
                insertLabel.Visible = false;
                layoutLabel.Visible = false;

                //aboutLabel.Left = -9;
                Transition.run(aboutLabel, "Left", -9, new TransitionType_Linear(150));

                Label generateADogeLabelWithNoDogeImgAwwA = new Label();
                generateADogeLabelWithNoDogeImgAwwA.Name = "generateADogeLabelWithNoDogeImgAww";
                generateADogeLabelWithNoDogeImgAwwA.Left = l2;
                generateADogeLabelWithNoDogeImgAwwA.Top = aboutLabel.Top;
                generateADogeLabelWithNoDogeImgAwwA.Height = aboutLabel.Height;
                generateADogeLabelWithNoDogeImgAwwA.Width = this.Width - aboutLabel.Width;
                generateADogeLabelWithNoDogeImgAwwA.ForeColor = Color.DarkGray;
                generateADogeLabelWithNoDogeImgAwwA.BackColor = Color.Transparent;
                generateADogeLabelWithNoDogeImgAwwA.Font = new Font("Roboto", 9);
                generateADogeLabelWithNoDogeImgAwwA.Text = "Project Snowshoes Pen for The Bridge Build. 2015 IndigoBox Studios / Document1204.";
                generateADogeLabelWithNoDogeImgAwwA.TextAlign = ContentAlignment.MiddleLeft;
                generateADogeLabelWithNoDogeImgAwwA.Visible = true;
                this.Controls.Add(generateADogeLabelWithNoDogeImgAwwA);

            }
            else
            {
                aboutLabel.ForeColor = Color.DarkGray;
                fileLabel.Visible = true;
                formatLabel.Visible = true;
                insertLabel.Visible = true;
                layoutLabel.Visible = true;

                Transition.run(aboutLabel, "Left", l5, new TransitionType_Linear(150));
                // aboutLabel.Left = l5;
                this.Controls.Remove(this.Controls.Find("generateADogeLabelWithNoDogeImgAww",false)[0]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l1 = fileLabel.Left;
            l2 = formatLabel.Left;
            l3 = insertLabel.Left;
            l4 = layoutLabel.Left;
            l5 = aboutLabel.Left;
        }

        private void layoutLabel_Click(object sender, EventArgs e)
        {
            if (fileLabel.Visible)
            {

                layoutLabel.ForeColor = Color.DeepSkyBlue;

                fileLabel.Visible = false;
                formatLabel.Visible = false;
                insertLabel.Visible = false;
                aboutLabel.Visible = false;

                //aboutLabel.Left = -9;
                Transition.run(layoutLabel, "Left", -9, new TransitionType_Linear(150));

                
            }
            else
            {
                layoutLabel.ForeColor = Color.DarkGray;
                fileLabel.Visible = true;
                formatLabel.Visible = true;
                insertLabel.Visible = true;
                aboutLabel.Visible = true;

                Transition.run(layoutLabel, "Left", l4, new TransitionType_Linear(150));
                
            }
        }

        private void insertLabel_Click(object sender, EventArgs e)
        {
            if (fileLabel.Visible)
            {

                insertLabel.ForeColor = Color.DeepSkyBlue;

                fileLabel.Visible = false;
                formatLabel.Visible = false;
                layoutLabel.Visible = false;
                aboutLabel.Visible = false;

                //aboutLabel.Left = -9;
                Transition.run(insertLabel, "Left", -9, new TransitionType_Linear(150));


            }
            else
            {
                insertLabel.ForeColor = Color.DarkGray;
                fileLabel.Visible = true;
                formatLabel.Visible = true;
                layoutLabel.Visible = true;
                aboutLabel.Visible = true;

                Transition.run(insertLabel, "Left", l3, new TransitionType_Linear(150));

            }
        }

        private void formatLabel_Click(object sender, EventArgs e)
        {
            if (fileLabel.Visible)
            {

                formatLabel.ForeColor = Color.DeepSkyBlue;

                fileLabel.Visible = false;
                layoutLabel.Visible = false;
                insertLabel.Visible = false;
                aboutLabel.Visible = false;

                //aboutLabel.Left = -9;
                Transition.run(formatLabel, "Left", -9, new TransitionType_Linear(150));


            }
            else
            {
                formatLabel.ForeColor = Color.DarkGray;
                fileLabel.Visible = true;
                layoutLabel.Visible = true;
                insertLabel.Visible = true;
                aboutLabel.Visible = true;

                Transition.run(formatLabel, "Left", l2, new TransitionType_Linear(150));

            }
        }

        private void fileLabel_Click(object sender, EventArgs e)
        {

            if (formatLabel.Visible)
            {
                Transition.run(this, "BackColor", Color.DeepSkyBlue, new TransitionType_EaseInEaseOut(150));
                Transition.run(titleDoc, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(150));
                Transition.run(fileLabel, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(150));

                // fileLabel.ForeColor = Color.White;

                aboutLabel.Visible = false;
                formatLabel.Visible = false;
                insertLabel.Visible = false;
                layoutLabel.Visible = false;

                openFileGen();

                saveFileGen();

                saveAsFileGen();


            }
            else
            {
                Transition.run(this, "BackColor", Color.WhiteSmoke, new TransitionType_EaseInEaseOut(150));
                Transition.run(titleDoc, "ForeColor", Color.DeepSkyBlue, new TransitionType_EaseInEaseOut(150));
                Transition.run(fileLabel, "ForeColor", Color.DarkGray, new TransitionType_EaseInEaseOut(150));

                this.Controls.Remove(this.Controls.Find("openFile", false)[0]);
                this.Controls.Remove(this.Controls.Find("saveFile", false)[0]);
                this.Controls.Remove(this.Controls.Find("saveAsFile", false)[0]);

                aboutLabel.Visible = true;
                formatLabel.Visible = true;
                insertLabel.Visible = true;
                layoutLabel.Visible = true;

            }
        }

        // Prepare for launch

        private void openFileGen()
        {
            Label openFile = new Label();
            openFile.Name = "openFile";
            openFile.Left = 0;
            openFile.Top = fileLabel.Top;
            openFile.Text = "Open";
            openFile.Font = new Font("Roboto Light", 9);
            openFile.ForeColor = Color.Gainsboro;
            openFile.BackColor = Color.Transparent;
            openFile.TextAlign = ContentAlignment.MiddleCenter;
            openFile.Height = fileLabel.Height;
            openFile.Width = 40;
            this.Controls.Add(openFile);

            Transition.run(openFile, "Left", l2, new TransitionType_Linear(200));

            openFile.Click += (sender, args) =>
            {
                OpenFileDialog yepHereWeAreAgain = new OpenFileDialog();
                yepHereWeAreAgain.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (yepHereWeAreAgain.ShowDialog() == DialogResult.OK)
                {
                    if (yepHereWeAreAgain.SafeFileName.Substring(yepHereWeAreAgain.SafeFileName.Length - 4, 4) == ".rtf")
                    {
                        mainText.LoadFile(yepHereWeAreAgain.FileName);
                        titleDoc.Text = yepHereWeAreAgain.SafeFileName.Remove(yepHereWeAreAgain.SafeFileName.Length - 4);
                    }
                    else
                    {
                        mainText.Text = System.IO.File.ReadAllText(yepHereWeAreAgain.FileName);
                    }
                    titleDoc.Text = yepHereWeAreAgain.SafeFileName.Remove(yepHereWeAreAgain.SafeFileName.Length - 4);
                    
                }
            };
        }

        private void saveFileGen()
        {
            Label saveFile = new Label();
            saveFile.Name = "saveFile";
            saveFile.Left = 0;
            saveFile.Top = fileLabel.Top;
            saveFile.Text = "Save";
            saveFile.Font = new Font("Roboto Light", 9);
            saveFile.ForeColor = Color.Gainsboro;
            saveFile.BackColor = Color.Transparent;
            saveFile.TextAlign = ContentAlignment.MiddleCenter;
            saveFile.Height = fileLabel.Height;
            saveFile.Width = 40;
            this.Controls.Add(saveFile);

            Transition.run(saveFile, "Left", l2 + 50, new TransitionType_Linear(200));
        }

        private void saveAsFileGen()
        {
            Label saveAsFile = new Label();
            saveAsFile.Name = "saveAsFile";
            saveAsFile.Left = 0;
            saveAsFile.Top = fileLabel.Top;
            saveAsFile.Text = "Save As...";
            saveAsFile.Font = new Font("Roboto Light", 9);
            saveAsFile.ForeColor = Color.Gainsboro;
            saveAsFile.BackColor = Color.Transparent;
            saveAsFile.TextAlign = ContentAlignment.MiddleCenter;
            saveAsFile.Height = fileLabel.Height;
            saveAsFile.Width = 60;
            this.Controls.Add(saveAsFile);

            Transition.run(saveAsFile, "Left", l2 + 100, new TransitionType_Linear(200));
        }

    }
}
