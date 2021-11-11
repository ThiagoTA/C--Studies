using System.Globalization;

namespace Banco
{
    class Banco
    {
        public int Conta { get; private set; }
        public string _nome;
        public double Deposito { get; private set; }
        public static double Taxa = 5.00;

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

        public void Depositar(double adicionar)
        {
            Deposito += adicionar;
        }

        public void Sacar(double remover)
        {
            Deposito = (Deposito - remover) - Taxa;
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
