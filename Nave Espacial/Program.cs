Console.WriteLine("Bem-vindo ao nosso sistema!");
Console.WriteLine("Para começar, digite o número do setor que deseja acessar:");
Console.WriteLine("1 - Tripulantes");
Console.WriteLine("2 - Destinos");
int menu = int.Parse(Console.ReadLine());

if (menu == 1)
{
    //Cade a leitura para cada menu desses tb? Caso ele escolha o cadastro de tripulantes como vc vai saber?
    
    Console.WriteLine("1- Cadastrar Tripulantes");
    Console.WriteLine("2- Listar Tripulantes");

    //Caso seja escolhido deletar, vc tera que pedir o codigo do tripulante correto?
    Console.WriteLine("3- Deletar Tripulantes");
    int submenu = int.Parse(Console.ReadLine());

    if (submenu == 1)
    {
        Console.WriteLine("Cadastro de Tripulantes:");
    }
    else if (submenu == 2)
    {
        Console.WriteLine("Lista de Tripulantes:");

    }
    else if (submenu == 3)
    {
        Console.WriteLine("Deletar Tripulantes:");
    }
}
else if (menu == 2)
{
    //Cade a leitura para cada menu desses tb? Caso ele escolha o cadastro de destinos como vc vai saber?
    
    Console.WriteLine("1- Cadastrar Destinos");
    Console.WriteLine("2- Listar Destinos");
    Console.WriteLine("3- Deletar Destinos");
    int submenu = int.Parse(Console.ReadLine());

    if (submenu == 1)
    {
        Console.WriteLine("Cadastro de Destinos:");
    }
    else if (submenu == 2)
    {
        Console.WriteLine("Lista de Destinos:");

    }
    else if (submenu == 3)
    {
        Console.WriteLine("Deletar Destinos:");
    }
}

else
{
    Console.WriteLine("Entrada inválida");
}
