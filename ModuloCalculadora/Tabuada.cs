using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloCalculadora
{
    public class Tabuada
    {
        
        public int numero { get; }

        public Tabuada(int numero)
        {
            this.numero = numero;
        }
        public string Calcular(int de, int ate)
        {
            var sb = new StringBuilder();
            for(int i = de; i <= ate; i++)
            {
                sb.AppendLine($"{numero} X {i} = {OperacoesAritmeticas.multiplicacao(numero, i)}");
            }
            return sb.ToString();
        }
    }
}
