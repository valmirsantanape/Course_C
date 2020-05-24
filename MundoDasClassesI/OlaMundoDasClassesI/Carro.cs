using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace OlaMundoDasClassesI
{
    public class Carro
    {
        public Cor Cor { get; set; }
        public int Portas { get; }
        public String Modelo { get; set; }

        private bool ligado = false; //privete: só esta classe tem acesso

        public bool Ligado //propriedade: define uma maneira de acessar o atributo
        {
            get
            {
                return ligado;
            }
            
        }


        public Carro(Cor cor, int portas, string modelo)
        {
            Cor = cor;
            Portas = portas;
            Modelo = modelo;
        }

        public string Ligar()
        {
            ligado = true;
            return "Carro esta ligado!";
        }

        public string Desligar()
        {
            ligado = false;
            return "Carro esta desligado!";
        }
        public string Andar()
        {   
            return "O carro esta andando!";
        }
        public string Parado()
        {
            return "O carro esta parado!";
        }
    }

}
