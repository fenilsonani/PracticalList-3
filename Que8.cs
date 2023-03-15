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
            comboBox1.Items.Add("EURO");
            comboBox1.Items.Add("POUND");
            comboBox2.Items.Add("USD");
            comboBox2.Items.Add("INR");
            comboBox2.Items.Add("YEN");
            comboBox2.Items.Add("EURO");
            comboBox2.Items.Add("POUND");
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
            double exchangeRate;
            if (comboBox1.Text == "USD" && comboBox2.Text == "INR")
            {
                exchangeRate = 70;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "INR" && comboBox2.Text == "USD")
            {
                exchangeRate = 0.014;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "USD" && comboBox2.Text == "YEN")
            {
                exchangeRate = 110;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "YEN" && comboBox2.Text == "USD")
            {
                exchangeRate = 0.009;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "USD" && comboBox2.Text == "EURO")
            {
                exchangeRate = 0.85;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "EURO" && comboBox2.Text == "USD")
            {
                exchangeRate = 1.18;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "USD" && comboBox2.Text == "POUND")
            {
                exchangeRate = 0.75;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "POUND" && comboBox2.Text == "USD")
            {
                exchangeRate = 1.33;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "INR" && comboBox2.Text == "YEN")
            {
                exchangeRate = 1.55;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "YEN" && comboBox2.Text == "INR")
            {
                exchangeRate = 0.64;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "INR" && comboBox2.Text == "EURO")
            {
                exchangeRate = 0.013;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "EURO" && comboBox2.Text == "INR")
            {
                exchangeRate = 76.50;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "INR" && comboBox2.Text == "POUND")
            {
                exchangeRate = 0.011;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "POUND" && comboBox2.Text == "INR")
            {
                exchangeRate = 91.50;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "YEN" && comboBox2.Text == "EURO")
            {
                exchangeRate = 0.008;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "EURO" && comboBox2.Text == "YEN")
            {
                exchangeRate = 121.50;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "YEN" && comboBox2.Text == "POUND")
            {
                exchangeRate = 0.007;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "POUND" && comboBox2.Text == "YEN")
            {
                exchangeRate = 138.50;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "EURO" && comboBox2.Text == "POUND")
            {
                exchangeRate = 0.89;
                result = amount * exchangeRate;
            }
            else if (comboBox1.Text == "POUND" && comboBox2.Text == "EURO")
            {
                exchangeRate = 1.12;
                result = amount * exchangeRate;
            }
            else
            {
                result = amount;
            }
        }
    }
}
