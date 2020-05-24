using System;
using System.Collections.Generic;
using System.Text;

namespace MundoDasClassesParteII
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade) : base(nome, idade)
        {
        }

        public override Som SomEmitido => Som.Miado;
        public override string Locomocao => "Está pulando";
    }
}
