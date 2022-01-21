namespace ExProposto2.Entities
{
    abstract class Contributor
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Contributor(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public  abstract double Tax();
    }
}
