using System.Globalization;

namespace Projeto.Src.IO;

static class FuncionarioInputs
{
    public static Funcionario CriarFuncionario()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine()!);

        while (!Funcionario.IdValido(id))
        {
            Console.Write("O ID deve estar entre 1000 e 9999. Digite novamente: ");
            id = int.Parse(Console.ReadLine()!);
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Salário Bruto: $ ");
        double salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Imposto aplicado: $ ");
        double imposto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                
        Funcionario f = new(id, nome, salario, imposto);
        
        return f;
    }
}