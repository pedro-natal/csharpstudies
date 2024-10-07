class Exercicio2
{
    static int ContaOcorrencias(string str)
    {
        int count = 0;
        foreach (char c in str.ToLower())
        {
            if (c == 'a')
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.Write("Informe uma string: ");
        string input = Console.ReadLine();

        int count = ContaOcorrencias(input);
        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' ocorre {count} vezes na string informada.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não ocorre na string informada.");
        }
    }
}
