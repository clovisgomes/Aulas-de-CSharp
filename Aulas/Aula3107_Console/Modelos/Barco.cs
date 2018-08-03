

namespace Aula3107_Console.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public void Acelerar()
        {
            Console.WriteLine("BARCO: Acelerando, empurrando manete");
            Velocidade += 2;
        }

        public void Frenar()
        {
            Console.WriteLine("BARCO: Desacelerando, empurrando manete");
            Velocidade += 2;
        }
    }
}
