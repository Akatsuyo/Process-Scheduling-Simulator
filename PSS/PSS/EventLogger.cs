using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PSS
{
    class EventLogger
    {
        private static List<string> entries = new List<string>();

        public static void Initialize()
        {
            Clear();
            entries.Add("Process Scheduling Simulator");
            entries.Add("Started at: " + DateTime.Now);
        }

        public static void AddEventRaw(string s)
        {
            entries.Add(s);
        }

        public static void AddEvent(string s)
        {
            entries.Add("[" + DateTime.Now + "] " + s);
        }

        public static void ExportTo(StreamWriter stream)
        {
            stream.WriteLine("Export started at: " + DateTime.Now);
            entries.ForEach(x => stream.WriteLine(x));
            stream.WriteLine("Export finished at: " + DateTime.Now);
        }

        public static void Clear()
        {
            entries.Clear();
        }
    }
}
