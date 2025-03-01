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
    public partial class EmployeeManagement : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;");

        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new UserHomePage();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) &&
                    !string.IsNullOrEmpty(textBox2.Text) &&
                    !string.IsNullOrEmpty(dateTimePicker1.Text) &&
                    !string.IsNullOrEmpty(comboBox1.Text) &&
                    !string.IsNullOrEmpty(textBox3.Text) &&
                    !string.IsNullOrEmpty(textBox4.Text) &&
                    !string.IsNullOrEmpty(textBox5.Text) &&
                    !string.IsNullOrEmpty(textBox6.Text) &&
                    !string.IsNullOrEmpty(textBox7.Text) &&
                    !string.IsNullOrEmpty(textBox8.Text) &&
                    !string.IsNullOrEmpty(textBox9.Text) &&
                    !string.IsNullOrEmpty(dateTimePicker2.Text) &&
                    !string.IsNullOrEmpty(comboBox2.Text) &&
                    numericUpDown1.Value != 0 &&
                    numericUpDown2.Value != 0 &&
                    numericUpDown3.Value != 0)
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO EmployeeManagement (FirstName, LastName, DateOfBirth, Gender, Email, Phone, Address, EmployeeID, NIC, Position, Department, StartDate, EmployeementType, Annual, Casual, Short) VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Email, @Phone, @Address, @EmployeeID, @NIC, @Position, @Department, @StartDate, @EmployeementType, @Annual, @Casual, @Short)", conn);

                    command.Parameters.AddWithValue("@FirstName", textBox1.Text);  
                    command.Parameters.AddWithValue("@LastName", textBox2.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);  
                    command.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    command.Parameters.AddWithValue("@Email", textBox3.Text);
                    command.Parameters.AddWithValue("@Phone", textBox4.Text);
                    command.Parameters.AddWithValue("@Address", textBox5.Text);
                    command.Parameters.AddWithValue("@EmployeeID", textBox6.Text);
                    command.Parameters.AddWithValue("@NIC", textBox7.Text);
                    command.Parameters.AddWithValue("@Position", textBox8.Text);
                    command.Parameters.AddWithValue("@Department", textBox9.Text);
                    command.Parameters.AddWithValue("@StartDate", dateTimePicker2.Value);  
                    command.Parameters.AddWithValue("@EmployeementType", comboBox2.Text);  
                    command.Parameters.AddWithValue("@Annual", numericUpDown1.Value);  
                    command.Parameters.AddWithValue("@Casual", numericUpDown2.Value); 
                    command.Parameters.AddWithValue("@Short", numericUpDown3.Value);  

                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Application successfully submitted.");

                    
                    var newForm = new AdminHomePage();
                    newForm.Show();
                    this.Hide();

                    
                    textBox1.Text = "";
                    textBox2.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    comboBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    dateTimePicker2.Value = DateTime.Now;
                    comboBox2.Text = "";
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                    numericUpDown3.Value = 0;
                }
                else
                {
                    
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
