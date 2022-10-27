using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;


namespace curso {
    class Program {
        static void Main(string[] args) {

            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.
            Console.WriteLine("Entrada");
           int a = int.Parse( Console.ReadLine());

            Console.WriteLine("Entrada");
           int b = int.Parse( Console.ReadLine());

            int c = a + b;

            Console.WriteLine("Saida");
            Console.WriteLine(c);

            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
            Console.WriteLine("Entrada");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double pi = 3.14159D;
            double area = pi * Math.Pow(raio,2.0);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));

            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            Console.WriteLine("Digite o vaalor de A");
            int ab = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            int ba = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C");
            int ca = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D");
            int da = int.Parse(Console.ReadLine());
            
            int diferenca = (ab * ba- ca * da);

            Console.WriteLine("Saida");
            Console.WriteLine(diferenca);


            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
            Console.WriteLine("Numero do Funcionario:");
            int number = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("Hora trabalhadas");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor que recebe por hora");
            double valorPorhora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salario = horasTrabalhadas * valorPorhora;

            Console.WriteLine(number);
            Console.WriteLine(salario.ToString("F2",CultureInfo.InvariantCulture));

            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago
            Console.WriteLine("Digite o codigo da peça 1 , quantidade de peças, valor da peça");
            string[] vet = Console.ReadLine().Split( );
            int codPeca = int.Parse(vet[0]);
            int qtdPeca = int.Parse(vet[1]);
            double valorPeca = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double totalPeca1 = qtdPeca * valorPeca;

            Console.WriteLine("Digite o codigo da peça 2 , quantidade de peças, valor da peça");
            String [] vet1 = Console.ReadLine().Split();
            int codPeca2 = int.Parse(vet1[0]);
            int qtdPeca2 = int.Parse(vet1[1]);
            double valorPeca2 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            double totalPeca2 = qtdPeca2 * valorPeca2;


            double total = totalPeca1 + totalPeca2;

            Console.WriteLine("Valor a pagar");
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));


            //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            //a) a área do triângulo retângulo que tem A por base e C por altura.


            Console.WriteLine("Digite a base do triangulo (A) e a altura (B):");
            String[] vetor = Console.ReadLine().Split();
            double base1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double altura = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            double areaTriangulo = (base1 * altura) / 2;

            //b) a área do círculo de raio C. (pi = 3.14159)
            Console.WriteLine("Digite o Raio do circulo(C)");
            double raio1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi2 = 3.14159D;
            double area1 = pi2 * (Math.Pow(raio1, 2.0));


            //c) a área do trapézio que tem A e B por bases e C por altura.
            Console.WriteLine("Digite a base menor (A) a base maior (B) e a altura do trapézio (C) para calcular a area:");
            String[] vet2 = Console.ReadLine().Split();
            Double bMenor = Double.Parse(vet2[0], CultureInfo.InvariantCulture);
            Double bMaior = Double.Parse(vet2[1], CultureInfo.InvariantCulture);
            Double hAltura = Double.Parse(vet2[2], CultureInfo.InvariantCulture);
            double areaTrapezio = ((bMaior + bMenor) * hAltura) / 2;



            //d) a área do quadrado que tem lado B.
            Console.WriteLine("Digite um lado do quadrado para calcular a area (B):");
            Double i = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Double areaQuadrado = Math.Pow(i, 2.0);


            //e) a área do retângulo que tem lados A e B.
            Console.WriteLine("Digite a base (A) e a altura (B do retangulo)");
            String[] vet3 = Console.ReadLine().Split();
            double aba = double.Parse(vet3[0], CultureInfo.InvariantCulture);
            double caa = double.Parse(vet3[1], CultureInfo.InvariantCulture);

            double areaRetangulo = aba * caa;

            Console.WriteLine("Area do triangulo:" + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do circulo:" + area1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Trapezio:" + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do quadrado:" + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area di retangulo:" + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));












        }
    }
}
