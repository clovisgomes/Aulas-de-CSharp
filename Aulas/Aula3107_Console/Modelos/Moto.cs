using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_Console.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        public void Acelerar()
        {
            Console.WriteLine("MOTO: Acelerando manopla");
            Velocidade += 10;
        }

        public void Frenar()
        {
            Console.WriteLine("MOTO: Frenando manopla");
            Velocidade += 10;
        }
    }
}
