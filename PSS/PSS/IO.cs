using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// This class simulates the I/O operation.
    /// </summary>
    public class IO
    {
        /// <summary>
        /// This simulation has three type of I/O Speed
        ///     FAST - Possibly RAM
        ///     MEDIUM - Possibly HDD, SSD
        ///     SLOW - Possibly Keyboard, Mouse, TCP connection, etc.
        /// </summary>
        public enum Speed { FAST, MEDIUM, SLOW };

        /// <summary>
        /// Current speed of I/O 'device
        /// </summary>
        private Speed type;

        /// <summary>
        /// Length of the I/O request
        /// This variable generated according to Speed, and it has some randomness
        /// </summary>
        private int length;

        /// <summary>
        /// Remaining tick of the I/O request
        /// </summary>
        private int remaining;

        /// <summary>
        /// I/O operation constructor
        /// </summary>
        /// <param name="type">Speed of the 'device'</param>
        public IO(Speed type)
        {
            this.type = type;
            Random random = new Random();

            //TODO Calibrate the ranges
            switch (type)
            {
                case Speed.FAST:
                    length = random.Next(100, 300);
                    break;
                case Speed.MEDIUM:
                    length = random.Next(300, 700);
                    break;
                case Speed.SLOW:
                    length = random.Next(700, 1500);
                    break;
            }

            remaining = length;
        }

        /// <summary>
        /// Returns the progress of the I/O operation
        /// </summary>
        public double Progress
        {
            get
            {
                return 1 - (double)remaining / (double)length;
            }
        }

        /// <summary>
        /// It's just a simulation, so data is also simulated
        /// </summary>
        /// <returns>Completeness of the I/O operation</returns>
        public bool GetData()
        {
            if (remaining <= 0)
            {
                return true;
            }
            remaining--;
            return false;
        }
    }
}
