

namespace Aula3107_Console.Modelos
{
    class Carro : Veiculo, IMotorizado
    {
        public void Acelerar()

        {        
          
            
            Console.WriteLine("CARRO: Pisando no Pedal");
            Velocidade+=5;
        }

        public void Frenar()
        {
            Console.WriteLine("CARRO: Pisando no pedal freio");
            Velocidade +=3;

        }
    }
}
