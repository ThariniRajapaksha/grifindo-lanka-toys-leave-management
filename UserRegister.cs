using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tharini_Rajapaksha__00238334__Grifindo_Lanka_Toys
{
    public partial class UserRegister : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;");

        public UserRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newForm = new UserLogin();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO User_Register VALUES(@Name, @Contact, @EmployeeID, @Password)", conn);
                    command.Parameters.AddWithValue("@Name", textBox1.Text);
                    command.Parameters.AddWithValue("@Contact", textBox2.Text);
                    command.Parameters.AddWithValue("@EmployeeID", textBox3.Text);
                    command.Parameters.AddWithValue("@Password", textBox4.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registration Is Sucessfull");
                    var newForm = new UserLogin();
                    newForm.Show();
                    this.Hide();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("Fill In the Blanks...!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
