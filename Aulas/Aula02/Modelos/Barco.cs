using System;

namespace Aula02.Modelos
{
    class Barco : Veiculos, IMotorizado
    {
        public int Velocidade { get; private set; }
        int IMotorizado.Velocidade { get ; set; }

        public void Acelerar()
        {
            Console.WriteLine("Mandando o acelerão!");
            Velocidade += 3; ;
        }

        public void Desacelerar()
        {
            Console.WriteLine("stopping de boat");
            Velocidade -= 2;
        }
    }
}
