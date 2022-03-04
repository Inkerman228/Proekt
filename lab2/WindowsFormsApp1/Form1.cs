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
        String[] imglist = new string[]
                {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg","10.jpg" };
        int index = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox2.Load("../../../pictures/" + imglist[0]);
            pictureBox3.Load("../../../pictures/" + imglist[1]);
            pictureBox4.Load("../../../pictures/" + imglist[2]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formVisitors = new FormVisitors();
            formVisitors.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             
                    index = index + 1;
                    if (index+3 > imglist.Length) index = 0;
                    pictureBox2.Load("../../../pictures/" + imglist[index + 0]);
                    pictureBox3.Load("../../../pictures/" + imglist[index + 1]);
                    pictureBox4.Load("../../../pictures/" + imglist[index + 2]);
                    
               
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = index-1;
            if (index < 0) index = imglist.Length-3;
            pictureBox2.Load("../../../pictures/" + imglist[index + 0]);
            pictureBox3.Load("../../../pictures/" + imglist[index + 1]);
            pictureBox4.Load("../../../pictures/" + imglist[index + 2]);
        }
    }
}
