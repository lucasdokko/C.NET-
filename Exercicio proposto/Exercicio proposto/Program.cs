using System;
using System.Globalization;


namespace curso {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo : ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuarto = int.Parse( Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre seu último nome,idade e altura(mesma linha):");
            String [] vet = (Console.ReadLine().Split(' '));

            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


           





            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuarto);
            Console.WriteLine(precoProduto);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
