namespace C_WinFormsApp1
{
    public partial class LoanCalculator : Form
    {
        private double loanAmount;
        private double downPayment;
        private double upPayment;
        private double interestRate;
        private double monthlyPayment;
        private int terms;
        public LoanCalculator()
        {
            InitializeComponent();
        }

        private void btnMorgage_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!String.IsNullOrEmpty(txtDownPayment.Text))
                downPayment = Convert.ToDouble(txtDownPayment.Text);

            if (!String.IsNullOrEmpty(txtInterestRate.Text))
                interestRate = Convert.ToDouble(txtInterestRate.Text.Replace(".", ","));

            if (!String.IsNullOrEmpty(txtTerms.Text))
                terms = Convert.ToInt32(txtTerms.Text);

            int termsinMonths = terms * 12;
            monthlyPayment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 12), termsinMonths) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termsinMonths) - 1));
            monthlyPayment = Math.Round(monthlyPayment, 2);

            lblOutput.Text = String.Format("Monthly Payment: R {0}", monthlyPayment.ToString());
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            double downPayment = 0.0; 
            double interestRate = 0.0; 
            double monthlyPayment = 0.0; 
            int terms = 0;

            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!String.IsNullOrEmpty(txtDownPayment.Text))
                downPayment = Convert.ToDouble(txtDownPayment.Text);

            if (!String.IsNullOrEmpty(txtInterestRate.Text))
                interestRate = Convert.ToDouble(txtInterestRate.Text.Replace(".", ","));

            if (!String.IsNullOrEmpty(txtTerms.Text))
                terms = Convert.ToInt32(txtTerms.Text);

            int termsinMonths = terms * 12;
            monthlyPayment = (interestRate * loanAmount) / (1 - Math.Pow(1 + interestRate, termsinMonths * -1));

            monthlyPayment = Math.Round(monthlyPayment, 2);

            lblOutput.Text = String.Format("Monthly Payment: R {0}", monthlyPayment.ToString());
        }
    }
}