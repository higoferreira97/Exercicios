
namespace ExercicioUm
{
    public class Calculadora
    {
        //public static double pi = 3.14;
        //public static double Circuferencia(double raio)
        //{
        //    return 2.0 * pi * raio;
        //}

        //public static double Volume(double raio)
        //{
        //    return 4.0 / 3.0 * pi * Math.Pow(raio, 3);
        //}


        //--------------------

        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }

        public static void triplicar(ref int x)
        {
            x = x * 3;
        }

        public static void TriplicarOut(int x, out int result)
        {
            result = x * 3;
        }
    }
}
