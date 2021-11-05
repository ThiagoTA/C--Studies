using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProposto3
{
    class Aluno
    {
        public string Nome;
        public double Tr1, Tr2, Tr3;

        public double NotaFinal()
        {
            return Tr1 + Tr2  + Tr3 ; 
        }

        public bool Aprovado()
        {
            if(NotaFinal() >= 60)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double NotaFaltando()
        {
            return NotaFinal() - 60;
        }   
    }
}
