using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Connection string for MySQL
        private string connectionString = "Data Source=Visual-Program\\NKSQL;Initial Catalog=vbmultiuser;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

            // Add UserType options to ComboBox
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Officer");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string userType = comboBox1.SelectedItem as string; 

            // Authenticate user against MySQL database
            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // Redirect based on UserType
                if (userType == "Admin")
                {
                    Form2 adminForm = new Form2();
                    adminForm.Show();
                }
                else if (userType == "Officer")
                {
                    Form3 officerForm = new Form3();
                    officerForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Authenticate user against MySQL database
private bool AuthenticateUser(string username, string password)
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());


                    return count > 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}

    }
}
