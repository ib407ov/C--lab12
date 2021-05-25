using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Resault:    ";
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel3.Text = "";
            toolStripStatusLabel4.Text = "";
        }
      
        private void lenghtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = (double)numericX.Value;
            double y = (double)numericY.Value;
            double x1 = (double)numericUpDown1.Value;
            double y1 = (double)numericUpDown2.Value;

            TVektor2D r = new TVektor2D(x, y, x1, y1);
            toolStripStatusLabel1.Text = "Result(x,y):        ";
            toolStripStatusLabel2.Text = r.lenght()[0].ToString();
            toolStripStatusLabel3.Text = "Result(x1,y1):    ";
            toolStripStatusLabel4.Text = r.lenght()[1].ToString();
        }

        private void normalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = (double)numericX.Value;
            double y = (double)numericY.Value;
            double x1 = (double)numericUpDown1.Value;
            double y1 = (double)numericUpDown2.Value;

            TVektor2D r = new TVektor2D(x, y, x1, y1);
            toolStripStatusLabel1.Text = "Result:    ";
            toolStripStatusLabel2.Text = "X   = " + r.normalizationVektors()[0].ToString() + " Y  = " + r.normalizationVektors()[1].ToString();

            toolStripStatusLabel3.Text = "Result:    ";
            toolStripStatusLabel4.Text = "X1 = " + r.normalizationVektors()[2].ToString() + " Y1 = " + r.normalizationVektors()[3].ToString();
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void lenghtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double x = (double)numericX.Value;
            double y = (double)numericY.Value;
            double x1 = (double)numericUpDown1.Value;
            double y1 = (double)numericUpDown2.Value;
            double z = (double)numericZ.Value;
            double z1 = (double)numericZ1.Value;

            TVektor3D r = new TVektor3D(x, y, x1, y1, z, z1);
            toolStripStatusLabel1.Text = "Result(x,y,z):          ";
            toolStripStatusLabel2.Text = r.lenght3D()[0].ToString();
            toolStripStatusLabel3.Text = "Result(x1,y1,z1):    ";
            toolStripStatusLabel4.Text = r.lenght3D()[1].ToString();
        }
    }
}
