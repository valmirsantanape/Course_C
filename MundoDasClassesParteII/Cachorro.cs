using System;
using System.Collections.Generic;
using System.Text;

namespace MundoDasClassesParteII
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public override Som SomEmitido => Som.Latido;
        public override string Locomocao => "Andando";
    }
}
