

using System.Globalization;

namespace ExercicioUm
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.00)
                return true;
            else
                return false;
        }

        public double NotaRestante()
        {
            double NotaMinima = 60.00;

            return  NotaMinima - NotaFinal();

        }

        public override string ToString()
        {
            return "Dados Atualizados:" + " " + "Nome do aluno:" + " " + Nome
                + " " +"Nota final:" + " " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
