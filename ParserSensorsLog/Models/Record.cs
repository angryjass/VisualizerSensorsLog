using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserSensorsLog.Models
{
    /// <summary>
    /// One string in GPU-Z file
    /// </summary>
    public class Record
    {
        /// <summary>
        /// Date of sample
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// GPU Clock in MHz
        /// </summary>
        public double GPU_Clock { get; set; }
        /// <summary>
        /// Memory Clock in MHz
        /// </summary>
        public double Memory_Clock { get; set; }
        /// <summary>
        /// Temperature of GPU in °C
        /// </summary>
        public double GPU_Temp { get; set; }
        /// <summary>
        /// Fan Speed in % from maximum
        /// </summary>
        public int Fan_Speed { get; set; }
        /// <summary>
        /// Fan Speed in RPM
        /// </summary>
        public int Fan_Speed_RPM { get; set; }
        /// <summary>
        /// Load of GPU in % from maximum
        /// </summary>
        public int GPU_Load { get; set; }
        /// <summary>
        /// Dedicated Memory Used in MB
        /// </summary>
        public int Dedicated_Memory { get; set; }
        /// <summary>
        /// Dynamic Memory Used in MB
        /// </summary>
        public int Dynamic_Memory { get; set; }
        /// <summary>
        /// VDDC in V
        /// </summary>
        public double VDDC { get; set; }
        /// <summary>
        /// Temperature of CPU in °C
        /// </summary>
        public double CPU_Temp { get; set; }
        /// <summary>
        /// System Memory Used in MB
        /// </summary>
        public int System_Memory { get; set; }
    }
}
