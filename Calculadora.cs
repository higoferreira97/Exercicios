﻿
namespace ExercicioUm
{
    public class Calculadora
    {
        public static double pi = 3.14;
        public static double Circuferencia(double raio)
        {
            return 2.0 * pi * raio;
        }

        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * pi * Math.Pow(raio, 3);
        }
    }
}
