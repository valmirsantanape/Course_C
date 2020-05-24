using System;
using System.Collections.Generic;
using System.Text;

namespace VoceDisseEnterface
{
    class ImpressoraComum : IImpressora
    {
        public string Imprimir(string texto)
        {
            return $"Texto a Imprimir: {texto}";
        }
    }
}
