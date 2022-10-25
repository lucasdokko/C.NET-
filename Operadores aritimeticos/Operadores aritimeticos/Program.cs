using System;

namespace operadoresDeAtribuicao {
    class program {
        static void Main(String[] args) {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10 / 8;


            // calculando a baskara 

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // math.pow pega a base pelo expoente.

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //math.sqrt raiz quadrada

            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);





            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            


        }

    }

}