using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloCalculadora
{
    public static class OperacoesAritmeticas
        //Uma classe estática não pode ser instanciada. Não pode herdar e nem pode ser herdada.
        //A classe estática so pode ter membros estáticos 
    {
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }
        
        public static double Subtracao(double minuando, double subtraendo)
        {
            return minuando - subtraendo;
        }
        public static double multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }
        public static double divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;

        }
    }
}
