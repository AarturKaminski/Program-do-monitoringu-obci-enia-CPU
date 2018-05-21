using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class GPU
    {
        Computer thisComputer;
        int gputemp;
        string gpu_temp;
        int gpuload;
        string gpu_load;
        string gpu_name;

        public GPU()
        {
            thisComputer = new Computer() { GPUEnabled = true };


            thisComputer.Open();

        }

        public int Gputemp()
        {
            
            foreach (var hardwareItemgpu in thisComputer.Hardware)
            {
             
                if (hardwareItemgpu.HardwareType == HardwareType.GpuAti)
                {
                    foreach (var gput in hardwareItemgpu.Sensors)
                    {
                        if (gput.SensorType == SensorType.Temperature)
                        {
                            gputemp = (int)gput.Value.GetValueOrDefault();
                            gpu_temp = gput.Value.GetValueOrDefault().ToString();
                        }

                    }
                }
                else
                {
                    foreach (var gput in hardwareItemgpu.Sensors)
                    {
                        if (gput.SensorType == SensorType.Temperature)
                        {
                            gputemp = (int)gput.Value.GetValueOrDefault();
                            gpu_temp = gput.Value.GetValueOrDefault().ToString();
                        }

                    }
                }
                hardwareItemgpu.Update();
            }
            return gputemp;
        }


        public int Gpuload()
        {

            foreach (var hardwareItemgpu in thisComputer.Hardware)
            {
               
                if (hardwareItemgpu.HardwareType == HardwareType.GpuAti)
                {
                    foreach (var gpul in hardwareItemgpu.Sensors)
                    {
                        if (gpul.SensorType == SensorType.Load)
                        {
                            gpuload = (int)gpul.Value;
                            gpu_load = gpul.Value.ToString();
                        }
                    }
                }
                else
                {
                    foreach (var gpul in hardwareItemgpu.Sensors)
                    {
                        if (gpul.SensorType == SensorType.Load)
                        {
                            gpuload = (int)gpul.Value;
                            gpu_load = gpul.Value.ToString();
                        }
                    }
                }
                hardwareItemgpu.Update();
            }
            return gpuload;
        }
    }   
}
