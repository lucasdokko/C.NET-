using System;
using System.Globalization;

namespace SaidaDeDados {
    class Program {
        static void Main(string[] args) {

            double saldo = 10.35784;
            int idade = 32;
            string nome = "Maria";

            //PlaceHolders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //concatenação,
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "+ saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    } 

}

