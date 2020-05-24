using System;

namespace CodigoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var escaneadora = new Escaneadora();
            var textoEscaneado = escaneadora.Escanear("Texto a ser escaneado");

            var multifuncional = new Multifuncional();

            var impressao = multifuncional.Imprimir("Impressão ok...");
            var copia = multifuncional.Copiar("Cópia ok...");
            var escaneado = multifuncional.Escanear("Escaneadmento ok...");

            Console.WriteLine(impressao);
            Console.WriteLine(copia);
            Console.WriteLine(escaneado);
        }
    }
}
