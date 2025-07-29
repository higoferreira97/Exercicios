

namespace ExercicioUm
{
    public class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double DolarParareal(double cotacao,double quantia)
        {

            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }


    }
}
