using System.Globalization;

namespace Projeto.Src;

class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public Funcionario(string nome, double salario, double imposto)
    {
        if (nome != null && nome != "")
        {
            Nome = nome;
        }
        else
        {
            Nome = "Funcionário";
        }

        SalarioBruto = salario;
        Imposto = imposto;
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