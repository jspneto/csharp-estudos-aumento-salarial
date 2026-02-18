using System.Globalization;
using Projeto.Src;
using Projeto.Src.IO;

static class ProgramExamples
{
    public static void SolucaoProblema()
    {
        Console.WriteLine("Entre com os dados do funcionário:");
        Funcionario f = FuncionarioInputs.CriarFuncionario();
        
        Console.WriteLine();
        Console.WriteLine("Dados do funcionário:");
        Console.WriteLine(f.ToString());

        Console.WriteLine();
        Console.Write("Informe o percentual de aumento: ");
        double porcentagem = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        f.AumentarSalario(porcentagem);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados:");
        Console.WriteLine(f.ToString());
    }

    public static void ExemploConstrutores()
    {
        Console.WriteLine("Exemplo de uso de Construtores");

        Console.WriteLine();
        Console.WriteLine("[Construtor Completo] — Entre com os dados do primeiro funcionário: ");
        Funcionario f1 = FuncionarioInputs.CriarFuncionario();
        
        Console.WriteLine();
        Console.Write("[Construtor Parcial] — Entre com o nome do segundo funcionário: ");
        string nome = Console.ReadLine()!;
        Funcionario f2 = new(nome);

        Console.WriteLine();
        Console.WriteLine(f1.ToString());
        Console.WriteLine();
        Console.WriteLine(f2.ToString());
    }

    public static void ExemploEncapsulamento()
    {
        Console.WriteLine("Exemplo de uso de Encapsulamento");

        Console.WriteLine();
        Console.WriteLine("Entre com os dados do funcionário:");
        Funcionario f = FuncionarioInputs.CriarFuncionario();
        Console.WriteLine();
        Console.WriteLine(f.ToString());

        Console.WriteLine();
        Console.Write("Atualize o nome do funcionário: ");
        f.Nome = Console.ReadLine()!;
        Console.WriteLine();
        Console.WriteLine(f.ToString());
    }
}