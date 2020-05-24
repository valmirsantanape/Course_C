using System;

namespace MundoDasClassesParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Rex", 5);
            var g = new Gato("Ana", 3);
            Animal a = new Gato("Felix", 2);//Polimorfismo: o gato tbm é um animal
            
            ExibeAnimal(c); //Metodo recebe argumento do tipo Cachorro
            ExibeAnimal(g); //Metodo recebe argumento do tipo Gato
            ExibeAnimal(a); //Metodo recebe argumento do tipo Animal


        }
        public static void ExibeAnimal(Animal animal)
        {
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade}");
            Console.WriteLine($"Som que emite: {animal.SomEmitido}");
            Console.WriteLine($"Locomoção: {animal.Locomocao}");
        }
    }
}
