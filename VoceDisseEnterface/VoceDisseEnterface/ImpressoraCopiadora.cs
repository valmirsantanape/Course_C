using System;
using System.Collections.Generic;
using System.Text;

namespace VoceDisseEnterface
{
    public class ImpressoraCopiadora : IImpressora, ICopiadora
    {
        public string Copiar(string texto)
        {
            return $"Texto a copiar:{texto}";
        }

        public string Imprimir(string texto)
        {
            return $"Texto a Imprimir: {texto}";
        }
    }
}
