using System.Globalization;
using Projeto.Src;
using Projeto.Src.IO;

static class ProgramExamples
{
    public static void SolucaoProblema()
    {
        FuncionarioLista lista = new();

        Console.Write("Entre com o número de funcionários: ");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < numero; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Entre com os dados do {i+1}º funcionário: ");
            Funcionario f = FuncionarioInputs.CriarFuncionario();

            while (!lista.FuncionarioAdicionado(f))
            {
                Console.Write($"Já existe um funcionário com o ID {f.Id}.");
                Funcionario funcNovoId = FuncionarioListaInputs.ColetarNovoIdFuncionario(f);
                f = funcNovoId;
            }
        }

        Console.WriteLine();
        Console.Write("Informe um percentual para aumento salarial: ");
        double porcentagem = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Informe o ID do funcionário cujo salário sofrerá reajuste: ");
        int id = int.Parse(Console.ReadLine()!);

        if (!lista.SalarioReajustado(id, porcentagem))
        {
            Console.WriteLine();
            Console.WriteLine($"O funcionário de ID {id} não foi encontrado. Abortando operação.");
        }

        Console.WriteLine();
        Console.WriteLine("Lista de funcionários: ");
        Console.WriteLine(lista.ToString());
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