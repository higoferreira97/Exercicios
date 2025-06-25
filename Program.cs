using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;



namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double media = 53.234567;



            //Console.WriteLine($"Produtos:\n{produto1}, cujo o preço é: {preco1}\n{produto2}, cujo o preço é: {preco2.ToString("F2")} ");
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine($"Registro:\n{idade} anos de idade, código: {codigo} e genero: {genero}");
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine($"Media com oito casas decimais: {media.ToString("F8")}");
            //Console.WriteLine($"Arredondando(três casas decimais):{media.ToString("F3")}");
            //Console.WriteLine($"separador decimal invariante culture:{media.ToString(CultureInfo.InvariantCulture)}");

            //-----------------------------------------------------------------------------

            //double a = 1.0, b = -3.0, c = -4.0;

            //double delta = Math.Pow(b, 2.0)- 4.0 * a * c;

            //double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            //Console.WriteLine(delta);
            //Console.WriteLine(x1);
            //---------------------------------------------------------------
            //Console.WriteLine("Informe a frase");
            //string frase = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Informe a primeira cor");
            //string x = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Informe a segunda cor");
            //string y = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Informe a terceira cor");
            //string z = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Informe a quarta cor");
            //string a = Console.ReadLine();
            //Console.Clear();;

            //Console.WriteLine("Informe a quinta cor");
            //string b = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Informe a sexta cor");
            //string c = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine($"{frase}\n {x}\n {y}\n {z}\n {a}\n {b}\n {c}");


            //---------------------------------------------------------

            //Console.WriteLine("Digite o nome de três frutas");

            //string[] vet = Console.ReadLine().Split(' ');
            //string p1 = vet[0];
            //string p2 = vet[1];
            //string p3 = vet[2];
            //Console.Clear(); 
            //Console.WriteLine($"{p1}\n{p2}\n{p3}");

            //---------------------------------------------------------

            //Console.WriteLine("Informe sua idade");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Informe seu gênero:  M para Masculino e F para feminino");
            //char ch = char.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Informe sua altura");
            //double n2  = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.Clear();

            //string[] vet = Console.ReadLine().Split(' ');
            //Console.Clear();

            //string nome  = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade  = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3],CultureInfo.InvariantCulture);
            //Console.Clear();




            //Console.WriteLine("Sua idade é: " + n1);
            //Console.WriteLine("Seu gênero é: " + ch);
            //Console.WriteLine("Sua altura é: " + n2);
            //Console.WriteLine($"{nome} {sexo} {idade} {altura.ToString("F2",CultureInfo.InvariantCulture)}");

            //---------------------------------------------------------

            //Console.WriteLine("entre com seu nome completo:");
            //string nome  = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Quantos quartos tem na sua casa?:");
            //sbyte quantQuartos = sbyte.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Entre com o preço de um produto:");
            //float preco = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.Clear();

            //Console.WriteLine("Entre com seu último nome, idade e altura na mesma linha:");
            //string[] vet = Console.ReadLine().Split(' ');
            //Console.Clear();

            //string ultimoNome = vet[0];
            //sbyte idadeVet = sbyte.Parse(vet[1]);
            //float altura = float.Parse(vet[2],CultureInfo.InvariantCulture);

            //Console.WriteLine($"{nome}\n{quantQuartos}\n{preco.ToString("F2")}\n{ultimoNome} {idadeVet} {altura}");

            //---------------------------------------------------------
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            //casas decimais conforme exemplos.
            //Fórmula da área: area = π.raio2
            //Considere o valor de π = 3.14159


            //double R, A, pi = 3.14159;
            //Console.WriteLine("Insira o valor do raio do círculo:");
            //R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Clear();

            //A = pi * R * R;

            //Console.WriteLine("O valor do raio do círculo informado é:" + A.ToString("F4", CultureInfo.InvariantCulture));

            //---------------------------------------------------------
            //Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            //Console.WriteLine("Insira o primeiro valor:");
            //int A  = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Insira o segundo valor:");
            //int B  = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Insira o terceiro valor:");
            //int C  = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Insira o quarto valor:");
            //int D  = int.Parse(Console.ReadLine());
            //Console.Clear();

            //int diferenca = A * B - C * D;

            //Console.WriteLine("A diferença do produto é:" + diferenca);

            //---------------------------------------------------------
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais.


            //Console.WriteLine("Informe o número da sua matrícula");
            //int matricula = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Informe o núemro de horas trabalhadas");
            //double horasTrabalhada = double.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Informe o valor ganho por hora");
            //double valorHora = double.Parse(Console.ReadLine());
            //Console.Clear();

            //double salario = horasTrabalhada * valorHora;

            //Console.WriteLine($"Matrícula: {matricula}\nSalário: R${salario.ToString("F2")}");

            //---------------------------------------------------------
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago


            //int cod1, cod2, qte1, qte2;
            //double preco1, preco2, total;

            //Console.WriteLine("Insira o código, quantidade e preço do produto 01");
            //string[] valores = Console.ReadLine().Split(' ');
            //cod1 = int.Parse(valores[0]);
            //qte1 = int.Parse(valores[1]);
            //preco1 = double.Parse(valores[2],CultureInfo.InvariantCulture);
            //Console.Clear();

            //Console.WriteLine("Insira o código, quantidade e preço do produto 02");
            //valores = Console.ReadLine().Split(' ');
            //cod2 = int.Parse(valores[0]);
            //qte2 = int.Parse(valores[1]);
            //preco2 = double.Parse(valores[2],CultureInfo.InvariantCulture);
            //Console.Clear();

            //total = (qte1 * preco1) + (qte2 * preco2);

            //Console.WriteLine("O valor a ser pago é: R$"+total.ToString("F2",CultureInfo.InvariantCulture));

            //---------------------------------------------------------
            //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e
            //mostre:
            //a) a área do triângulo retângulo que tem A por base e C por altura.
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B.

            // entrada 3.0 4.0 5.2

            // saida:
            //TRIANGULO: 7.800
            //CIRCULO: 84.949
            //TRAPEZIO: 18.200
            //QUADRADO: 16.000
            //RETANGULO: 12.000



            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Informe os dados de entrada");
            string[] areas = Console.ReadLine().Split(' ');
            A = double.Parse(areas[0],CultureInfo.InvariantCulture);
            B = double.Parse(areas[1],CultureInfo.InvariantCulture);
            C = double.Parse(areas[2],CultureInfo.InvariantCulture);
            Console.Clear();

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;


            Console.WriteLine("Triângulo: " + triangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: " + circulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: " + trapezio.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + retangulo.ToString("F3",CultureInfo.InvariantCulture));







        }
    }
}



