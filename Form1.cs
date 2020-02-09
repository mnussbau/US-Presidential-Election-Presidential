using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_Presidential_Elections_Eligibility_Program
{
    public partial class CheckEligibility : Form
    {
        public CheckEligibility()
        {
            InitializeComponent();
        }

        private void btnCheckEligibility_Click(object sender, EventArgs e)
        {
            bool isNaturalBorn = ChkBoxNaturalBorn.Checked;
            int age = int.Parse(txtboxAge.Text);
            int yearsInUS = int.Parse(txtboxYearsInUS.Text);
            int termsServed = int.Parse(txtboxTermsServed.Text);
            bool didntRebel = ChkBoxRebelled.Checked;
            if(isNaturalBorn && age>=35 && yearsInUS >=14 && termsServed < 2 && didntRebel)
            {
                lblResult.Text = "You Are Eligible";
            }
            else
            {
                lblResult.Text = "You Are not Eligible";
            }
        }
    }
}
