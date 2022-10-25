using System;

namespace operadoresDeAtribuicao {
    class program {
        static void Main(String[] args) {

            float x = 4.5f;


            double y = x; // houve uma converção implicita pos o y é double e recebeu uma variavel x que é float

            Console.WriteLine(y);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            double a;
            float b;

            a = 5.1;
            b = (float)a; // assim que define um casting

            Console.WriteLine(b);

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            double c;
            int d;

            c = 5.1;
            d = (int)a; //Havera perda de informação pos a variavel aceita apenas inteiro e como o numero é quebrado

            Console.WriteLine(d);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int z = 5;
            int w = 2;

            double resultado =(double) z / w;

            Console.WriteLine(resultado);
            



        }
    }
}