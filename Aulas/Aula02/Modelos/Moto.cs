using System;

namespace Aula02.Modelos
{
    class Moto : Veiculos, IMotorizado
    {
        public int Velocidade { get ; set ; }

        public void Acelerar()
        {
            Console.WriteLine("Mandando um grau!");
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Console.WriteLine("Parando di levs");
            Velocidade -= 6;
        }
    }
}
