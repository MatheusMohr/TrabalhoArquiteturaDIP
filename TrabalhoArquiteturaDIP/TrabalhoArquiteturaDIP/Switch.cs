using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Arquitetura_DIP
{
    public class Switch
    {
        private IDevice _device;

        public Switch(IDevice device)
        {
            _device = device;
        }

        public void Press()
        {
            _device.Operate();
        }
    }   
}
