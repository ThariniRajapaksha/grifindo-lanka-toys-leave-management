using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tharini_Rajapaksha__00238334__Grifindo_Lanka_Toys
{
    public partial class EmployeeLeaveHistory : Form
    {
        string connectionstring = @"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;";

        public EmployeeLeaveHistory()
        {
            InitializeComponent();
            LoadEmployeeIDs();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string selectedEmployeeID = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedEmployeeID))
            {
                MessageBox.Show("Please select an employee ID.");
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM LeaveApplication WHERE EmployeeID = @EmployeeID";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);

                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave applications: " + ex.Message);
            }
        }
        private void LoadEmployeeIDs()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("SELECT DISTINCT EmployeeID FROM LeaveApplication", sqlCon);
                    SqlDataReader sqlDr = sqlCmd.ExecuteReader();

                    comboBox1.Items.Clear();
                    while (sqlDr.Read())
                    {
                        comboBox1.Items.Add(sqlDr["EmployeeID"].ToString());
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee IDs: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new AdminHomePage();
            newForm.Show();
            this.Hide();
        }
    }
}
