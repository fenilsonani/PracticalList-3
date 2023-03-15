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
    public partial class Que3 : Form
    {
        public Que3()
        {
            InitializeComponent();
        }

        //create click event for button that add text in panel

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text=(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text)).ToString();
        }
    }
}
