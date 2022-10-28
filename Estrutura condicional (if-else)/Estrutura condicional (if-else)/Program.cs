using System;

namespace operadorescomparativos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("Par!");
            } else {
                Console.WriteLine("Impar!");


            }


            Console.WriteLine("Qual hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom Dia !");
            } else if (hora < 18) {
                Console.WriteLine("Boa Tarde!");
            } else {
                Console.WriteLine("Boa noite");
            }

        }
    }
}