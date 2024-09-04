using _05___Listas;
using System.Globalization;

Console.WriteLine("Quantos funcionários serão registrados?");
int n = int.Parse(Console.ReadLine());

List<Funcionario> list = new List<Funcionario>();
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Funcionário #" + i + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    list.Add(new Funcionario(id, nome, salario));
    Console.WriteLine();
}

Console.WriteLine("Entre com o Id do funcionário que terá o salário aumentado: ");
int procuraId = int.Parse(Console.ReadLine());

Funcionario func = list.Find(x => x.Id == procuraId);
if (func != null)
{
    Console.Write("Entre com a porcentagem:");
    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    func.AumentarSalario(porcentagem);
}
else
{
    Console.WriteLine("Esse Id não existe");
}

Console.WriteLine();
Console.WriteLine("Lista de funcionários atualizada:");
foreach (Funcionario obj in list) { Console.WriteLine(obj); }
