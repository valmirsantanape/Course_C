using System;
using System.Collections.Generic;
using System.Text;

namespace MundoDasClassesParteII
{
    public abstract class Animal //Uma clkasse abstrata não pode ser instanciada 
    {
        public string Nome { get; }
        public int Idade { get; }
        public abstract Som SomEmitido { get; } //Essa propriedade deverar ser programada por cada classe filha ja que é abstrata 
        public virtual string Locomocao { get { return "Está andando"; } } //Essa propriedade poderá ou não ser reescrita nas classes filhas 
        public Animal(string nome, Som somemitido, int idade)
        {
            Nome = nome;
            Idade = idade;
            
        }

        protected Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
