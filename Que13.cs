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
    public partial class Que13 : Form
    {
        public Que13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] users = { "Fenil", "Rohan", "Ravi" };
            
            foreach (String user in users)
            {
                if (user.Equals(textBox1.Text))
                {
                    MessageBox.Show("Welcome "+user);
                    break;
                }
                else
                {
                    MessageBox.Show("Invalid "+user);
                    break;
                }
            }
        }
    }
}
