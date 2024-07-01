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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Visual-Program\\NKSQL;Initial Catalog=vbmultiuser;Integrated Security=True");
            con.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO Officers ('\"+ officer_id(textBox1.Text)+\"' , '\"+ officer_name(textBox2.Text)+\" , '\"+ mobile_no(textBox3.Text)+\"' , '\"+ address(textBox4.Text)+\"' , '\"+ mail_id(textBox5.Text)+\"' , '\"+ area(textBox6.Text)+\"' , getdata())", con);
            SqlCommand cmd = new SqlCommand("INSERT INTO Evidence " + "(case_id, evidence_type, evidence, suspect, note)" + "VALUES(@a,@b,@c,@d,@e)", con);
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
