using System.Globalization;

namespace Projeto.Src;

class Funcionario
{
    private string _nome;
    public double SalarioBruto { get; private set; }
    public double Imposto {get; private set; }

    public Funcionario(string nome, double salario, double imposto)
    {
        if (nome != null && nome != "")
        {
            _nome = nome;
        }
        else
        {
            _nome = "Funcionário";
        }

        SalarioBruto = salario;
        Imposto = imposto;
    }

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
            if (value != null && value != "")
            {
                _nome = value;
            }
        }
    }

    public Funcionario(string nome) : this(nome, 3000.0, 150.0) {}

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto+=SalarioBruto*(porcentagem/100.0);
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\n"
            + $"Salário Bruto: $ {SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}\n"
            + $"Salário Líquido: $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}