namespace ExProposto2.Entities
{
    class PhysicalPerson : Contributor
    {
        public double HeathSpending { get; set; }

        public PhysicalPerson( string name, double annualIncome, double heathSpending)
            : base (name, annualIncome)
        {
            HeathSpending = heathSpending;
        }

        public override double Tax()
        {
            double annualIncome;
            if (AnnualIncome < 20000.00)
            {
                annualIncome = AnnualIncome * 0.15;
            }
            else
            {
                annualIncome = AnnualIncome * 0.25;
            }

            double heathSpending;
            if (HeathSpending > 0)
            {
                heathSpending = HeathSpending * 0.50;
            }
            else
            {
                heathSpending = HeathSpending;
            }

            return annualIncome - heathSpending;
        }
    }
}
