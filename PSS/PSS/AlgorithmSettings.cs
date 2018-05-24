using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS
{
    /// <summary>
    /// Container of the algorithm settings
    /// </summary>
    public class AlgorithmSettings
    {
        /// <summary>
        /// Type of the setting (which view should be visible)
        /// </summary>
        public enum SettingType {
            /// <summary>
            /// Range type
            /// </summary>
            RANGE
        };

        ISetting[] settings;

        /// <summary>
        /// Constructor of the algorithm settings
        /// </summary>
        /// <param name="settings">Settings of the algorithm</param>
        public AlgorithmSettings(ISetting[] settings)
        {
            this.settings = settings;
        }

        /// <summary>
        /// Settings of the algorithm
        /// </summary>
        public ISetting[] Settings
        {
            get
            {
                return settings;
            }
        }

        /// <summary>
        /// Number of the settings
        /// </summary>
        public int SettingsCount
        {
            get
            {
                return settings.Count();
            }
        }

        /// <summary>
        /// Interface of a setting
        /// </summary>
        public interface ISetting {
            /// <summary>
            /// Type of the setting
            /// </summary>
            SettingType SettingType { get; }

            /// <summary>
            /// Name of the setting
            /// </summary>
            string Name { get;}

            /// <summary>
            /// Label of the setting (this will be visible)
            /// </summary>
            string Label { get;}
        
            /// <summary>
            /// Callback method of a setting
            /// </summary>
            /// This will be called when a value changes (it pushes a string, you have to handle it)
            Action<string> Method { get; }
        }

        /// <summary>
        /// Range type setting
        /// </summary>
        public class RangeSetting : ISetting {
            private readonly string name, label;
            private readonly int from, to, step, value;
            private readonly Action<string> method;

            /// <summary>
            /// Constructor of the range
            /// </summary>
            /// <param name="name">Name of the setting</param>
            /// <param name="label">Label of the setting (this will be visible)</param>
            /// <param name="from">Lower boundary of range interval</param>
            /// <param name="to">Upper boundary of range interval</param>
            /// <param name="step">Step of the range</param>
            /// <param name="value">Default value of the range</param>
            /// <param name="method">Callback method</param>
            public RangeSetting(string name, string label, int from, int to, int step, int value, Action<string> method)
            {
                this.name = name;
                this.label = label;
                this.from = from;
                this.to = to;
                this.step = step;
                this.value = value;
                this.method = method;
            }

            /// <summary>
            /// Type of the setting (this will be always RANGE)
            /// </summary>
            public SettingType SettingType
            {
                get
                {
                    return SettingType.RANGE;
                }
            }

            /// <summary>
            /// Name of the setting
            /// </summary>
            public string Name
            {
                get
                {
                    return name;
                }
            }

            /// <summary>
            /// Label of the setting (this will be visible)
            /// </summary>
            public string Label
            {
                get
                {
                    return label;
                }
            }

            /// <summary>
            /// Lower boundary of range interval
            /// </summary>
            public int From {
                get
                {
                    return from;
                }
            }

            /// <summary>
            /// Upper boundary of range interval
            /// </summary>
            public int To
            {
                get
                {
                    return to;
                }
            }

            /// <summary>
            /// Step of the range
            /// </summary>
            public int Step
            {
                get
                {
                    return step;
                }
            }

            /// <summary>
            /// Default value of the range
            /// </summary>
            public int Value {
                get
                {
                    return value;
                }
            }

            /// <summary>
            /// Callback method
            /// </summary>
            public Action<string> Method {
                get
                {
                    return method;
                }
            }
        }
    }
}
