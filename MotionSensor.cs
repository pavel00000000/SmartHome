using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class MotionSensor
    {
        public string Location { get; set; }

        public event EventHandler<MotionDetectedEventArgs> MotionDetectedEvent;

        public void DetectMotion()
        {

            OnMotionDetected(new MotionDetectedEventArgs(Location, DateTime.Now));
        }

        protected virtual void OnMotionDetected(MotionDetectedEventArgs e)
        {
            MotionDetectedEvent?.Invoke(this, e);
        }
    }
}
