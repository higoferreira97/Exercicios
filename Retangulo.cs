

using System.Globalization;

namespace ExercicioUm
{
    class Retangulo
    {
        public double Largura;
        public double Altura;
        

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2.0;
        }

        public double Diagonal()
        {
            Largura = Math.Pow(Largura, 2);
            Altura = Math.Pow(Altura, 2);

            double calculo = Largura + Altura;
            double diagonal = Math.Sqrt(calculo);

            return diagonal;

        }

        public override string ToString()
        {
            return "Area:"+Area().ToString("F2",CultureInfo.InvariantCulture) +" "
            +"Perimetro:" + Perimetro().ToString("F2",CultureInfo.InvariantCulture) + " "
            + "Diagonal:" + Diagonal().ToString("F2",CultureInfo.InvariantCulture);

        }

    }
}
