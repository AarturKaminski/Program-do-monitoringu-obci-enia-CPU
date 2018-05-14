using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenHardwareMonitor.Hardware;
using OpenHardwareMonitor.Collections;

namespace app
{

    public enum TemperatureUnit
    {
        Celsius = 0,
        Fahrenheit =1
    }

    class Unit
    {
        CPU cpu = new CPU();
        GPU gpu = new GPU();
        Computer thisComputer;

        int cputemp, gputemp, fcpu, fgpu;
        string cpu_temp, gpu_temp, f_cpu, f_gpu;
        public Unit()
        {
            thisComputer = new Computer() { CPUEnabled = true, GPUEnabled=true };
            thisComputer.Open();
        }

        public int C_CPUTemp()
        {
            cputemp = cpu.Cputemp();
            cpu_temp = cpu.Cputemp().ToString();

            return cputemp;
        }

        public int C_GPUTemp()
        {
            gputemp = gpu.Gputemp();
            gpu_temp = gpu.Gputemp().ToString();

            return gputemp;
        }
        
        public int F_CPUTemp()
        {
            cputemp = cpu.Cputemp();
            cpu_temp = cpu.Cputemp().ToString();
            fcpu = (9 * cputemp) / 5 + 32;

            return fcpu;
        }

        public int F_GPUTemp()
        {
            gputemp = gpu.Gputemp();
            gpu_temp = gpu.Gputemp().ToString();
            fgpu = (9 * gputemp) / 5 + 32;

            return fgpu;
        }

    }
}
