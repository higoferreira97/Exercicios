using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Transactions;



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

            //double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            //Console.WriteLine("Informe os valores correspondentes");
            //string[] valores = Console.ReadLine().Split(' ');
            //A = double.Parse(valores[0]);
            //B = double.Parse(valores[1]);
            //C = double.Parse(valores[2]);
            //Console.Clear();


            //triangulo = A * C / 2.0;
            //circulo = 3.14159 * C * C;
            //trapezio = (A + B ) /2.0 * C;
            //quadrado = B * B;
            //retangulo = A * B;

            //Console.WriteLine(triangulo.ToString("F3",CultureInfo.InvariantCulture));
            //Console.WriteLine(circulo.ToString("F3",CultureInfo.InvariantCulture));
            //Console.WriteLine(trapezio.ToString("F3",CultureInfo.InvariantCulture));
            //Console.WriteLine(quadrado.ToString("F3",CultureInfo.InvariantCulture));
            //Console.WriteLine(retangulo.ToString("F3",CultureInfo.InvariantCulture));

            //--------------------------------------------------------------------------------

            //Console.WriteLine("Informe um horário");
            //int hora = int.Parse(Console.ReadLine());

            //if (hora >= 5 && hora <=11)
            //{
            //    Console.WriteLine("Bom dia");
            //}
            //else if (hora >= 12 && hora <18)
            //{
            //    Console.WriteLine("Boa tarde");
            //}

            //else 
            //{
            //    Console.WriteLine("Boa noite");
            //}

            //--------------------------------------------------------------------------------
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            //Console.WriteLine("Informe um número para saber se é verdadeiro ou falso");

            //int numero = int.Parse(Console.ReadLine());

            //if (numero >= 0) 
            //{
            //    Console.WriteLine("Número positivo");
            //}

            //else
            //{
            //    Console.WriteLine("Número negativo");
            //}

            //--------------------------------------------------------------------------------
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar

            //Console.WriteLine("Informe um número para saber se é par ou impar");

            //int numero = int.Parse(Console.ReadLine());

            //if (numero % 2 == 0)
            //{

            //    Console.WriteLine("Par");
            //}

            //else 
            //{
            //    Console.WriteLine("Impar");
            //}


            //--------------------------------------------------------------------------------

            //Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            //ordem crescente ou decrescente

            //Console.WriteLine("Verifique se os número são miultiplos");

            //int A, B;
            //string[] valores = Console.ReadLine().Split(' ');
            // A = int.Parse(valores[0]);
            // B = int.Parse(valores[1]);

            //if (A % B == 0 || B % A == 0)
            //    Console.WriteLine("São multiplos");

            //else
            //    Console.WriteLine("Não são multiplos");

            //--------------------------------------------------------------------------------

            //Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            //Console.WriteLine("Informe a hora de inicio:");
            //int horaInicio = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Informe a final do jogo:");
            //int horaFinal = int.Parse(Console.ReadLine());
            //Console.Clear();

            //int duracao;
            //if (horaInicio < horaFinal)

            //    duracao = horaFinal - horaInicio;

            //else
            //    duracao = 24 - horaInicio + horaFinal;

            //Console.WriteLine($"o jogo durou: {duracao} horas.");

            //--------------------------------------------------------------------------------
            //escreva um programa que leia o código de um item e a quantidade deste item.A
            //seguir, calcule e mostre o valor da conta a pagar

            //Console.WriteLine("Informe o código do produto e a quantidade");
            //string[] valores = Console.ReadLine().Split(' ');

            //int codigo = int.Parse(valores[0]);
            //int quantidade = int.Parse(valores[1]);

            //double total;
            //if (codigo == 1)
            //    total = quantidade * 4.00;

            //else if (codigo == 2)
            //    total = quantidade * 4.50;

            //else if (codigo == 3)
            //    total = quantidade * 5.00;

            //else if (codigo == 4)
            //    total = quantidade * 2.00;

            //else
            //    total = quantidade * 1.50;

            //Console.WriteLine("O valor total é: " + total.ToString("F2",CultureInfo.InvariantCulture));

            //--------------------------------------------------------------------------------

            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            //seguintes intervalos([0, 25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            //nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”

            //Console.WriteLine("insira um valor");
            //double valor = double.Parse(Console.ReadLine());
            //Console.Clear();



            //if (valor < 0.0 || valor > 100.0)
            //    Console.WriteLine("Fora de intervalo");

            //else if (valor <= 25.0)
            //    Console.WriteLine("O intervalor é: [0,25]");

            //else if (valor <= 50.0)
            //    Console.WriteLine("O intervalo é: [25,50]");

            //else if (valor <= 75.0)
            //    Console.WriteLine("O intervalo é: [50,75]");

            //else if (valor <= 100.0)
            //    Console.WriteLine("O intervalo é: [75,100]");

            //----------------------------------------------------------------
            //Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            //de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            //ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            //Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            //Exemplo
            //Entrada: 4.5 - 2.2
            //Saida: Q4

            //string[] valores = Console.ReadLine().Split(' ');
            //double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            //if (x == 0.0 && y == 0.0)
            //    Console.WriteLine("Origem");

            //else if (x == 0.0)
            //    Console.WriteLine("Eixo Y");

            //else if (y == 0.0)
            //    Console.WriteLine("Eixo X");

            //else if (x > 0.0 && y > 0.0)
            //    Console.WriteLine("Q1");

            //else if (x < 0.0 && y > 0.0)
            //    Console.WriteLine("Q2");

            //else if (x < 0.0 && y < 0.0)
            //    Console.WriteLine("Q3");


            //else
            //    Console.WriteLine("Q4");



            //--------------------------------------------------------------------------------
            //Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            //que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            //qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.
            //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            //mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
            //Renda:
            // 0.00 - 2000.00  Insento
            //2000.01 - 3000.00  8%
            //3000.01 - 4500.00 18%
            //Acima de 4500 28%

            //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8 % apenas sobre R$ 1000.00, pois a faixa de
            //salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é
            //de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.O valor deve ser impresso com
            //duas casas decimais.

            //Console.WriteLine("Informe seu salário para ver o quanto você vai pagar de imposto");
            //double salario = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);

            //double imposto;
            //if (salario < 2000.0)
            //    imposto = 0.0;

            //else if (salario <= 3000.0)
            //    imposto = (salario - 2000.0) * 0.08;

            //else if (salario <= 4500.0)
            //    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;

            //else
            //    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

            //if (imposto == 0.0)
            //    Console.WriteLine("Isento");

            //else
            //    Console.WriteLine($"R${imposto.ToString("F2", CultureInfo.InvariantCulture)}");





            //--------------------------------------------------------------------------------
            //While
            //Console.Write("Digite um número:");
            //double x = double.Parse(Console.ReadLine());
            //Console.Clear();

            //while (x >= 0)
            //{

            //    double raiz = Math.Sqrt(x);

            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

            //    Console.Write("Digite outro número.");
            //    x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //    Console.Clear();
            //}

            //Console.WriteLine("Número negativo");

            //--------------------------------------------------------------------------------
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            //Console.Write("Digite a senha");
            //int senha = int.Parse(Console.ReadLine());
            //Console.Clear();

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha incorreta!\nTente novamente.");
            //    senha = int.Parse(Console.ReadLine());
            //    Console.Clear();
            //}
            //Console.WriteLine("Acesso concedido.");

            //--------------------------------------------------------------------------------
            //Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
            //cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            //menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).

            //string[] valores = Console.ReadLine().Split(' ');
            //int x = int.Parse(valores[0]);
            //int y = int.Parse(valores[1]);

            //while (x != 0 && y != 0)
            //{
            //    if (x > 0 && y > 0)
            //        Console.WriteLine("Primeiro");

            //    else if (x < 0 && y > 0)
            //        Console.WriteLine("Segundo");

            //    else if (x < 0 && y < 0)
            //        Console.WriteLine("Terceiro");

            //    else
            //        Console.WriteLine("Quarto");

            //    valores = Console.ReadLine().Split(' ');

            //    x = int.Parse(valores[0]);
            //    y = int.Parse(valores[1]);


            //}




            //--------------------------------------------------------------------------------
            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.Escreva
            //um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            //que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            //exemplo



            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;

            //int tipo = int.Parse(Console.ReadLine());


            //while (tipo != 4)
            //{
            //    if (tipo == 1)
            //       alcool = alcool + 1;

            //    else if (tipo == 2)
            //        gasolina = gasolina + 1;

            //    else if (tipo == 3);
            //        diesel = diesel + 1;

            //    tipo = int.Parse(Console.ReadLine());


            //}

            //Console.WriteLine("Muito Obrigado");
            //Console.WriteLine("Àlcool" + alcool);
            //Console.WriteLine("Gasolina" + gasolina);
            //Console.WriteLine("Diesel" + diesel);






            //--------------------------------------------------------------------------------]
            //for

            //Console.Write("Quantos números inteiros você vai digitar?: ");
            //int n = int.Parse(Console.ReadLine());

            //int soma = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write("Valor #{0}: ",i ); 
            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}
            //Console.WriteLine("Soma igual a:" + soma);


            //-------------------------------------------------------------
            //Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            //  X, se for o caso.

            //Console.Write("Informe um número: ");
            //int x = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= x; i++) 
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}

            //----------------------------------------------------------------
            //Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            //Console.Write("Informe um número");
            //int N = int.Parse(Console.ReadLine());

            //int cont_in = 0;
            //int cont_out = 0;
            //for (int i = 0; i < N; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    if (x >= 10 && x <= 20)
            //        cont_in = cont_in + 1;

            //    else
            //        cont_out = cont_out + 1;

            //}

            //Console.WriteLine("Valores dentro do intervalo: " + cont_in);
            //Console.WriteLine("Valores fora do intervalo: " + cont_out);


            //----------------------------------------------------------------
            //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            //de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            //conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            //peso 5.

            //int N = int.Parse(Console.ReadLine());

            //for (int i = 0; i < N; i ++)
            //{
            //    string[] line = Console.ReadLine().Split(' ');

            //    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            //    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
            //    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

            //    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}



            //----------------------------------------------------------------
            //Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            //segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".



            //Console.Write("Informe um número: ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{
            //    string[] line = Console.ReadLine().Split(' ');
            //    int x = int.Parse(line[0]);
            //    int y = int.Parse(line[1]);

            //    if (y == 0)

            //        Console.WriteLine("Divisão impossivel");

            //    else
            //    {
            //        double div = (double) x / y;
            //        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
            //    }

            //}

            //----------------------------------------------------------------
            //exercício para calcular a área de um triângulo X e um triângulo Y e mostrar qual deles tem a maior área
            // Sem usar orientação a objetos

            //double xA, xB, xC, yA, yB, yC;
            //Console.WriteLine("Entre com as medidas do triângulo X: ");

            //xA  = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //xB  = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //xC  = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y: ");

            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Console.WriteLine($"A area de X = : {areaX.ToString("F4",CultureInfo.InvariantCulture )}");
            //Console.WriteLine($"A area de Y = : {areaY.ToString("F4",CultureInfo.InvariantCulture )}");


            //if (areaX > areaY)
            //    Console.WriteLine("Maior area: X");

            //else
            //    Console.WriteLine("Maior área: Y");



            //----------------------------------------------------------------
            //exercício para calcular a área de um triângulo X e um triângulo Y e mostrar qual deles tem a maior área
            // Usando orientação a objetos

            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triângulo X: ");

            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y: ");

            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (x.A + x.B + x.C) / 2.0;
            //double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //p = (y.A + y.B + y.C) / 2.0;
            //double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            //Console.WriteLine($"A area de X = : {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"A area de Y = : {areaY.ToString("F4", CultureInfo.InvariantCulture)}");


            //if (areaX > areaY)
            //    Console.WriteLine("Maior area: X");

            //else
            //    Console.WriteLine("Maior área: Y");

            //----------------------------------------------------------------
            //Capítulo: Introdução à Programação Orientada a Objetos
            //Primeiros exercícios
            //EXERCÍCIO 01:
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            //velha

            //Pessoa pessoa01, pessoa02;
            //pessoa01 = new Pessoa();
            //pessoa02 = new Pessoa();

            //Console.WriteLine("Informe o nome da primeira pessoa:");         
            //pessoa01.Nome = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Informe a idade da primeira pessoa:");
            //pessoa01.Idade = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Informe o nome da segunda pessoa:");           
            //pessoa02.Nome = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Informe a idade da segunda pessoa:");
            //pessoa02.Idade = int.Parse(Console.ReadLine());
            //Console.Clear();

            //if (pessoa01.Idade > pessoa02.Idade)
            //    Console.WriteLine($"A pessoa mmais velha é: {pessoa01.Nome}");
            //else
            //    Console.WriteLine($"A pessoa mais velha é: {pessoa02.Nome}");

            //----------------------------------------------------------------
            //EXERCÍCIO 02:
            //Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar o salário
            //médio dos funcionários.


            //Funcionario f1 = new Funcionario();
            //Funcionario f2 = new Funcionario();

            //Console.WriteLine("Informe o nome do primeiro funcionário:");
            //f1.Nome = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Informe o salário do primeiro funcionário:");
            //f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.Clear();

            //Console.WriteLine("Informe o nome do segundo funcionário:");
            //f2.Nome = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Informe o salário do segundo funcionário:");
            //f2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.Clear();

            //double media = (f1.Salario + f2.Salario) / 2.0;

            //Console.WriteLine("O salário médio dos funcionários é: " + media.ToString("F2",CultureInfo.InvariantCulture));

            //----------------------------------------------------------------
            //Refeito o exercicio do Triangulo^~Triangulo, mas usando a logica dentro da classe Triangulo

            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triângulo X: ");

            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y: ");

            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double areaX = x.Area();

            //double areaY = y.Area();

            //Console.WriteLine($"A area de X = : {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"A area de Y = : {areaY.ToString("F4", CultureInfo.InvariantCulture)}");


            //if (areaX > areaY)
            //    Console.WriteLine("Maior area: X");

            //else
            //    Console.WriteLine("Maior área: Y");


            //----------------------------------------------------------------
            //Exercicio para mostrar dados de um produto adicionando mais produtos e removendo

            //Produto produto = new Produto();
            //Console.WriteLine("Entre com os dados do produto: ");
            //Console.Write("Nome:");
            //produto.Nome = Console.ReadLine();
            //Console.Write("Preço:");
            //produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade:");
            //produto.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto:" + produto);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //produto.AdicionarProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados " + produto);

            //Console.WriteLine();
            //Console.Write("Digite o núemro de produtos a ser removidos: ");
            //qte = int.Parse(Console.ReadLine());
            //produto.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados " + produto);

            //---------------------------------------------

            //Fazer um programa para ler os valores da largura e altura
            //de um retângulo. Em seguida, mostrar na tela o valor de
            //sua área, perímetro e diagonal.Usar uma classe como
            //mostrado no projeto ao lado.

            //Retangulo retangulo = new Retangulo();

            //Console.Write("Informe a largura do Retângulo: ");
            //retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.WriteLine();

            //Console.Write("Informe a altura do Retângulo: ");
            //retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.WriteLine();

            //Console.WriteLine("Dados Atualizados: " + retangulo);

            //-----------------------------------------------------------------------

            //Fazer um programa para ler os dados de um funcionário(nome,
            //salário bruto e imposto). Em seguida, mostrar os dados do
            //funcionário(nome e salário líquido).Em seguida, aumentar o salário
            //do funcionário com base em uma porcentagem dada(somente o
            //salário bruto é afetado pela porcentagem) e mostrar novamente os
            //dados do funcionário.Use a classe projetada abaixo.

            Funcionario funcionario = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Informe o salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Agora informe o imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + funcionario);
            Console.WriteLine();

            Console.Write("Agora adicione um aumento percentual de salário: ");
            double percntual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(percntual);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + funcionario);















        }

    }
}



