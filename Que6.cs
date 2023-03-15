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
    public partial class Que6 : Form
    {
        public Que6()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text);
            //in label show the in label 2 in triagle area
            label2.Text = (0.5 * temp * temp).ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text);
            label2.Text = (temp * temp).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text);
            label2.Text = (3.14 *temp * temp).ToString();
        }
    }
}
