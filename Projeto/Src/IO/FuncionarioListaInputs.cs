namespace Projeto.Src.IO;

static class FuncionarioListaInputs
{
    public static Funcionario ColetarNovoIdFuncionario(Funcionario f)
    {
        Console.Write(" Digite um novo ID: ");
        int id = int.Parse(Console.ReadLine()!);

        while (!Funcionario.IdValido(id))
        {
            Console.Write("O ID deve estar entre 1000 e 9999. Digite novamente: ");
            id = int.Parse(Console.ReadLine()!);
        }

        Funcionario funcNovoId = new(id, f.Nome, f.SalarioBruto, f.Imposto);

        return funcNovoId;
    }
}