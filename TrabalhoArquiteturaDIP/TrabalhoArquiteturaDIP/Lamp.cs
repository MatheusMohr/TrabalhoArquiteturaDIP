using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Arquitetura_DIP
{
    public class Lamp : IDevice
    {
        private EnumState _state = EnumState.Off;

        public void Operate()
        {
            _state = _state == EnumState.On ? EnumState.Off : EnumState.On;
            Console.WriteLine("Luz " + (_state == EnumState.On ? "Ligada" : "Desligada"));
        }
    }
}
