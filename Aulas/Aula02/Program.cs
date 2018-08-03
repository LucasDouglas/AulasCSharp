using Aula02.Modelos;
using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro car = new Carro();
            car.Modelo = "Uno c/ escada";

            car.Acelerar();
            ExecutaTesteMotor(car);

            // Console.WriteLine("Velocidade: " + car.Velocidade);
            Console.ReadKey();
        }
            static void ExecutaTesteMotor(IMotorizado vec)
            {
                Console.WriteLine("Velocidade atual: " + vec.Velocidade);
                vec.Acelerar();
                vec.Acelerar();
                vec.Acelerar();
                Console.WriteLine("Velocidade atual: " + vec.Velocidade);
                vec.Desacelerar();
                vec.Desacelerar();
                Console.WriteLine("Velocidade atual: " + vec.Velocidade);

        }

        }
    }

