using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Thermostat
    {
        public int Temperature { get; set; }

        public void SetTemperature(int temperature)
        {
            Temperature = temperature;
            Console.WriteLine($"Термостат установлен на {Temperature} градусов");
        }
    }
}
