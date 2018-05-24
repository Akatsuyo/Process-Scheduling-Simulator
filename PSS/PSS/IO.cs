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
        /// </summary>
        public enum Speed {
            /// <summary>
            /// Possibly RAM
            /// </summary>
            FAST,
            /// <summary>
            /// Possibly HDD, SSD
            /// </summary>
            MEDIUM,
            /// <summary>
            /// Possibly Keyboard, Mouse, TCP connection, etc.
            /// </summary>
            SLOW
        };

        /// <summary>
        /// Current speed of I/O device
        /// </summary>
        private readonly Speed type;

        /// <summary>
        /// Length of the I/O request
        /// This variable generated according to Speed, and it has some randomness
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Remaining tick of the I/O request
        /// </summary>
        public int Remaining { get; set; }

        /// <summary>
        /// I/O operation constructor
        /// </summary>
        /// <param name="type">Speed of the 'device'</param>
        public IO(Speed type)
        {
            this.type = type;
            Random random = new Random();

            switch (type)
            {
                case Speed.FAST:
                    Length = random.Next(5, 10);
                    break;
                case Speed.MEDIUM:
                    Length = random.Next(10, 20);
                    break;
                case Speed.SLOW:
                    Length = random.Next(20, 50);
                    break;
            }

            Remaining = Length;
        }

        /// <summary>
        /// Returns the progress of the I/O operation
        /// </summary>
        public int Progress
        {
            get { return Length - Remaining; }
        }

        /// <summary>
        /// It's just a simulation, so data is also simulated
        /// </summary>
        public void GetData()
        {
            if (!Done)
            {
                Remaining--;
            }
        }

        /// <summary>
        /// Returns true if the IO is done
        /// </summary>
        public bool Done
        {
            get { return Remaining <= 0; }
        }
    }
}
