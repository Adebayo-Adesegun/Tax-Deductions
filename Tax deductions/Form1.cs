using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_deductions
{
      

    public partial class FrmtaxCalculator : Form
    {
        TaxClass taxcalc = new TaxClass();
        public FrmtaxCalculator()
        {
            
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChkNHF_CheckedChanged(object sender, EventArgs e)
        {

            if (ChkNHF.Checked == true)
            {
                TxtNHF.Enabled = true;
                
            } 
            else
                TxtNHF.Enabled = false;
                TxtNHF.Clear();
        }

        private void CHKNHIS_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKNHIS.Checked == true)
            {
                TxtNHIS.Enabled = true;
                
            }
               
            else
                TxtNHIS.Enabled = false;
                TxtNHIS.Clear();
        }

        private void CHKLAP_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKLAP.Checked == true)
            {
                TxtLAP.Enabled = true;
               
            }
               
            else
                TxtLAP.Enabled = false;
                TxtLAP.Clear();
        }

        private void CHKnps_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKnps.Checked == true)
            {
                TxtNPS.Enabled = true;
                
            }
                
            else

                TxtNPS.Enabled = false;
                TxtNPS.Clear();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkGrat.Checked == true)
            {
                TxtGrat.Enabled = true;
                
            }
                
            else
                TxtGrat.Enabled = false;
                TxtGrat.Clear();

        }
       
        private void BtnTaxInc_Click(object sender, EventArgs e)
        {
            decimal GrossInc;
            decimal nhf, nhis, lap, nps, grat,sum;
            decimal GrossEmoluments;
          
            taxcalc.GrossIncome = Convert.ToDecimal(TxtGrossPay.Text);

            if (TxtNHF.Text == "")
            {
                taxcalc.NHF = 0m;
            }
            else
            {
                taxcalc.NHF = Convert.ToDecimal(TxtNHF.Text);
            }
            
            if (TxtNHIS.Text == "")
            {
                taxcalc.Nhis = 0m;
            }
            else
            {
                taxcalc.Nhis = Convert.ToDecimal(TxtNHIS.Text);
            }

           if (TxtLAP.Text == "")
           {
              taxcalc.LAP = 0m;
           }
           else
           {
               taxcalc.LAP = Convert.ToDecimal(TxtLAP.Text);
           }
            if (TxtNPS.Text == "")
            {
                taxcalc.NPS = 0m;
            }
            else
            {
                taxcalc.NPS = Convert.ToDecimal(TxtNPS.Text);
            }
         
            if (TxtGrat.Text == "")
            {
                taxcalc.Grat = 0m;
            }
            else
            {
                taxcalc.Grat = Convert.ToDecimal(TxtGrat.Text);
            }
            
            //call sum method for Gross Emoluments 

            GrossEmoluments = taxcalc.Annual_Gross_Emoulments();
            TxtTaxableIncome.Text = GrossEmoluments.ToString();
            TxtCRA.Text = taxcalc.Cra().ToString();
            TxtTaxableIncome.Text = taxcalc.Taxable_amount().ToString();
            TxtTax.Text = taxcalc.comp_Table().ToString();
           
     }

        private void sideBar1_Click(object sender, EventArgs e)
        {

        }

        private void chkpension_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpension.Checked == true)
            {
                TxtPension.Enabled = true;

            }

            else
                TxtGrat.Enabled = false;
            TxtGrat.Clear();
        }

        private void TxtPension_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
