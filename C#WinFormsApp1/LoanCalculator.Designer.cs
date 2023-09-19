namespace C_WinFormsApp1
{
    partial class LoanCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLoanAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTerms = new TextBox();
            txtInterestRate = new TextBox();
            txtDownPayment = new TextBox();
            btnMorgage = new Button();
            btnAuto = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(221, 35);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(288, 23);
            txtLoanAmount.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Loan Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 90);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Down Payment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 152);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 3;
            label3.Text = "Interest Rate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 204);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Terms in Years:";
            // 
            // txtTerms
            // 
            txtTerms.Location = new Point(221, 201);
            txtTerms.Name = "txtTerms";
            txtTerms.Size = new Size(288, 23);
            txtTerms.TabIndex = 6;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(221, 149);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(288, 23);
            txtInterestRate.TabIndex = 7;
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location = new Point(221, 87);
            txtDownPayment.Name = "txtDownPayment";
            txtDownPayment.Size = new Size(288, 23);
            txtDownPayment.TabIndex = 8;
            // 
            // btnMorgage
            // 
            btnMorgage.Location = new Point(220, 248);
            btnMorgage.Name = "btnMorgage";
            btnMorgage.Size = new Size(131, 23);
            btnMorgage.TabIndex = 9;
            btnMorgage.Text = "Mortgage";
            btnMorgage.UseVisualStyleBackColor = true;
            btnMorgage.Click += btnMorgage_Click_1;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(378, 248);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(131, 23);
            btnAuto.TabIndex = 10;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(218, 296);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 15);
            lblOutput.TabIndex = 11;
            // 
            // LoanCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(btnAuto);
            Controls.Add(btnMorgage);
            Controls.Add(txtDownPayment);
            Controls.Add(txtInterestRate);
            Controls.Add(txtTerms);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLoanAmount);
            Name = "LoanCalculator";
            Text = "Loan Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoanAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTerms;
        private TextBox txtInterestRate;
        private TextBox txtDownPayment;
        private Button btnMorgage;
        private Button btnAuto;
        private Label lblOutput;
    }
}