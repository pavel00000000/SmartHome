using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class MotionDetectedEventArgs : EventArgs
    {
        public string Location { get; }
        public DateTime DetectionTime { get; }

        public MotionDetectedEventArgs(string location, DateTime detectionTime)
        {
            Location = location;
            DetectionTime = detectionTime;
        }
    }
}
