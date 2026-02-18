using System.Globalization;

namespace Projeto.Src;

class Funcionario
{
    public string Nome = "Funcionário";
    public double SalarioBruto;
    public double Imposto;

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