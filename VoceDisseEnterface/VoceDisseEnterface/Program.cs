using System;

namespace VoceDisseEnterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var i2 = new ImpressoraCopiadora();
            var c = new ImpressoraCopiadora();

            Console.WriteLine(i.Imprimir("Estou estudando C# "));
            Console.WriteLine(i2.Copiar("Estou estudando C# e estou gostando "));

            CopiarDocumento(new Xerox(), "Hello, world!");
        }
        public static void CopiarDocumento(ICopiadora c, string texto)
        {
            Console.WriteLine("Estou copiando o texto a seguir " + c.Copiar(texto));
        }
    }
}
