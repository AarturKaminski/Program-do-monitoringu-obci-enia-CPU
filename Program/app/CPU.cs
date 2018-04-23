using OpenHardwareMonitor.Hardware;
using OpenHardwareMonitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class CPU
    {
        Computer thisComputer;
        int cpuload;
        string cpu_load;
        int cputemp;
        string cpu_temp;
        public CPU()
        {

            thisComputer = new Computer() { CPUEnabled = true };
            thisComputer.Open();
            
        }

        public int Cpuload()
        {
          
            
            foreach (var hardwareItem in thisComputer.Hardware)
            {
                
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    foreach (var cpul in hardwareItem.Sensors)
                    {
                        if (cpul.SensorType == SensorType.Load)
                        {
                            cpuload = (int)cpul.Value;
                            cpu_load =cpul.Value.GetValueOrDefault().ToString();
                        }
                    }
                }
                hardwareItem.Update();
            }
            return cpuload;
        }

        public int Cputemp()
        {
            
            foreach (var hardwareItem in thisComputer.Hardware)
            {
                
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    foreach (var cpu_t in hardwareItem.Sensors)
                    {
                        
                        if (cpu_t.SensorType == SensorType.Temperature)
                        {
                            cputemp = (int)cpu_t.Value.GetValueOrDefault();
                            cpu_temp = cpu_t.Value.GetValueOrDefault().ToString();

                        }
                    }
                }
                hardwareItem.Update();
            }
            
            return cputemp;
            
        }
       
    }
}
