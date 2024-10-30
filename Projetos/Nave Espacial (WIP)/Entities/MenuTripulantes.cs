using Nave_Espacial.Entities.Enums;

namespace Nave_Espacial.Entities
{
    internal class MenuTripulantes
    {
        public static void ExibirMenuTripulantes()
        {
            Console.WriteLine("1- Cadastrar Tripulantes");
            Console.WriteLine("2- Listar Tripulantes");
            Console.WriteLine("3- Deletar Tripulantes");

            if (Enum.TryParse<OpcaoTripulantes>(Console.ReadLine(), out OpcaoTripulantes submenu))
            {
                switch (submenu)
                {
                    case OpcaoTripulantes.Cadastrar:
                        Console.WriteLine("Cadastro de Tripulantes:");
                        break;
                    case OpcaoTripulantes.Listar:
                        Console.WriteLine("Lista de Tripulantes:");
                        break;
                    case OpcaoTripulantes.Deletar:
                        Console.WriteLine("Deletar Tripulantes:");
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
        }

    }
}
