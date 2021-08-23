using System;using System.Globalization;

namespace ex_fix_tratamento_exece
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Numero: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta conta = new Conta(num, nome, saldo, limiteSaque);
                Console.WriteLine();
                Console.WriteLine("Entre com o valor do saque: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(valor);
                Console.WriteLine(conta);

                
                
            }
            catch (DoMainException e)
            {
                Console.WriteLine("Erro em saque: " + e.Message);
            }
            


        }
    }
}
