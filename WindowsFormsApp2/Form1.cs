using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        String[] imgList = new String[]
                           {"0.jpg", "1.jpg"};
        int index = 0;
        public Form1()
            
        {
            InitializeComponent();
            pictureBox1.Load("../../../pictures/" + imgList[0]);
            pictureBox2.Load("../../../../../../pictures/" + imgList[1]);
            pictureBox3.Load("../../../../../../pictures/" + imgList[2]);
        }
    }
}
