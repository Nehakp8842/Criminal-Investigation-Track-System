using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Visual-Program\\NKSQL;Initial Catalog=vbmultiuser;Integrated Security=True");
            con.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO Officers ('\"+ officer_id(textBox1.Text)+\"' , '\"+ officer_name(textBox2.Text)+\" , '\"+ mobile_no(textBox3.Text)+\"' , '\"+ address(textBox4.Text)+\"' , '\"+ mail_id(textBox5.Text)+\"' , '\"+ area(textBox6.Text)+\"' , getdata())", con);
            SqlCommand cmd = new SqlCommand("INSERT INTO Cases " + "(case_id, case_name, officer_id, officer_name, note)" + "VALUES(@a,@b,@c,@d,@e) ", con);
            cmd.Parameters.AddWithValue("@a", textBox1.Text);
            cmd.Parameters.AddWithValue("@b", textBox2.Text);
            cmd.Parameters.AddWithValue("@c", textBox3.Text);
            cmd.Parameters.AddWithValue("@d", textBox4.Text);
            cmd.Parameters.AddWithValue("@e", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Excecuted");
            con.Close();
        } 
       
    }
}
