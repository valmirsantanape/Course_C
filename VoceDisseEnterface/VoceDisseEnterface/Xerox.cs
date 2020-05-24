using System;
using System.Collections.Generic;
using System.Text;

namespace VoceDisseEnterface
{
    class Xerox : ICopiadora
    {
        public string Copiar(string texto)
        {
            return $"Texto a copiar: {texto}"; 
        }
    }
}
