using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Light
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Свет включен");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Свет выключен");
        }
    }
}
