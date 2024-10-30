using Nave_Espacial.Entities;
using Nave_Espacial.Entities.Enums;

Console.WriteLine("Bem-vindo ao nosso sistema!");
Console.WriteLine("Para começar, digite o número do setor que deseja acessar:");
Console.WriteLine("1 - Tripulantes");
Console.WriteLine("2 - Destinos");


if (Enum.TryParse<OpcaoMenu>(Console.ReadLine(), out OpcaoMenu menu))
{
    switch (menu)
    {
        case OpcaoMenu.Tripulantes:
            MenuTripulantes.ExibirMenuTripulantes();
            break;
        case OpcaoMenu.Destinos:
            MenuDestinos.ExibirMenuDestinos();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
else
{
    Console.WriteLine("Opção inválida");
}
