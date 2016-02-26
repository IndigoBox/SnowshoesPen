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
    public partial class Start_NonPS : Form
    {
        public Start_NonPS()
        {
            InitializeComponent();
        }

        private void jumpRightIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 j = new Form1();
            j.Show();
            j.BringToFront();
        }
    }
}
