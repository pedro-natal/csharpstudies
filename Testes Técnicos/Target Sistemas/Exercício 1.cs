class Exercicio1
{
    static bool ChecarFibonacci(int num)
    {
        int a = 0, b = 1;
        while (b < num)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == num || num == 0;
    }

    static void Main(string[] args)
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (ChecarFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }
}
