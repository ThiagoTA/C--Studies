using Interface_herancaDemo.Model.Enums;

namespace Interface_herancaDemo.Model.Entities
{
    abstract class AbstractShape : IShape 
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
