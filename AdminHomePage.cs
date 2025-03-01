using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tharini_Rajapaksha__00238334__Grifindo_Lanka_Toys
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new EmployeeManagement();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new EmployeeLeaveApplication();
            newForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newForm = new EmployeeLeaveHistory();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new RosterManagement();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You, Your Logout From Grifindo Lanka Toys Leave Management System Is Sucessful...!");
            this.Close(); 
        }
    }
}
