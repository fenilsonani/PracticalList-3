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
    public partial class Que11 : Form
    {
        int count;
        public Que11()
        {
            InitializeComponent();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sort the item
            listBox1.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Item: " + count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succssfull Removed");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //move multiple item
            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Remove(item);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // enable the multi selection
                listBox1.SelectionMode = SelectionMode.MultiSimple;
            }
            else
            {
                listBox1.SelectionMode = SelectionMode.One;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Remove(item);
            }
        }
    }
}
