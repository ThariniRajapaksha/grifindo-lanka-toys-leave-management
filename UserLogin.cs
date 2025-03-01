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
    public partial class UserLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;");

        public UserLogin()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newForm = new UserRegister();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newForm = new AdminLogin();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO UserLogin VALUES(@EmployeeID, @Password)", conn);
                    command.Parameters.AddWithValue("@EmployeeID", textBox1.Text);
                    command.Parameters.AddWithValue("@Password", textBox2.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Login Is Sucessfull");
                    var newForm = new UserHomePage();
                    newForm.Show();
                    this.Hide();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Fill in the blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
