using System;

namespace Aula3107_Console
{
    class Program
    {
        public static int n1 { get; set; }
        public static int n2 { get; set; }

        static void Main(string[] args)
        {
            Carro car = new Carro();
            car.Modelo = "Ferrari";
            car.Acelerar();

            Console.WriteLine("Velocidade: " + car.Velocidade);
            Console.ReadKey();

        }

        static void ExecutaTesteMotor(IMotorizado vec)


    }


}

