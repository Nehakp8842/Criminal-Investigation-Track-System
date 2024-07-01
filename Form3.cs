using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }


        private void addSuspectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form11
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void addCaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form13
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void viewSuspectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Open Form14
            Form14 form14 = new Form14();
            form14.Show();
        }

        private void viewEvidenceToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // Open Form15
            Form15 form15 = new Form15();
            form15.Show();
        }

        private void addEvidenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form12
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        { 
            // Open Form16
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            // Close the current form (Form2)
            this.Close();
        }
    }
}
