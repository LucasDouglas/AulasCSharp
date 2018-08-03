using System;

namespace Aula02.Modelos
{
    class Carro : Veiculos, IMotorizado
    {
        public int Velocidade { get ; set; }

        public void Acelerar()
        {
            Console.WriteLine("Pisando no pedal");
            Velocidade += 5;

        }

        public void Desacelerar()
        {
            Console.WriteLine("Tirando o pé");
            Velocidade -= 3;
        }
    }
}
