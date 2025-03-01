using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tharini_Rajapaksha__00238334__Grifindo_Lanka_Toys
{
    public partial class RosterManagement : Form
    {
        public RosterManagement()
        {
            InitializeComponent();
            LoadEmployeeIDs();
        }

        private void LoadEmployeeIDs()
        {
            string connectionString = @"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT EmployeeID FROM User_Register";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["EmployeeID"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Employee IDs: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an Employee ID.");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=Grifindo; Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO RosterManagement
                                 (EmployeeID, MondayStartTime, MondayEndTime, TuesdayStartTime, TuesdayEndTime, 
                                 WednesdayStartTime, WednesdayEndTime, ThursdayStartTime, ThursdayEndTime, 
                                 FridayStartTime, FridayEndTime, SaturdayStartTime, SaturdayEndTime, 
                                 SundayStartTime, SundayEndTime)
                                 VALUES
                                 (@EmployeeID, @MondayStartTime, @MondayEndTime, @TuesdayStartTime, @TuesdayEndTime, 
                                 @WednesdayStartTime, @WednesdayEndTime, @ThursdayStartTime, @ThursdayEndTime, 
                                 @FridayStartTime, @FridayEndTime, @SaturdayStartTime, @SaturdayEndTime, 
                                 @SundayStartTime, @SundayEndTime)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@EmployeeID", comboBox1.SelectedItem);
                command.Parameters.AddWithValue("@MondayStartTime", dateTimePicker1.Value.TimeOfDay);
                command.Parameters.AddWithValue("@MondayEndTime", dateTimePicker8.Value.TimeOfDay);
                command.Parameters.AddWithValue("@TuesdayStartTime", dateTimePicker2.Value.TimeOfDay);
                command.Parameters.AddWithValue("@TuesdayEndTime", dateTimePicker9.Value.TimeOfDay);
                command.Parameters.AddWithValue("@WednesdayStartTime", dateTimePicker3.Value.TimeOfDay);
                command.Parameters.AddWithValue("@WednesdayEndTime", dateTimePicker10.Value.TimeOfDay);
                command.Parameters.AddWithValue("@ThursdayStartTime", dateTimePicker4.Value.TimeOfDay);
                command.Parameters.AddWithValue("@ThursdayEndTime", dateTimePicker11.Value.TimeOfDay);
                command.Parameters.AddWithValue("@FridayStartTime", dateTimePicker5.Value.TimeOfDay);
                command.Parameters.AddWithValue("@FridayEndTime", dateTimePicker12.Value.TimeOfDay);
                command.Parameters.AddWithValue("@SaturdayStartTime", dateTimePicker6.Value.TimeOfDay);
                command.Parameters.AddWithValue("@SaturdayEndTime", dateTimePicker14.Value.TimeOfDay);
                command.Parameters.AddWithValue("@SundayStartTime", dateTimePicker7.Value.TimeOfDay);
                command.Parameters.AddWithValue("@SundayEndTime", dateTimePicker15.Value.TimeOfDay);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Roster saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving roster: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            ResetDateTimePickers();
        }

        private void ResetDateTimePickers()
        {
            DateTime now = DateTime.Now;
            dateTimePicker1.Value = now;
            dateTimePicker2.Value = now;
            dateTimePicker3.Value = now;
            dateTimePicker4.Value = now;
            dateTimePicker5.Value = now;
            dateTimePicker6.Value = now;
            dateTimePicker7.Value = now;
            dateTimePicker8.Value = now;
            dateTimePicker9.Value = now;
            dateTimePicker10.Value = now;
            dateTimePicker11.Value = now;
            dateTimePicker12.Value = now;
            dateTimePicker14.Value = now;
            dateTimePicker15.Value = now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new AdminLogin();
            newForm.Show();
            this.Hide();
        }
    }
}
