using System;

namespace LacosInterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laços interativos => ESTRUTURAS QUE REPETEM UM BLOCO DE CODIOS DETERMINADAS VEZES
            // Laço for
            for (int i = 1; i < 10; i++)// ++ significa que sera encrementado de 1 em 1 
            
            { 
            Console.WriteLine("Valor de i é " + i);
            }
            // Estrutura While
            int contador = 1;
            while(contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            //Do ... while
            //Executa o bloco inteiro, depois teste a condição
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;


            } while (j < 100);
            //foreach
            //percorre a todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 3, 7 };
foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento do conjunto tem valor " + numero);
            }

        }
    }  
}
