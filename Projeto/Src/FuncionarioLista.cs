using System.Globalization;

namespace Projeto.Src;

class FuncionarioLista
{
    private readonly List<Funcionario> _lista;

    public FuncionarioLista()
    {
        _lista = [];
    }

    private bool ListaVazia()
    {
        if (_lista.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool FuncionarioExiste(int id)
    {
        foreach (Funcionario f in _lista)
        {
            if (f.Id == id)
            {
                return true;
            }
        }

        return false;
    }

    public bool FuncionarioAdicionado(Funcionario f)
    {
        if (!FuncionarioExiste(f.Id))
        {
            _lista.Add(f);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool SalarioReajustado(int id, double porcentagem)
    {
        Funcionario? f = _lista.Find(funcionario => funcionario.Id == id);

        if (f != null)
        {
            f.AumentarSalario(porcentagem);
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        if (ListaVazia())
        {
            return "Sem funcionários cadastrados.";
        }
        else
        {
            Funcionario primeiro = _lista.First();

            int tamanhoLista = _lista.Count;
            int id = primeiro.Id;
            string nome = primeiro.Nome;
            double salario = primeiro.SalarioLiquido();
            string saida = $"{id}, {nome}, $ {salario.ToString("F2", CultureInfo.InvariantCulture)}";

            if (tamanhoLista > 1)
            {
                List<Funcionario> listaSuplementar = _lista.GetRange(1, tamanhoLista - 1);

                foreach (Funcionario f in listaSuplementar)
                {
                    id = f.Id;
                    nome = f.Nome;
                    salario = f.SalarioLiquido();

                    saida += $"\n{id}, {nome}, $ {salario.ToString("F2", CultureInfo.InvariantCulture)}";
                }
            }

            return saida;
        }
    }
}