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
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "sti" && textBox2.Text == "1234") 
            {
                frmStudentInfo st = new frmStudentInfo();
                st.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
        }

        private void loginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
