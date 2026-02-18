using System.Globalization;

namespace Projeto.Src.IO;

static class FuncionarioInputs
{
    public static Funcionario CriarFuncionario()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Salário Bruto: $ ");
        double salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Imposto aplicado: $ ");
        double imposto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Funcionario f = new(nome, salario, imposto);
        
        return f;
    }
}