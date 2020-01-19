using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_deductions
{
    public class TaxClass
    {
        //-----------fields-------------
        private decimal _grossIncome;
        private decimal _nhis;
        private decimal _nhf;
        private decimal _lap;
        private decimal _nps;
        private decimal _grat;
        private decimal _pension;


        //..............COnstructor ...................

        public TaxClass() { }

        public decimal GrossIncome
        {
            get { return _grossIncome; }
            set
            {
                if (value != null)
                    _grossIncome = value;
            }
        }
        public decimal Nhis
        {
            get { return _nhis; }
            set 
            {
                if (value != null)
                _nhis = value;
            }
        }
        public decimal NHF
        {
            get { return _nhf; }
            set { if (value != null)
            _nhf = value;}
        }
        public decimal LAP
        {
            get { return _lap; }
            set
            {
                if (value != null)
                    _lap = value;
            }
        }

        public decimal NPS
        {
            get { return _nps; }
            set {if(value != null)
            _nps = value;}
        }

        public decimal Grat
        {
            get { return _grat; }
            set {if (value != null)
            _grat = value;
            }
        }
        public decimal Pension
        {
            get { return _pension; }
            set
            {
                if (value != null)
                    _pension = value;

            }
        }

        //..............Methods..................

        
        public decimal Annual_Gross_Emoulments ()
        {
            //.....please remember to add gross emoluments of other allowances..
            decimal annualGE;
            annualGE = _grossIncome * 12m; 
            return annualGE;
        }

        public decimal Cra ()
        {
            decimal annualGE = Annual_Gross_Emoulments();
            decimal bGp = 0.2m * annualGE;
            decimal ggP = 0.1m * annualGE;
            decimal CRA;

            if (ggP > 200000m)
            {
                CRA = bGp + ggP;
                return CRA;
            }
            else
            {
                CRA = bGp + 200000m;
                return CRA;
            }

        }
        //.......Create a method called relief where CRA, pension and others are calculated
        //       to get reliefs
        //subtract total relief from annual gross in taxable amount
        public decimal Taxable_amount ()
        {
            // recalll to modify with Pension, subtract pension from total relief when obtained
            // pension is 15% of basic + transport +

            decimal cra = Cra();
            decimal annGross = Annual_Gross_Emoulments();

            // subtratcing the tax reliefs from the taxable amount 

            decimal txamount = annGross - (cra + _pension + _nhf + _nhis + _nps + _lap + _grat);
            return txamount;

        }

        public decimal comp_Table ()
        {
            decimal taxableamount = Taxable_amount();
            decimal comTaxable= taxableamount;
            decimal[] taxrule = new decimal[6] {300000m, 300000m, 500000m, 500000m,1600000m, 3200000m};
            decimal[] taxrate = new decimal[6] {0.07m, 0.11m, 0.15m, 0.19m, 0.21m, 0.24m};
            decimal[] tax     = new decimal[6];

            for (int i = 0; i <= 5; i++)
            {
                if (taxableamount < taxrule[i])
                {

                    tax[i] = taxableamount * taxrate[i];
                    break;
                }
                taxableamount = taxableamount - taxrule[i];
                tax[i] = taxrule[i] * taxrate[i];


                
            }

            for (int i = 0; i <= 5; i++)
            {
                if (tax[i].Equals(0))
                {
                    tax[i] = 0m;
                }
            }

            decimal paye = tax[0] + tax[1] + tax[2] + tax[3] + tax[4] + tax[5];

            return paye;

        }
    }
}
