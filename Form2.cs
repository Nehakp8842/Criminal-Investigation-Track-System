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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Wire up ToolStripMenuItem click events
            //addCaseToolStripMenuItem.Click += AddCaseToolStripMenuItem_Click;
            //addOfficerToolStripMenuItem.Click += AddOfficerToolStripMenuItem_Click;
            
        }

        private void addCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form4
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void addOfficerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form5
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void addCaseOfficerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form6
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void predictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form7
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void addResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form8
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void viewSuspectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form9
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void viewEvidenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form10
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void viewCaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form16
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the current form (Form2)
            this.Close();
        }
    }
}