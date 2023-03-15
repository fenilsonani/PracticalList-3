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
    public partial class Que7 : Form
    {
        public Que7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //that will display all selected checkbox
            string str = "";
            if (checkBox1.Checked)
            {
                str += checkBox1.Text + " ";
            }   
            if (checkBox2.Checked)
            {
                str += checkBox2.Text + " ";
            }
            if (checkBox3.Checked)
            {
                str += checkBox3.Text + " ";
            }
            if (checkBox4.Checked)
            {
                str += checkBox4.Text + " ";
            }
            if (checkBox5.Checked)
            {
                str += checkBox5.Text + " ";
            }
            if (checkBox6.Checked)
            {
                str += checkBox6.Text + " ";
            }
            MessageBox.Show(str);
        }
    }
}
