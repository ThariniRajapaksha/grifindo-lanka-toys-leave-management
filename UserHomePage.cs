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
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new ApplyLeave();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new CancelLeaveApplication();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new HistoryOfLeaves();
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
