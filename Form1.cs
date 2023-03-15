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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code that will check plaindrom or not
            string str = textBox1.Text;
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            if (str == rev)
            {
                MessageBox.Show("String is Palindrome");
            }
            else
            {
                MessageBox.Show("String is not Palindrome");
            }
        }
    }
}
