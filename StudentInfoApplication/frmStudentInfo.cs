using StudentNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
      
        public frmStudentInfo()
        {
            InitializeComponent();
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDstudent.Text == "" || IDstudent.Text == " " || 
                    namelast.Text == "" || namelast.Text == " " ||
                    namefirst.Text == "" || namefirst.Text == " ")
                {
                    MessageBox.Show("Please fill all of the\nrequired student information");
                }
                if (IDstudent.Text.Length < 8)
                {
                    MessageBox.Show("Invalid Student ID.");
                }
                else
                {
                    float studentID = float.Parse(IDstudent.Text);
                    string lastName = namelast.Text;
                    string firstName = namefirst.Text;

                    StudentInfo ID = new StudentInfo(studentID);
                    StudentInfo name = new StudentInfo(lastName, firstName);

                    IDstudentList.Items.Add(ID.getStudentID);
                    namefirstList.Items.Add(name.getFirstName);
                    namelastList.Items.Add(name.getLastName);

                    IDstudent.Clear();
                    namelast.Clear();
                    namefirst.Clear();

                }
            }
            catch (FormatException) 
            {
                MessageBox.Show("Invalid Student ID.");
            }

        }
        private void clearList_Click(object sender, EventArgs e)
        {
            if (IDstudentList.Items.Count == 0)
            {
                MessageBox.Show("The lists are already empty!");
            }
            else
            {
                IDstudentList.Items.Clear();
                namelastList.Items.Clear();
                namefirstList.Items.Clear();
            }
        }

        private void frmStudentInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginScreen lg = new loginScreen();
            lg.Show();
            this.Hide();
        }
    }
}
