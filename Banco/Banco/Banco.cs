using System.Globalization;

namespace Banco
{
    class Banco
    {
        public double Taxa = 5.00;
        public int Conta { get; private set; }
        public string _nome;
        public double Deposito { get; private set; }

        public Banco(){
        }

        public Banco(int conta, string nome, double deposito)
        {
            Conta = conta;
            _nome = nome;
            Deposito = deposito;
        }

        public Banco(int conta, string nome)
        {
            Conta = conta;
            _nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Depositar(double adicionar)
        {
            return Deposito += adicionar;
        }

        public double Sacar(double remover)
        {
            return Deposito = (Deposito - remover) - Taxa;
        }

        public override string ToString()
        {
            return "Conta: "
                + Conta + ", "
                + "Titular: "
                + Nome + ", "
                + "Saldo: $ "
                + Deposito.ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
