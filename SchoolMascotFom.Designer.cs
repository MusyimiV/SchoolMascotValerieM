namespace SchoolMascotValerieM
{
    partial class frmSchoolMascot
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
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblSchoolMascot = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStJoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMotherTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStMarks = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSchool.SuspendLayout();
            this.mnuSchools.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblSchoolMascot);
            this.grbSchool.Controls.Add(this.lblSchoolName);
            this.grbSchool.Location = new System.Drawing.Point(74, 94);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(260, 103);
            this.grbSchool.TabIndex = 0;
            this.grbSchool.TabStop = false;
            this.grbSchool.Text = "groupBox1";
            // 
            // lblSchoolMascot
            // 
            this.lblSchoolMascot.AutoSize = true;
            this.lblSchoolMascot.Location = new System.Drawing.Point(60, 86);
            this.lblSchoolMascot.Name = "lblSchoolMascot";
            this.lblSchoolMascot.Size = new System.Drawing.Size(35, 13);
            this.lblSchoolMascot.TabIndex = 1;
            this.lblSchoolMascot.Text = "label2";
            this.lblSchoolMascot.Click += new System.EventHandler(this.lblSchoolMascot_Click);
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Location = new System.Drawing.Point(60, 31);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(35, 13);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "label1";
            // 
            // mnuSchools
            // 
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(378, 24);
            this.mnuSchools.TabIndex = 1;
            this.mnuSchools.Text = "menuStrip1";
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniStJoes,
            this.mniMotherTeresa,
            this.mniStMarks});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(152, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniStJoes
            // 
            this.mniStJoes.Name = "mniStJoes";
            this.mniStJoes.Size = new System.Drawing.Size(152, 22);
            this.mniStJoes.Text = "St. Joe\'s";
            this.mniStJoes.Click += new System.EventHandler(this.mniStJoes_Click);
            // 
            // mniMotherTeresa
            // 
            this.mniMotherTeresa.Name = "mniMotherTeresa";
            this.mniMotherTeresa.Size = new System.Drawing.Size(152, 22);
            this.mniMotherTeresa.Text = "Mother Teresa";
            this.mniMotherTeresa.Click += new System.EventHandler(this.mniMotherTeresa_Click);
            // 
            // mniStMarks
            // 
            this.mniStMarks.Name = "mniStMarks";
            this.mniStMarks.Size = new System.Drawing.Size(152, 22);
            this.mniStMarks.Text = "St. Mark\'s";
            this.mniStMarks.Click += new System.EventHandler(this.mniStMarks_Click);
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 284);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuSchools);
            this.MainMenuStrip = this.mnuSchools;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot by Valerie M";
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblSchoolMascot;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniStJoes;
        private System.Windows.Forms.ToolStripMenuItem mniMotherTeresa;
        private System.Windows.Forms.ToolStripMenuItem mniStMarks;
    }
}

