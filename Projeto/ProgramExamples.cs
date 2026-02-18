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
}