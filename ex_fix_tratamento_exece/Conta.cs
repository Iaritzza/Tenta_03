using System;
using System.Globalization;

namespace ex_fix_tratamento_exece
{
    class Conta
    {
        public int  Num { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta()
        {
        }

        public Conta(int num, string nome, double saldo, double limiteSaque)
        {
            Num = num;
            Nome = nome;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }
        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }
        public void Saque(double valor)
        {
            if (Saldo < valor)
            {
                throw new DoMainException("Saldo menor que o valor de saque.");
            }
            if (valor > LimiteSaque)
            {
                throw new DoMainException("Valor maior que o limite de saque.");
            }

            Saldo = Saldo - valor;

        }
        public override string ToString()
        {
            return "Novo saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
