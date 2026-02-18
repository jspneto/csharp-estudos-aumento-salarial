using System.Globalization;

namespace Projeto.Src.IO;

static class FuncionarioInputs
{
    public static Funcionario CriarFuncionario()
    {
        Funcionario f = new();        

        Console.Write("Nome: ");
        f.Nome = Console.ReadLine()!;
        Console.Write("Salário Bruto: $ ");
        f.SalarioBruto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Imposto aplicado: $ ");
        f.Imposto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        return f;
    }
}