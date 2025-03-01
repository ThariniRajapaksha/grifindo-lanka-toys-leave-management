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
    public partial class ApplyLeave : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;");

        public ApplyLeave()
        {
            InitializeComponent();
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
                    !string.IsNullOrEmpty(textBox3.Text) &&
                    !string.IsNullOrEmpty(textBox4.Text) &&
                    !string.IsNullOrEmpty(comboBox1.Text) &&
                    !string.IsNullOrEmpty(textBox5.Text))
                {
                    conn.Open();

                    
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        
                        SqlCommand command = new SqlCommand("INSERT INTO LeaveApplication (EmployeeID, Name, Contact, Email, LeaveType, StartDate, EndDate, Reason) VALUES (@EmployeeID, @Name, @Contact, @Email, @LeaveType, @StartDate, @EndDate, @Reason); SELECT SCOPE_IDENTITY();", conn, transaction);
                        command.Parameters.AddWithValue("@EmployeeID", textBox1.Text);
                        command.Parameters.AddWithValue("@Name", textBox2.Text);
                        command.Parameters.AddWithValue("@Contact", textBox3.Text);
                        command.Parameters.AddWithValue("@Email", textBox4.Text);
                        command.Parameters.AddWithValue("@LeaveType", comboBox1.Text);
                        command.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value); 
                        command.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);  
                        command.Parameters.AddWithValue("@Reason", textBox5.Text);

                        int applicationID = Convert.ToInt32(command.ExecuteScalar());

                        SqlCommand historyCommand = new SqlCommand("INSERT INTO HistoryOfLeave (EmployeeID, LeaveType, StartDate, EndDate, Status) VALUES (@EmployeeID, @LeaveType, @StartDate, @EndDate, @Status)", conn, transaction);
                        historyCommand.Parameters.AddWithValue("@EmployeeID", textBox1.Text);
                        historyCommand.Parameters.AddWithValue("@LeaveType", comboBox1.Text);
                        historyCommand.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value); 
                        historyCommand.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value);  
                        historyCommand.Parameters.AddWithValue("@Status", "Pending"); 
                        historyCommand.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Application successfully submitted.");

                        var newForm = new UserHomePage();
                        newForm.Show();
                        this.Hide();

                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        comboBox1.Text = "";
                        dateTimePicker1.Value = DateTime.Now; 
                        dateTimePicker2.Value = DateTime.Now; 
                        textBox5.Text = "";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
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
