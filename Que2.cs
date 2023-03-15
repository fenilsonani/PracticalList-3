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
    public partial class Que2 : Form
    {
        public Que2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If Gross salary >= 40000 then 15 % basic salary.
            //2) If Gross salary >= 50000 then 20 % basic salary.
            //3) If Gross salary >= 60000 then 25 % basic salary.
            int totalSalary;
            int salary=Convert.ToInt32(textBox3.Text);
            if(salary>=6000)
            {
                totalSalary = salary + (salary * 25 / 100);
            }
            else
            {
                if (salary >= 5000)
                {
                    totalSalary = salary + (salary * 20 / 100);
                }
                else
                {
                    if (salary >= 4000)
                    {
                        totalSalary = salary + (salary * 15 / 100);
                    }
                    else
                    {
                        totalSalary = salary;
                    }
                }
            }
            MessageBox.Show("Name : " + textBox1.Text + "\nDesignation : " + textBox2.Text + "\nGross Salary : " + textBox3.Text + "\nTotal Salary : " + totalSalary);
        }
    }
}
