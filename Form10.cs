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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           SqlConnection con = new SqlConnection("Data Source=Visual-Program\\NKSQL;Initial Catalog=vbmultiuser;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("slect * from View Evidence", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=Visual-Program\\NKSQL;Initial Catalog=vbmultiuser;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("select * from Suspects", con);
            // SqlDataAdapter sd = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();

            try
            {
                // Establish a connection to the database.
                using (SqlConnection con = new SqlConnection("Data Source=Visual-Program\\NKSQL;Initial Catalog=vbmultiuser;Integrated Security=True"))
                {
                    // Define the SQL query to retrieve suspects based on the selected case ID.
                    string query = "SELECT * FROM ViewEvidence WHERE case_ID = @CaseID";

                    // Create a SqlCommand object with parameters.
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the case ID parameter.
                        string v = comboBox1.SelectedItem as string;
                        string caseid = v;
                        cmd.Parameters.AddWithValue("@CaseID", comboBox1.SelectedItem.ToString());

                        // Create a new SqlDataAdapter to execute the command and fill the DataTable.
                        using (SqlDataAdapter sd = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            // Fill the DataTable with the results from the query.
                            sd.Fill(dt);

                            // Bind the DataTable to the DataGridView to display the results.
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
   
