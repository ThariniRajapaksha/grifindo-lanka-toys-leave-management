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
    public partial class EmployeeLeaveApplication : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;");

        public EmployeeLeaveApplication()
        {
            InitializeComponent();
            LoadLeaveApplications();
        }

        private void LoadLeaveApplications()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;"))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT EmployeeID, LeaveType, StartDate, EndDate, Status FROM HistoryOfLeave", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found.");
                    }

                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int EmployeeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value);
                UpdateLeaveApplicationStatus(EmployeeID, "Approved");
            }
            else
            {
                MessageBox.Show("Please select a leave application to approve.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int EmployeeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value);
                UpdateLeaveApplicationStatus(EmployeeID, "Rejected");
            }
            else
            {
                MessageBox.Show("Please select a leave application to reject.");
            }
        }
        private void UpdateLeaveApplicationStatus(int EmployeeID, string status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;"))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE HistoryOfLeave SET Status = @Status WHERE EmployeeID = @EmployeeID", conn);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    command.ExecuteNonQuery();
                    conn.Close();

                    LoadLeaveApplications();

                    MessageBox.Show("Leave application status updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new AdminLogin();
            newForm.Show();
            this.Hide();
        }
    }
}
