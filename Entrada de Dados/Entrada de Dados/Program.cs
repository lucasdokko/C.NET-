using System;

namespace entradadedados {
    class program {
        static void Main(String[] args) {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();

            string[] v = s.Split(' '); // .split vai ler  o espaço branco e sera armazenado no vetor
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você Digitiou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);   



        }
    }
}
