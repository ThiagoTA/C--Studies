namespace ExProposto2.Entities
{
    class LegalPerson : Contributor
    {
        public int Employees { get; set; }

        public LegalPerson(string name, double annualIncome, int employees)
            : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            double total;
            if (Employees < 10)
            {
                total = AnnualIncome * 0.16;
            }
            else
            {
                total = AnnualIncome * 0.14;
            }

            return total;
        }
    }
}
