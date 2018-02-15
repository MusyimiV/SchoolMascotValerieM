using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotValerieM
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Immaculata";
            lblSchoolMascot.Text = "Saints";
        }

        private void mniStJoes_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "St. Joe's";
            lblSchoolMascot.Text = "Hwak";
        }

        private void lblSchoolMascot_Click(object sender, EventArgs e)
        {

        }

        private void mniMotherTeresa_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Mother Teresa";
            lblSchoolMascot.Text = "Spartans";
        }

        private void mniStMarks_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "St.Mark's";
            lblSchoolMascot.Text = "";
        }
    }
}
