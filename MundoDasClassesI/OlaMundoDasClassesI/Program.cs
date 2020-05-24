using System;

namespace OlaMundoDasClassesI
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Cinza, 4, "CrossFox"); //Instancia para criar um novo carro

            Console.WriteLine("O carro é um modelo " + carro.Modelo + ", na cor "+ Cor.Cinza +", tem " +carro.Portas+ " Portas." );
            Console.WriteLine(carro.Ligar());

            Console.WriteLine("Ligado?" + carro.Ligado);
            if (carro.Ligado == true)
                Console.WriteLine(carro.Andar());
            carro.Desligar();
            Console.WriteLine("Ligado" + carro.Ligado);
            Console.WriteLine(carro.Parado());

            carro.Cor = Cor.Verde;
            Console.WriteLine("A cor do meu carro agora é " + carro.Cor);
        }
    }
}
