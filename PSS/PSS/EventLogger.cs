using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PSS
{
    /// <summary>
    /// Provides a logging mechanism for the solution.
    /// </summary>
    public class EventLogger
    {
        /// <summary>
        /// List of the entries (rows)
        /// </summary>
        private static List<string> entries = new List<string>();

        /// <summary>
        /// Initializes the logger, sets the header
        /// </summary>
        public static void Initialize()
        {
            Clear();
            entries.Add("Process Scheduling Simulator");
            entries.Add("Started at: " + DateTime.Now);
        }

        /// <summary>
        /// Adds event without any styling (prefix, postfix, etc.) to the event list
        /// </summary>
        /// <param name="s">The event</param>
        public static void AddEventRaw(string s)
        {
            entries.Add(s);
        }

        /// <summary>
        /// Adds event to the event list
        /// </summary>
        /// <param name="s">The event</param>
        public static void AddEvent(string s)
        {
            entries.Add("[" + DateTime.Now + "] " + s);
        }

        /// <summary>
        /// Exports events to the stream
        /// </summary>
        /// <param name="stream">The stream in which the logger should export</param>
        public static void ExportTo(StreamWriter stream)
        {
            stream.WriteLine("Export started at: " + DateTime.Now);
            entries.ForEach(x => stream.WriteLine(x));
            stream.WriteLine("Export finished at: " + DateTime.Now);
        }

        /// <summary>
        /// Clears the event list
        /// </summary>
        public static void Clear()
        {
            entries.Clear();
        }
    }
}
