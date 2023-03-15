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
    public partial class Que9 : Form
    {
        public Que9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // code that will display fabonaci series
            string str = "";
            int number=Convert.ToInt32(textBox1.Text);
            int a = 0, b = 1, c = 0; //explaination of this line is a is 0, b is 1 and c is 0 why b is 1 because we want to start from 1
            for (int i = 0; i < number; i++)
            {
                c = a + b;
                a = b;
                b = c;
                str += c + " ";
            }
            MessageBox.Show(str);
        }
    }
}
