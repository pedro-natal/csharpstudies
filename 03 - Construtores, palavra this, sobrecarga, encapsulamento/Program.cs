using System.Globalization;

namespace _03___Construtores__palavra_this__sobrecarga__encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine()); ;
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoinicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
        }
    }
}
