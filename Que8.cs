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
    public partial class Que8 : Form
    {
        double result;
        public Que8()
        {
            InitializeComponent();
        }

        private void Que8_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("USD");
            comboBox1.Items.Add("INR");
            comboBox1.Items.Add("YEN");
            comboBox2.Items.Add("USD");
            comboBox2.Items.Add("INR");
            comboBox2.Items.Add("YEN");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // code that will convert currency and display in label2
            int amount = Convert.ToInt32(textBox1.Text);
            ConvertCurrency(amount);
            label2.Text = result.ToString();

           
        }

        private void ConvertCurrency(double amount)
        {
            //very short code for currency conversion
            if (comboBox1.Text == "USD" && comboBox2.Text == "INR")
            {
                result = amount * 70;
            }
            else if (comboBox1.Text == "USD" && comboBox2.Text == "YEN")
            {
                result = amount * 110;
            }
            else if (comboBox1.Text == "INR" && comboBox2.Text == "USD")
            {
                result = amount / 70;
            }
            else if (comboBox1.Text == "INR" && comboBox2.Text == "YEN")
            {
                result = amount * 1.5;
            }
            else if (comboBox1.Text == "YEN" && comboBox2.Text == "USD")
            {
                result = amount / 110;
            }
            else if (comboBox1.Text == "YEN" && comboBox2.Text == "INR")
            {
                result = amount / 1.5;
            }
            else
            {
                result = amount;
            }
            label2.Text = result.ToString();
        }
    }
}
