using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;


namespace Test
{
    public partial class Form1 : Form
    {
        Computer mycomp;

        public Form1()
        {
            InitializeComponent();

            mycomp = new Computer()
            {
                CPUEnabled = true,
                GPUEnabled = true
            };
           
           
            mycomp.Open();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           foreach(var hardwareItem in mycomp.Hardware)
            {
                
                if(hardwareItem.HardwareType == HardwareType.CPU)
                {
                    foreach (var cpu in hardwareItem.Sensors)
                    {
                        if (cpu.SensorType == SensorType.Load)
                        {
                            CPU_PR_B.Value =(int)cpu.Value;
                            CPU_PR_B.Text = string.Format("{0:0} %",cpu.Value.ToString());
                        }
                    }
                    foreach(var cpu_t in hardwareItem.Sensors)
                    {
                        if(cpu_t.SensorType == SensorType.Temperature)
                        {
                            CPU_PR_B_T.Value = (int)cpu_t.Value;
                            CPU_PR_B_T.Text = string.Format("{0:0} C",cpu_t.Value.GetValueOrDefault().ToString());
                        }
                    }
                }
                if (hardwareItem.HardwareType != HardwareType.GpuAti)
                {
                    foreach (var gpu in hardwareItem.Sensors)
                    {
                        if (gpu.SensorType == SensorType.Load)
                        {
                            GPU_PR_B.Value = (int)gpu.Value;
                            GPU_PR_B.Text = string.Format("{0:0} %", gpu.Value.ToString());
                        }
                    }
                    foreach (var gpu_t in hardwareItem.Sensors)
                    {
                        if (gpu_t.SensorType == SensorType.Temperature)
                        {
                            GPU_PR_B_T.Value = (int)gpu_t.Value;
                            GPU_PR_B_T.Text = string.Format("{0:0} C", gpu_t.Value.GetValueOrDefault().ToString());
                        }
                    }
                }
                else
                {
                    foreach (var gpu in hardwareItem.Sensors)
                    {
                        if (gpu.SensorType == SensorType.Load)
                        {
                            GPU_PR_B.Value = (int)gpu.Value;
                            GPU_PR_B.Text = string.Format("{0:0} %", gpu.Value.ToString());
                        }
                    }
                    foreach (var gpu_t in hardwareItem.Sensors)
                    {
                        if (gpu_t.SensorType == SensorType.Temperature)
                        {
                            GPU_PR_B_T.Value = (int)gpu_t.Value;
                            GPU_PR_B_T.Text = string.Format("{0:0} C", gpu_t.Value.GetValueOrDefault().ToString());
                        }
                    }
                }
                hardwareItem.Update();
            }            

        }
    }
}
