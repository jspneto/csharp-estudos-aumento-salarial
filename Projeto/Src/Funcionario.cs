using System.Globalization;

namespace Projeto.Src;

class Funcionario
{
    private string _nome;
    public double SalarioBruto { get; private set; }
    public double Imposto {get; private set; }

    public Funcionario(string nome, double salario, double imposto)
    {
        if (NomeValido(nome))
        {
            _nome = nome;
        }
        else
        {
            _nome = "Funcionário";
        }

        SalarioBruto = ValidarSalario(salario);
        Imposto = ValidarImposto(imposto);
    }

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
            if (NomeValido(value))
            {
                _nome = value;
            }
        }
    }

    public Funcionario(string nome) : this(nome, 3000.0, 150.0) {}

    private static bool NomeValido(string nome)
    {
        if (nome != null && nome != "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static double ValidarSalario(double salario)
    {
        if (salario >= 1000.0)
        {
            return salario;
        }
        else
        {
            return 1000.0;
        }
    }

    private static double ValidarImposto(double imposto)
    {
        if (imposto >= 0.0 && imposto <= 1000.0)
        {
            return imposto;
        }
        else
        {
            return 0.0;
        }
    }

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
        if (porcentagem > 0.0)
        {
            SalarioBruto += SalarioBruto*(porcentagem/100.0);
        }
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\n"
            + $"Salário Bruto: $ {SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}\n"
            + $"Salário Líquido: $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}