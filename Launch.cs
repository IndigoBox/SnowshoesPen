using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowshoesPen
{
    public partial class Launch : Form
    {
        public Launch()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            o.Show();
            o.BringToFront();
            this.Hide();
        }

        private void Launch_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 5) {
                subgreet.Text = "Let's make this as efficient as possible. You should sleep.";
            }
            else if (DateTime.Now.Hour > 5 && DateTime.Now.Hour < 9)
            {
                subgreet.Text = "Looks like your up early! Let's get started.";
            }
            if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 12)
            {
                subgreet.Text = "Did you get breakfast yet?";
            }
        }
    }
}
