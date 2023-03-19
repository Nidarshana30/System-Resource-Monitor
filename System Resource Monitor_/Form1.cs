using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Drawing.Text;
using System.Net;

namespace System_Resource_Monitor_
{
    public partial class Form1 : Form
    {

        PerformanceCounter PerfCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter pCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter PerfRAM = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter pRAM = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        PerformanceCounter PerfSYS = new PerformanceCounter("System", "System up Time");
        public Form1()
        {
            InitializeComponent();
        }

        private int CountOfPhysCore()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string socketDesign = string.Empty;
            List<string> physCPU = new List<string>();

            if (!physCPU.Contains(socketDesign))
            {
                physCPU.Add(socketDesign);
            }
            return physCPU.Count;
        }

        private int CountOfLogicalCores()
        {
            int logCPU = 0;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            logCPU++;

            return logCPU;
        }

    
//this code for form 1.... 
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                label15.Text = ""+ item["NumberOfProcessors"];
            }

            int coreCount = 0;
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            label11.Text = coreCount.ToString();
        }



        

        private void label2_Click(object sender, EventArgs e) // Light Mode
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToShortTimeString();

            label5.Text = (int)PerfCPU.NextValue() +" " + "%";
            label7.Text = (int)PerfRAM.NextValue() + " " ;
            label9.Text = (int)PerfSYS.NextValue() / 60 + " Minutes";
            label13.Text = Environment.ProcessorCount.ToString();

            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            progressBarCPU.Value = (int)fcpu;
            progressBarRAM.Value = ((int)fram);
            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart2.Series["RAM"].Points.AddY(fram);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e) //Dark mode
        {
            BackColor = SystemColors.Desktop;
            ForeColor = SystemColors.Window;
            label1.ForeColor = SystemColors.WindowText;
            panel2.BackColor = SystemColors.Control;

            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ControlLightLight;

            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            label13.BackColor = SystemColors.GradientInactiveCaption;

            panel3.BackColor = Color.SlateGray;
            date.BackColor = Color.SlateGray;
            time.BackColor = Color.SlateGray;
            date.ForeColor = SystemColors.ControlLightLight;
            time.ForeColor = SystemColors.ControlLightLight;

            //chart 
            label6.BackColor = SystemColors.AppWorkspace;
            label6.ForeColor = SystemColors.ControlText;


            label10.BackColor = SystemColors.ControlDarkDark;
            chart2.BackColor = SystemColors.ControlDarkDark;

            chart1.BackColor = SystemColors.ControlDark;
            panel8.BackColor = Color.Gainsboro;
            panel8.ForeColor = SystemColors.ControlText;
            panel9.ForeColor = SystemColors.ControlText;

            panel9.BackColor = SystemColors.AppWorkspace;


        }
        private void Light_Mode_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            ForeColor = SystemColors.ControlText;
            label1.ForeColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.Control;

            label1.BackColor = Color.Lavender;
            label1.ForeColor = SystemColors.ControlText;

            tableLayoutPanel1.BackColor = Color.GhostWhite;
            label13.BackColor = Color.GhostWhite;

            panel3.BackColor = Color.Azure;
            time.BackColor = Color.Azure;
            date.BackColor = Color.Azure;
            date.ForeColor = SystemColors.ControlText;
            time.ForeColor = SystemColors.ControlText;

            //chart 
            label6.BackColor = Color.SkyBlue;
            chart1.BackColor = Color.LightBlue;

            label10.BackColor = SystemColors.GradientActiveCaption;
            chart2.BackColor = SystemColors.GradientActiveCaption;

            panel8.BackColor = Color.AliceBlue;
            panel8.ForeColor = SystemColors.ControlText;

            panel9.BackColor = SystemColors.GradientInactiveCaption;
        }
    }
}
