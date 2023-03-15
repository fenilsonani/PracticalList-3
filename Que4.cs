using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalList_3
{
    public partial class Que4 : Form
    {
        public Que4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] randomlist= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Random random = new Random();
            int index = random.Next(randomlist.Length);
            int value = randomlist[index];
            label1.Text="Generated Number is : "+value.ToString();
            if (value == 9)
            {
                pictureBox1.Image = Image.FromFile("F:/Chrome/img1.jpg");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
    }
}
