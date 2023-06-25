using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class SmartHomeSystem
    {
        private readonly List<MotionSensor> motionSensors;
        private Thermostat thermostat;
        private Light light;

        public SmartHomeSystem()
        {
            motionSensors = new  List<MotionSensor>();
        }

        public void RegisterMotionSensor(MotionSensor motionSensor)
        {
            motionSensors.Add(motionSensor);
            motionSensor.MotionDetectedEvent += HandleMotionDetected;
        }

        public void RegisterThermostat(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }

        public void RegisterLight(Light light)
        {
            this.light = light;
        }

        public void StartMonitoring()
        {
            foreach (var motionSensor in motionSensors)
            {
                motionSensor.DetectMotion();
            }
        }

        private void HandleMotionDetected(object sender, MotionDetectedEventArgs e)
        {
            Console.WriteLine($"Обнаружено движение в месте {e.Location} в {e.DetectionTime}");
            light.TurnOn();
        }
    }
}
