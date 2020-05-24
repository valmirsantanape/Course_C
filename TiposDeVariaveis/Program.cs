using System;

namespace TiposDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10; // declara uma variável
            int numero2 = 20;
            var soma = numero1 + numero2;
                Console.WriteLine("O valor da variável é " + soma);

            int copiaDeNumero1 = numero1;
            copiaDeNumero1 = 11;
            Console.WriteLine(numero1);
            Console.WriteLine(copiaDeNumero1);

            var quadrado1 = new Quadrado(); 
            quadrado1.lado = 10;
            var quadrado2 = quadrado1;
            quadrado2.lado = 11;

            Console.WriteLine(quadrado1.lado);
            Console.WriteLine(quadrado2.lado);
            


            
        }
    class Quadrado //Definir uma classe chamada Quadrado
    {
            public int lado;//Definir uma atributo inteiro chamado lado na classe quadrado
    }
    }
}
