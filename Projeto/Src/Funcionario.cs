using System.Globalization;

namespace Projeto.Src;

class Funcionario
{
    private string _nome;
    public int Id { get; private set; }
    public double SalarioBruto { get; private set; }
    public double Imposto { get; private set; }

    public Funcionario(int id, string nome, double salario, double imposto)
    {
        if (NomeValido(nome))
        {
            _nome = nome;
        }
        else
        {
            _nome = "Funcionário";
        }

        if (IdValido(id))
        {
            Id = id;
        }
        else
        {
            Id = 1000;
        }

        SalarioBruto = ValidarSalario(salario);
        Imposto = ValidarImposto(imposto);
    }

    public Funcionario(string nome) : this(1000, nome, 3000.0, 150.0) {}

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

    public static bool IdValido(int id)
    {
        if (id >= 1000 && id <= 9999)
        {
            return true;
        }
        else
        {
            return false;
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
        return $"ID: {Id}\n" 
            + $"Nome: {Nome}\n"
            + $"Salário Bruto: $ {SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}\n"
            + $"Salário Líquido: $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}