

namespace Aula3107_Console.Modelos
{
    interface IMotorizado
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Frenar();

    }
}
