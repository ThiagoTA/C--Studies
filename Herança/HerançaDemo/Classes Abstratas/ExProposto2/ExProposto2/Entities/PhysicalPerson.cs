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
            if (AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.15 - HeathSpending * 0.50;
            }
            else
            {
                return AnnualIncome * 0.25 - HeathSpending * 0.50; ;
            }
        }
    }
}
