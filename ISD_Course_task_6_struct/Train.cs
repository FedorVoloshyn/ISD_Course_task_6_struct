using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_6_struct
{
    class Train
    {
        private string distinationPoint;

        public string DistinationPoint
        {
            get { return distinationPoint; }
        }
        private int numberOfTrain;

        public int NumberOfTrain
        {
            get { return numberOfTrain; }
        }
        private DateTime timeLeave;

        public DateTime Time
        {
            get { return timeLeave; }
        }
        public Train(string distinationPoint, int numberOfTrain, DateTime timeLeave)
        {
            this.distinationPoint = distinationPoint;
            this.numberOfTrain = numberOfTrain;
            this.timeLeave = timeLeave;
        }
    }
}
