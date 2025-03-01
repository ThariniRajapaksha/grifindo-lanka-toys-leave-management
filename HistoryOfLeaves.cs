using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Tharini_Rajapaksha__00238334__Grifindo_Lanka_Toys
{
    public partial class HistoryOfLeaves : Form
    {
        string connectionstring = @"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;";

        public HistoryOfLeaves()
        {
            InitializeComponent();
            LoadEmployeeIDs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new UserHomePage();
            newForm.Show();
            this.Hide();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.SelectedItem?.ToString(), out int employeeID))
            {
                LoadPendingApplications(employeeID);
            }
            else
            {
                MessageBox.Show("Please select a valid Employee ID.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.SelectedItem?.ToString(), out int employeeID))
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                    {
                        sqlCon.Open();
                        string query = "SELECT * FROM HistoryOfLeave WHERE EmployeeID = @EmployeeID AND Status = 'Pending'";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading leave history: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid Employee ID.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int queNum = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["QueNum"].Value);

                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                    {
                        sqlCon.Open();
                        string query = "DELETE FROM HistoryOfLeave WHERE QueNum = @QueNum";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@QueNum", queNum);
                        sqlCmd.ExecuteNonQuery();

                        if (int.TryParse(comboBox1.SelectedItem?.ToString(), out int selectedEmployeeID))
                        {
                            LoadPendingApplications(selectedEmployeeID);
                        }

                        MessageBox.Show("Leave application deleted successfully.");
                        var newForm = new UserHomePage();
                        newForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting leave application: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a leave application to delete.");
            }
        }

        private void LoadEmployeeIDs()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("SELECT DISTINCT EmployeeID FROM HistoryOfLeave", sqlCon);
                    SqlDataReader sqlDr = sqlCmd.ExecuteReader();

                    comboBox1.Items.Clear();
                    while (sqlDr.Read())
                    {
                        comboBox1.Items.Add(sqlDr["EmployeeID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee IDs: " + ex.Message);
            }
        }

        private void LoadPendingApplications(int employeeID)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionstring))
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM HistoryOfLeave WHERE EmployeeID = @EmployeeID AND Status = 'Pending'";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave history: " + ex.Message);
            }
        }

    }
}
