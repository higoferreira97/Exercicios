

using System.Globalization;

namespace ExercicioUm
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto =  (SalarioBruto * porcentagem / 100.0) + SalarioBruto ;

        }

        public override string ToString()
        {
            return "Nome:" + Nome + " " 
                + "Salario:" + SalarioBruto.ToString("F2",CultureInfo.InvariantCulture) + " " 
                + "Salario liquido " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
         
        }
    }

    
}
