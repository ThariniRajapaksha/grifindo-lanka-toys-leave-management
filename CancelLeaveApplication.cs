using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tharini_Rajapaksha__00238334__Grifindo_Lanka_Toys
{
    public partial class CancelLeaveApplication : Form
    {
        private readonly string connectionString = @"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;";

        public CancelLeaveApplication()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LeaveApplication", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int EmployeeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        Console.WriteLine("Deleting EmployeeID: " + EmployeeID);

                        SqlCommand cmd = new SqlCommand("DELETE FROM LeaveApplication WHERE EmployeeID = @EmployeeID", conn);
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Data not found or could not be deleted.");
                        }

                        LoadUsers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a Data to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new UserHomePage();
            newForm.Show();
            this.Hide();
        }
    }
}
