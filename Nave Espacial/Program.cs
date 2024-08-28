Console.WriteLine("Bem-vindo ao nosso sistema!");
Console.WriteLine("Para começar, digite o número do setor que deseja acessar:");
Console.WriteLine("1 - Tripulantes");
Console.WriteLine("2 - Destinos");
int menu = int.Parse(Console.ReadLine());

if (menu == 1)
{
    Console.WriteLine("1- Cadastrar Tripulantes");
    Console.WriteLine("2- Listar Tripulantes");
    Console.WriteLine("3- Deletar Tripulantes");
}
else
{
    Console.WriteLine("1- Cadastrar Destinos");
    Console.WriteLine("2- Listar Destinos");
    Console.WriteLine("3- Deletar Destinos");
}
