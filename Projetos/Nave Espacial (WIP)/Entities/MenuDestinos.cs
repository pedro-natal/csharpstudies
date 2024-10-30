using Nave_Espacial.Entities.Enums;

namespace Nave_Espacial.Entities
{
    internal class MenuDestinos
    {
        public static void ExibirMenuDestinos()
        {
            Console.WriteLine("1- Cadastrar Destinos");
            Console.WriteLine("2- Listar Destinos");
            Console.WriteLine("3- Deletar Destinos");

            if (Enum.TryParse<OpcaoDestinos>(Console.ReadLine(), out OpcaoDestinos submenu))
            {
                switch (submenu)
                {
                    case OpcaoDestinos.Cadastrar:
                        Console.WriteLine("Cadastro de Destinos:");
                        break;
                    case OpcaoDestinos.Listar:
                        Console.WriteLine("Lista de Destinos:");
                        break;
                    case OpcaoDestinos.Deletar:
                        Console.WriteLine("Deletar Destinos:");
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
