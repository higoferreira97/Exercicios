using System.Globalization;

namespace ExercicioUm
{
    public class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string? Entidade { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(int numeroDaConta, string? entidade)
        {
            NumeroDaConta = numeroDaConta;
            Entidade = entidade;

        }

        public ContaBancaria(int numeroDaConta, string entidade, double depositoInicial) : this(numeroDaConta, entidade)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.00;
        }



        public override string ToString()
        {
            return "Conta: "
                + NumeroDaConta
                + ",Titular: "
                + Entidade
                + ",Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
