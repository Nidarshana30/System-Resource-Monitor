namespace System_Resource_Monitor_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Light_Mode = new System.Windows.Forms.Label();
            this.Dark_Mode = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.labelCountOfPhysicalCPUs = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelCOUNTOFLOGICALCPUS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelCountOfCores = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSYSUPTIME = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCPUUSAGE = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel14 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.lblRAM = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.lblCPU = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1253, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "System Resource Monitor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1253, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 91);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 536);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.time);
            this.panel6.Controls.Add(this.date);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 376);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(131, 97);
            this.panel6.TabIndex = 1;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Azure;
            this.time.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.time.Dock = System.Windows.Forms.DockStyle.Top;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.Location = new System.Drawing.Point(0, 30);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(131, 30);
            this.time.TabIndex = 2;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Azure;
            this.date.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.date.Dock = System.Windows.Forms.DockStyle.Top;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Location = new System.Drawing.Point(0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(131, 30);
            this.date.TabIndex = 1;
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Light_Mode);
            this.panel4.Controls.Add(this.Dark_Mode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 473);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 61);
            this.panel4.TabIndex = 0;
            // 
            // Light_Mode
            // 
            this.Light_Mode.BackColor = System.Drawing.Color.White;
            this.Light_Mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Light_Mode.Dock = System.Windows.Forms.DockStyle.Top;
            this.Light_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Light_Mode.ForeColor = System.Drawing.Color.Black;
            this.Light_Mode.Location = new System.Drawing.Point(0, 31);
            this.Light_Mode.Name = "Light_Mode";
            this.Light_Mode.Size = new System.Drawing.Size(131, 30);
            this.Light_Mode.TabIndex = 2;
            this.Light_Mode.Text = "Light Mode";
            this.Light_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Light_Mode.Click += new System.EventHandler(this.Light_Mode_Click);
            // 
            // Dark_Mode
            // 
            this.Dark_Mode.BackColor = System.Drawing.Color.Black;
            this.Dark_Mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dark_Mode.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dark_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dark_Mode.ForeColor = System.Drawing.Color.Transparent;
            this.Dark_Mode.Location = new System.Drawing.Point(0, 0);
            this.Dark_Mode.Name = "Dark_Mode";
            this.Dark_Mode.Size = new System.Drawing.Size(131, 31);
            this.Dark_Mode.TabIndex = 1;
            this.Dark_Mode.Text = "Dark Mode";
            this.Dark_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dark_Mode.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.GhostWhite;
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(133, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 536);
            this.panel5.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.79167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.20833F));
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelCountOfPhysicalCPUs, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCOUNTOFLOGICALCPUS, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCountOfCores, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSYSUPTIME, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRAM, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCPUUSAGE, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(290, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 90);
            this.label15.TabIndex = 11;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountOfPhysicalCPUs
            // 
            this.labelCountOfPhysicalCPUs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountOfPhysicalCPUs.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountOfPhysicalCPUs.Location = new System.Drawing.Point(3, 440);
            this.labelCountOfPhysicalCPUs.Name = "labelCountOfPhysicalCPUs";
            this.labelCountOfPhysicalCPUs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelCountOfPhysicalCPUs.Size = new System.Drawing.Size(281, 90);
            this.labelCountOfPhysicalCPUs.TabIndex = 10;
            this.labelCountOfPhysicalCPUs.Text = "Count Of Physical CPUs :";
            this.labelCountOfPhysicalCPUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.GhostWhite;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(290, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 88);
            this.label13.TabIndex = 9;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCOUNTOFLOGICALCPUS
            // 
            this.labelCOUNTOFLOGICALCPUS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCOUNTOFLOGICALCPUS.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOUNTOFLOGICALCPUS.Location = new System.Drawing.Point(3, 352);
            this.labelCOUNTOFLOGICALCPUS.Name = "labelCOUNTOFLOGICALCPUS";
            this.labelCOUNTOFLOGICALCPUS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelCOUNTOFLOGICALCPUS.Size = new System.Drawing.Size(281, 88);
            this.labelCOUNTOFLOGICALCPUS.TabIndex = 8;
            this.labelCOUNTOFLOGICALCPUS.Text = "COUNT OF lOGICAL CPUs :";
            this.labelCOUNTOFLOGICALCPUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(290, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 88);
            this.label11.TabIndex = 7;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountOfCores
            // 
            this.labelCountOfCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountOfCores.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountOfCores.Location = new System.Drawing.Point(3, 264);
            this.labelCountOfCores.Name = "labelCountOfCores";
            this.labelCountOfCores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelCountOfCores.Size = new System.Drawing.Size(281, 88);
            this.labelCountOfCores.TabIndex = 6;
            this.labelCountOfCores.Text = "Count Of Cores :";
            this.labelCountOfCores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 88);
            this.label9.TabIndex = 5;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSYSUPTIME
            // 
            this.labelSYSUPTIME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSYSUPTIME.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSYSUPTIME.Location = new System.Drawing.Point(3, 176);
            this.labelSYSUPTIME.Name = "labelSYSUPTIME";
            this.labelSYSUPTIME.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelSYSUPTIME.Size = new System.Drawing.Size(281, 88);
            this.labelSYSUPTIME.TabIndex = 4;
            this.labelSYSUPTIME.Text = "SYSTEM UP TIME :";
            this.labelSYSUPTIME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 88);
            this.label7.TabIndex = 3;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRAM
            // 
            this.labelRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.Location = new System.Drawing.Point(3, 88);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelRAM.Size = new System.Drawing.Size(281, 88);
            this.labelRAM.TabIndex = 2;
            this.labelRAM.Text = "Availabel RAM :";
            this.labelRAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(187, 88);
            this.label5.TabIndex = 1;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCPUUSAGE
            // 
            this.labelCPUUSAGE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCPUUSAGE.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUUSAGE.Location = new System.Drawing.Point(3, 0);
            this.labelCPUUSAGE.Name = "labelCPUUSAGE";
            this.labelCPUUSAGE.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelCPUUSAGE.Size = new System.Drawing.Size(281, 88);
            this.labelCPUUSAGE.TabIndex = 0;
            this.labelCPUUSAGE.Text = "CPU Usage :";
            this.labelCPUUSAGE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel15);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(613, 93);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(867, 536);
            this.panel10.TabIndex = 5;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Snow;
            this.panel15.Controls.Add(this.chart2);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(434, 50);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(433, 486);
            this.panel15.TabIndex = 4;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "RAM";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(430, 396);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel14.Controls.Add(this.chart1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 50);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(434, 486);
            this.panel14.TabIndex = 3;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightBlue;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "CPU";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(434, 393);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(867, 50);
            this.panel11.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label10);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(434, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(433, 50);
            this.panel13.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(432, 50);
            this.label10.TabIndex = 1;
            this.label10.Text = "RAM";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(434, 50);
            this.panel12.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = "CPU";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(613, 529);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(867, 100);
            this.panel7.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel9.Controls.Add(this.progressBarRAM);
            this.panel9.Controls.Add(this.lblRAM);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(434, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(433, 100);
            this.panel9.TabIndex = 1;
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(63, 39);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(275, 23);
            this.progressBarRAM.TabIndex = 2;
            // 
            // lblRAM
            // 
            this.lblRAM.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRAM.Location = new System.Drawing.Point(348, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(85, 100);
            this.lblRAM.TabIndex = 1;
            this.lblRAM.Text = "0%";
            this.lblRAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 100);
            this.label8.TabIndex = 0;
            this.label8.Text = "RAM:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.AliceBlue;
            this.panel8.Controls.Add(this.progressBarCPU);
            this.panel8.Controls.Add(this.lblCPU);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(434, 100);
            this.panel8.TabIndex = 0;
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(68, 39);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(275, 23);
            this.progressBarCPU.TabIndex = 2;
            // 
            // lblCPU
            // 
            this.lblCPU.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCPU.Location = new System.Drawing.Point(349, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(85, 100);
            this.lblCPU.TabIndex = 1;
            this.lblCPU.Text = "0%";
            this.lblCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 100);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPU:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 629);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(1498, 676);
            this.MinimumSize = new System.Drawing.Size(1498, 676);
            this.Name = "Form1";
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Dark_Mode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelCountOfPhysicalCPUs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelCOUNTOFLOGICALCPUS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelCountOfCores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSYSUPTIME;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCPUUSAGE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label Light_Mode;
    }
}

