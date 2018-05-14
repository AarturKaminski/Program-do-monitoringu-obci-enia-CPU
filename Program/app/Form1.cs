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
using System.Management;

namespace app
{
    public partial class Form1 : Form
    {
        CPU cpu = new CPU();
        GPU gpu = new GPU();
        Unit unit = new Unit();

        Computer thisComputer;
        public Form1()
        {
            InitializeComponent();
            thisComputer = new Computer() { CPUEnabled = true, GPUEnabled = true };
            

            thisComputer.Open();
            GetCPUInfo("Win32_Processor", "Name");
            GetGPUInfo("Win32_VideoController", "Name");

        }

        public void GetCPUInfo(string hwclass, string syntax)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                label1.Text = ((Convert.ToString(mj[syntax])) + "\r\n");
            }
        }

        public void GetGPUInfo(string hwclass, string syntax)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                label2.Text = ((Convert.ToString(mj[syntax])) + "\r\n");
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if(celsjuszToolStripMenuItem.Checked)
            { 
            
            circularProgressBar1.Value = cpu.Cputemp();
            circularProgressBar1.Text = unit.C_CPUTemp().ToString();

            circularProgressBar3.Value = cpu.Cpuload();
            circularProgressBar3.Text = cpu.Cpuload().ToString();

            circularProgressBar2.Value = gpu.Gputemp();
            circularProgressBar2.Text = unit.C_GPUTemp().ToString();

            circularProgressBar4.Value = gpu.Gpuload();
            circularProgressBar4.Text = gpu.Gpuload().ToString();
            }
            else
            {
                circularProgressBar1.Value = unit.F_CPUTemp();
                circularProgressBar1.Text = unit.F_CPUTemp().ToString();

                circularProgressBar3.Value = cpu.Cpuload();
                circularProgressBar3.Text = cpu.Cpuload().ToString();

                circularProgressBar2.Value = unit.F_GPUTemp();
                circularProgressBar2.Text = unit.F_GPUTemp().ToString();

                circularProgressBar4.Value = gpu.Gpuload();
                circularProgressBar4.Text = gpu.Gpuload().ToString();
            }
        }

        private void celsjuszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            celsjuszToolStripMenuItem.Checked = true;
            faranhaitToolStripMenuItem.Checked = false;
            circularProgressBar1.SuperscriptText = " °C";
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            circularProgressBar2.SuperscriptText = " °C";
            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;

        }

        private void faranhaitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            celsjuszToolStripMenuItem.Checked = false;
            faranhaitToolStripMenuItem.Checked = true;
            circularProgressBar1.SuperscriptText = " °F";
            circularProgressBar1.Minimum = 32;
            circularProgressBar1.Maximum = 212;

            circularProgressBar2.SuperscriptText = " °F";
            circularProgressBar2.Minimum = 32;
            circularProgressBar2.Maximum = 212;

        }
    }
}
