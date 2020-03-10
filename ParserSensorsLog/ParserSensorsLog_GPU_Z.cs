using ParserSensorsLog.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserSensorsLog
{
    public class ParserSensorsLog_GPU_Z
    {
        private static string _path;
        public ParserSensorsLog_GPU_Z(string path)
        {
            _path = path;
        }

        public List<Record> ParseSensorLogFile()
        {
            List<Record> records = new List<Record>();
            var pathTemp = Path.GetTempFileName();
            File.Copy(_path, pathTemp, true);
            using (StreamReader file = File.OpenText(pathTemp))
            {
                string stringLine;
                while ((stringLine = file.ReadLine()) != null)
                {
                    try
                    {
                        var line = stringLine.Split(',');
                        records.Add(new Record()
                        {
                            Date = line[0],
                            GPU_Clock = Convert.ToDouble(line[1].Replace('.', ',')),
                            Memory_Clock = Convert.ToDouble(line[2].Replace('.', ',')),
                            GPU_Temp = Convert.ToDouble(line[3].Replace('.', ',')),
                            Fan_Speed = Convert.ToInt32(line[4]),
                            Fan_Speed_RPM = Convert.ToInt32(line[5]),
                            GPU_Load = Convert.ToInt32(line[6]),
                            Dedicated_Memory = Convert.ToInt32(line[7]),
                            Dynamic_Memory = Convert.ToInt32(line[8]),
                            VDDC = Convert.ToDouble(line[9].Replace('.', ',')),
                            CPU_Temp = Convert.ToDouble(line[10].Replace('.', ',')),
                            System_Memory = Convert.ToInt32(line[11])
                        });
                    }
                    catch { }


                }
            }
            File.Delete(pathTemp);

            return records;
        }
    }
}
