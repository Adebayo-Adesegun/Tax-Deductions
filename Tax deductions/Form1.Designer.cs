namespace Tax_deductions
{
    partial class FrmtaxCalculator
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtTaxableIncome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCRA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPension = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtGrat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNPS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtLAP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNHIS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNHF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkNHF = new System.Windows.Forms.CheckBox();
            this.GrpOptions = new System.Windows.Forms.GroupBox();
            this.chkpension = new System.Windows.Forms.CheckBox();
            this.ChkGrat = new System.Windows.Forms.CheckBox();
            this.CHKnps = new System.Windows.Forms.CheckBox();
            this.CHKNHIS = new System.Windows.Forms.CheckBox();
            this.CHKLAP = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtGrossPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTaxInc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtMT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GrpOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.TxtTaxableIncome);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TxtCRA);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(2, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 90);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxtTaxableIncome
            // 
            this.TxtTaxableIncome.Location = new System.Drawing.Point(188, 48);
            this.TxtTaxableIncome.Name = "TxtTaxableIncome";
            this.TxtTaxableIncome.Size = new System.Drawing.Size(182, 20);
            this.TxtTaxableIncome.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Taxable Income";
            // 
            // TxtCRA
            // 
            this.TxtCRA.Location = new System.Drawing.Point(188, 16);
            this.TxtCRA.Name = "TxtCRA";
            this.TxtCRA.Size = new System.Drawing.Size(182, 20);
            this.TxtCRA.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Consolidated Relief Allowance";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.TxtPension);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtGrat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtNPS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtLAP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNHIS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNHF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(184, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 170);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Reliefs";
            // 
            // TxtPension
            // 
            this.TxtPension.Enabled = false;
            this.TxtPension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPension.Location = new System.Drawing.Point(145, 146);
            this.TxtPension.Name = "TxtPension";
            this.TxtPension.Size = new System.Drawing.Size(116, 20);
            this.TxtPension.TabIndex = 28;
            this.TxtPension.TextChanged += new System.EventHandler(this.TxtPension_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Pension";
            this.toolTip1.SetToolTip(this.label10, "Sum of Basic, Transport and Housing Allowance");
            // 
            // TxtGrat
            // 
            this.TxtGrat.Enabled = false;
            this.TxtGrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGrat.Location = new System.Drawing.Point(145, 122);
            this.TxtGrat.Name = "TxtGrat";
            this.TxtGrat.Size = new System.Drawing.Size(116, 20);
            this.TxtGrat.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Gratuities";
            // 
            // TxtNPS
            // 
            this.TxtNPS.Enabled = false;
            this.TxtNPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNPS.Location = new System.Drawing.Point(145, 98);
            this.TxtNPS.Name = "TxtNPS";
            this.TxtNPS.Size = new System.Drawing.Size(116, 20);
            this.TxtNPS.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "National Pension Scheme";
            // 
            // TxtLAP
            // 
            this.TxtLAP.Enabled = false;
            this.TxtLAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLAP.Location = new System.Drawing.Point(145, 73);
            this.TxtLAP.Name = "TxtLAP";
            this.TxtLAP.Size = new System.Drawing.Size(116, 20);
            this.TxtLAP.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Life Assurance Premium";
            // 
            // TxtNHIS
            // 
            this.TxtNHIS.Enabled = false;
            this.TxtNHIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNHIS.Location = new System.Drawing.Point(145, 49);
            this.TxtNHIS.Name = "TxtNHIS";
            this.TxtNHIS.Size = new System.Drawing.Size(116, 20);
            this.TxtNHIS.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "NHIS";
            // 
            // TxtNHF
            // 
            this.TxtNHF.Enabled = false;
            this.TxtNHF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNHF.Location = new System.Drawing.Point(145, 23);
            this.TxtNHF.Name = "TxtNHF";
            this.TxtNHF.Size = new System.Drawing.Size(116, 20);
            this.TxtNHF.TabIndex = 18;
            this.TxtNHF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NHF";
            // 
            // ChkNHF
            // 
            this.ChkNHF.AutoSize = true;
            this.ChkNHF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkNHF.Location = new System.Drawing.Point(6, 22);
            this.ChkNHF.Name = "ChkNHF";
            this.ChkNHF.Size = new System.Drawing.Size(48, 17);
            this.ChkNHF.TabIndex = 0;
            this.ChkNHF.Text = "NHF";
            this.ChkNHF.UseVisualStyleBackColor = true;
            this.ChkNHF.CheckedChanged += new System.EventHandler(this.ChkNHF_CheckedChanged);
            // 
            // GrpOptions
            // 
            this.GrpOptions.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.GrpOptions.Controls.Add(this.chkpension);
            this.GrpOptions.Controls.Add(this.ChkGrat);
            this.GrpOptions.Controls.Add(this.ChkNHF);
            this.GrpOptions.Controls.Add(this.CHKnps);
            this.GrpOptions.Controls.Add(this.CHKNHIS);
            this.GrpOptions.Controls.Add(this.CHKLAP);
            this.GrpOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrpOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpOptions.Location = new System.Drawing.Point(2, 46);
            this.GrpOptions.Name = "GrpOptions";
            this.GrpOptions.Size = new System.Drawing.Size(164, 166);
            this.GrpOptions.TabIndex = 2;
            this.GrpOptions.TabStop = false;
            this.GrpOptions.Text = "Set Less Options";
            // 
            // chkpension
            // 
            this.chkpension.AutoSize = true;
            this.chkpension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpension.Location = new System.Drawing.Point(6, 146);
            this.chkpension.Name = "chkpension";
            this.chkpension.Size = new System.Drawing.Size(64, 17);
            this.chkpension.TabIndex = 22;
            this.chkpension.Text = "Pension";
            this.chkpension.UseVisualStyleBackColor = true;
            this.chkpension.CheckedChanged += new System.EventHandler(this.chkpension_CheckedChanged);
            // 
            // ChkGrat
            // 
            this.ChkGrat.AutoSize = true;
            this.ChkGrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkGrat.Location = new System.Drawing.Point(6, 121);
            this.ChkGrat.Name = "ChkGrat";
            this.ChkGrat.Size = new System.Drawing.Size(70, 17);
            this.ChkGrat.TabIndex = 21;
            this.ChkGrat.Text = "Gratuities";
            this.ChkGrat.UseVisualStyleBackColor = true;
            this.ChkGrat.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // CHKnps
            // 
            this.CHKnps.AutoSize = true;
            this.CHKnps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKnps.Location = new System.Drawing.Point(6, 98);
            this.CHKnps.Name = "CHKnps";
            this.CHKnps.Size = new System.Drawing.Size(148, 17);
            this.CHKnps.TabIndex = 20;
            this.CHKnps.Text = "National Pension Scheme";
            this.CHKnps.UseVisualStyleBackColor = true;
            this.CHKnps.CheckedChanged += new System.EventHandler(this.CHKnps_CheckedChanged);
            // 
            // CHKNHIS
            // 
            this.CHKNHIS.AutoSize = true;
            this.CHKNHIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKNHIS.Location = new System.Drawing.Point(6, 47);
            this.CHKNHIS.Name = "CHKNHIS";
            this.CHKNHIS.Size = new System.Drawing.Size(52, 17);
            this.CHKNHIS.TabIndex = 18;
            this.CHKNHIS.Text = "NHIS";
            this.CHKNHIS.UseVisualStyleBackColor = true;
            this.CHKNHIS.CheckedChanged += new System.EventHandler(this.CHKNHIS_CheckedChanged);
            // 
            // CHKLAP
            // 
            this.CHKLAP.AutoSize = true;
            this.CHKLAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKLAP.Location = new System.Drawing.Point(6, 73);
            this.CHKLAP.Name = "CHKLAP";
            this.CHKLAP.Size = new System.Drawing.Size(139, 17);
            this.CHKLAP.TabIndex = 19;
            this.CHKLAP.Text = "Life Assurance Premium";
            this.CHKLAP.UseVisualStyleBackColor = true;
            this.CHKLAP.CheckedChanged += new System.EventHandler(this.CHKLAP_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtGrossPay);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 40);
            this.panel2.TabIndex = 1;
            // 
            // TxtGrossPay
            // 
            this.TxtGrossPay.Location = new System.Drawing.Point(177, 10);
            this.TxtGrossPay.Name = "TxtGrossPay";
            this.TxtGrossPay.Size = new System.Drawing.Size(269, 20);
            this.TxtGrossPay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Gross Income\r\n";
            // 
            // BtnTaxInc
            // 
            this.BtnTaxInc.BackColor = System.Drawing.SystemColors.Window;
            this.BtnTaxInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTaxInc.Location = new System.Drawing.Point(379, 372);
            this.BtnTaxInc.Name = "BtnTaxInc";
            this.BtnTaxInc.Size = new System.Drawing.Size(79, 53);
            this.BtnTaxInc.TabIndex = 18;
            this.BtnTaxInc.Text = "Compute ";
            this.BtnTaxInc.UseVisualStyleBackColor = false;
            this.BtnTaxInc.Click += new System.EventHandler(this.BtnTaxInc_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.TxtMT);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.TxtTax);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(2, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 90);
            this.panel3.TabIndex = 21;
            // 
            // TxtMT
            // 
            this.TxtMT.Location = new System.Drawing.Point(81, 56);
            this.TxtMT.Name = "TxtMT";
            this.TxtMT.Size = new System.Drawing.Size(142, 20);
            this.TxtMT.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Monthly Tax";
            // 
            // TxtTax
            // 
            this.TxtTax.Location = new System.Drawing.Point(81, 15);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.Size = new System.Drawing.Size(142, 20);
            this.TxtTax.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Yearly Tax";
            // 
            // FrmtaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(466, 432);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnTaxInc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpOptions);
            this.Controls.Add(this.panel1);
            this.Name = "FrmtaxCalculator";
            this.Text = "Tax Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpOptions.ResumeLayout(false);
            this.GrpOptions.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCRA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkNHF;
        private System.Windows.Forms.GroupBox GrpOptions;
        private System.Windows.Forms.CheckBox ChkGrat;
        private System.Windows.Forms.CheckBox CHKnps;
        private System.Windows.Forms.CheckBox CHKNHIS;
        private System.Windows.Forms.CheckBox CHKLAP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtGrat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNPS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtLAP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNHIS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNHF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGrossPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTaxInc;
        private System.Windows.Forms.TextBox TxtTaxableIncome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPension;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkpension;
        private System.Windows.Forms.TextBox TxtMT;
        private System.Windows.Forms.Label label11;
    }
}

