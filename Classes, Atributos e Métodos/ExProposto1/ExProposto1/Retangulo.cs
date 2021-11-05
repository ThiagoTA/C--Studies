using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProposto1
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimreto()
        {
            return (Largura * Largura) + (Altura * Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString()
        {
            return "Area = "
                + Area().ToString("F2")
                + "\nPerímetro = "
                + Perimreto().ToString("F2")
                + "\nDiagonal = "
                + Diagonal().ToString("F2");
        }
    }
}
