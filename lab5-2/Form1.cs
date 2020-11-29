using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Cone cone = new Cone();
            Result.Text = cone.Volume().ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cone cone = new Cone();
            Result.Text = cone.Area().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frustum frustum = new Frustum();
            Result.Text = frustum.Area().ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
