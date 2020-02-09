namespace US_Presidential_Elections_Eligibility_Program
{
    partial class CheckEligibility
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
            this.ChkBoxNaturalBorn = new System.Windows.Forms.CheckBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxYearsInUS = new System.Windows.Forms.TextBox();
            this.lblTermsServed = new System.Windows.Forms.Label();
            this.txtboxTermsServed = new System.Windows.Forms.TextBox();
            this.ChkBoxRebelled = new System.Windows.Forms.CheckBox();
            this.btnCheckEligibility = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChkBoxNaturalBorn
            // 
            this.ChkBoxNaturalBorn.AutoSize = true;
            this.ChkBoxNaturalBorn.Location = new System.Drawing.Point(24, 37);
            this.ChkBoxNaturalBorn.Name = "ChkBoxNaturalBorn";
            this.ChkBoxNaturalBorn.Size = new System.Drawing.Size(137, 17);
            this.ChkBoxNaturalBorn.TabIndex = 0;
            this.ChkBoxNaturalBorn.Text = "US Natural Born Citizen";
            this.ChkBoxNaturalBorn.UseVisualStyleBackColor = true;
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(21, 73);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(90, 13);
            this.lblBirthYear.TabIndex = 1;
            this.lblBirthYear.Text = "How old are you?";
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(288, 73);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(52, 20);
            this.txtboxAge.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many years have you resided in the US?";
            // 
            // txtboxYearsInUS
            // 
            this.txtboxYearsInUS.Location = new System.Drawing.Point(288, 111);
            this.txtboxYearsInUS.Name = "txtboxYearsInUS";
            this.txtboxYearsInUS.Size = new System.Drawing.Size(52, 20);
            this.txtboxYearsInUS.TabIndex = 4;
            // 
            // lblTermsServed
            // 
            this.lblTermsServed.AutoSize = true;
            this.lblTermsServed.Location = new System.Drawing.Point(21, 146);
            this.lblTermsServed.Name = "lblTermsServed";
            this.lblTermsServed.Size = new System.Drawing.Size(210, 13);
            this.lblTermsServed.TabIndex = 5;
            this.lblTermsServed.Text = "How many terms have you served already?";
            // 
            // txtboxTermsServed
            // 
            this.txtboxTermsServed.Location = new System.Drawing.Point(288, 146);
            this.txtboxTermsServed.Name = "txtboxTermsServed";
            this.txtboxTermsServed.Size = new System.Drawing.Size(52, 20);
            this.txtboxTermsServed.TabIndex = 6;
            // 
            // ChkBoxRebelled
            // 
            this.ChkBoxRebelled.AutoSize = true;
            this.ChkBoxRebelled.Location = new System.Drawing.Point(24, 182);
            this.ChkBoxRebelled.Name = "ChkBoxRebelled";
            this.ChkBoxRebelled.Size = new System.Drawing.Size(193, 17);
            this.ChkBoxRebelled.TabIndex = 7;
            this.ChkBoxRebelled.Text = "I have not rebelled against the US?";
            this.ChkBoxRebelled.UseVisualStyleBackColor = true;
            // 
            // btnCheckEligibility
            // 
            this.btnCheckEligibility.Location = new System.Drawing.Point(156, 244);
            this.btnCheckEligibility.Name = "btnCheckEligibility";
            this.btnCheckEligibility.Size = new System.Drawing.Size(87, 51);
            this.btnCheckEligibility.TabIndex = 8;
            this.btnCheckEligibility.Text = "Check Eligibility";
            this.btnCheckEligibility.UseVisualStyleBackColor = true;
            this.btnCheckEligibility.Click += new System.EventHandler(this.btnCheckEligibility_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(182, 323);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckEligibility);
            this.Controls.Add(this.ChkBoxRebelled);
            this.Controls.Add(this.txtboxTermsServed);
            this.Controls.Add(this.lblTermsServed);
            this.Controls.Add(this.txtboxYearsInUS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.ChkBoxNaturalBorn);
            this.Name = "Form1";
            this.Text = "Check Presidential Eligibility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkBoxNaturalBorn;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxYearsInUS;
        private System.Windows.Forms.Label lblTermsServed;
        private System.Windows.Forms.TextBox txtboxTermsServed;
        private System.Windows.Forms.CheckBox ChkBoxRebelled;
        private System.Windows.Forms.Button btnCheckEligibility;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
    }
}

