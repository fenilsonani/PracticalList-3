using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalList_3
{
    public partial class Que5 : Form
    {
        // count the fail subject
        bool countFail = false;
        
        public Que5()
        {
            InitializeComponent();
        }

        private void Que5_Load(object sender, EventArgs e)
        {

        }

        String assignGrade(int marks)
        {
              // Percentage Class
               // 0 to 34 Fail
               // 35 to 59 Second
               // 60 to 74 First
               // 75 and above Distinction
               if (marks >= 0 && marks <= 34)
                {
                        return "Fail";
                }
                else if (marks >= 35 && marks <= 59)
                {
                     return "Second";
                }
                else if (marks >= 60 && marks <= 74)
                {
                     return "First";
                }
                else if (marks >= 75 && marks <= 100)
                {
                     return "Distinction";
                }
                else
                {
                     return "Invalid Marks";
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int marks = Convert.ToInt32(textBox1.Text);
            String grade = assignGrade(marks);
            int marks2= Convert.ToInt32(textBox2.Text);
            String grade2 = assignGrade(marks2);
            int marks3= Convert.ToInt32(textBox3.Text);
            String grade3 = assignGrade(marks3);
            if(grade.Equals("Fail") || grade2.Equals("Fail") || grade3.Equals("Fail"))
            {
                countFail = true;
            }
            MessageBox.Show("First Subject Marks Is " + marks + " and Grade is " + grade + "\n Second Subject Marks Is " + marks2 + " and Grade is " + grade2 + "\n Third Subject Marks Is " + marks3 + " and Grade is " + grade3 + "\n You Are Fail In " + countFail + " Subject");

        }
    }
}
