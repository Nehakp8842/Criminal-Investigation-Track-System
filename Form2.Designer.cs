using System;

namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOfficerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCaseOfficerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSuspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEvidenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCaseToolStripMenuItem,
            this.addOfficerToolStripMenuItem,
            this.addCaseOfficerToolStripMenuItem,
            this.predictionToolStripMenuItem,
            this.addResultToolStripMenuItem,
            this.viewSuspectToolStripMenuItem,
            this.viewEvidenceToolStripMenuItem,
            this.viewCaseHistoryToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1123, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCaseToolStripMenuItem
            // 
            this.addCaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCaseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addCaseToolStripMenuItem.Name = "addCaseToolStripMenuItem";
            this.addCaseToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.addCaseToolStripMenuItem.Text = "Add Case";
            this.addCaseToolStripMenuItem.Click += new System.EventHandler(this.addCaseToolStripMenuItem_Click);
            // 
            // addOfficerToolStripMenuItem
            // 
            this.addOfficerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOfficerToolStripMenuItem.Name = "addOfficerToolStripMenuItem";
            this.addOfficerToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.addOfficerToolStripMenuItem.Text = "Add Officer";
            this.addOfficerToolStripMenuItem.Click += new System.EventHandler(this.addOfficerToolStripMenuItem_Click);
            // 
            // addCaseOfficerToolStripMenuItem
            // 
            this.addCaseOfficerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCaseOfficerToolStripMenuItem.Name = "addCaseOfficerToolStripMenuItem";
            this.addCaseOfficerToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
            this.addCaseOfficerToolStripMenuItem.Text = "Add Case Officer";
            this.addCaseOfficerToolStripMenuItem.Click += new System.EventHandler(this.addCaseOfficerToolStripMenuItem_Click);
            // 
            // predictionToolStripMenuItem
            // 
            this.predictionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictionToolStripMenuItem.Name = "predictionToolStripMenuItem";
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.predictionToolStripMenuItem.Text = "Prediction";
            this.predictionToolStripMenuItem.Click += new System.EventHandler(this.predictionToolStripMenuItem_Click);
            // 
            // addResultToolStripMenuItem
            // 
            this.addResultToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResultToolStripMenuItem.Name = "addResultToolStripMenuItem";
            this.addResultToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.addResultToolStripMenuItem.Text = "Add Result";
            this.addResultToolStripMenuItem.Click += new System.EventHandler(this.addResultToolStripMenuItem_Click);
            // 
            // viewSuspectToolStripMenuItem
            // 
            this.viewSuspectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSuspectToolStripMenuItem.Name = "viewSuspectToolStripMenuItem";
            this.viewSuspectToolStripMenuItem.Size = new System.Drawing.Size(130, 27);
            this.viewSuspectToolStripMenuItem.Text = "View Suspect";
            this.viewSuspectToolStripMenuItem.Click += new System.EventHandler(this.viewSuspectToolStripMenuItem_Click);
            // 
            // viewEvidenceToolStripMenuItem
            // 
            this.viewEvidenceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEvidenceToolStripMenuItem.Name = "viewEvidenceToolStripMenuItem";
            this.viewEvidenceToolStripMenuItem.Size = new System.Drawing.Size(138, 27);
            this.viewEvidenceToolStripMenuItem.Text = "View Evidence";
            this.viewEvidenceToolStripMenuItem.Click += new System.EventHandler(this.viewEvidenceToolStripMenuItem_Click);
            // 
            // viewCaseHistoryToolStripMenuItem
            // 
            this.viewCaseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCaseHistoryToolStripMenuItem.Name = "viewCaseHistoryToolStripMenuItem";
            this.viewCaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(168, 27);
            this.viewCaseHistoryToolStripMenuItem.Text = "View Case History";
            this.viewCaseHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewCaseHistoryToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1123, 563);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOfficerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCaseOfficerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSuspectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEvidenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCaseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}