namespace DataLogger
{
    partial class frmNewMain
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewMain));
            this.serialPortTN = new System.IO.Ports.SerialPort(this.components);
            this.serialPortTP = new System.IO.Ports.SerialPort(this.components);
            this.serialPortTOC = new System.IO.Ports.SerialPort(this.components);
            this.serialPortSAMP = new System.IO.Ports.SerialPort(this.components);
            this.serialPortADAM = new System.IO.Ports.SerialPort(this.components);
            this.bgwMonthlyReport = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerMain = new System.ComponentModel.BackgroundWorker();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.lblStationStatus = new System.Windows.Forms.Label();
            this.pnStationStatus = new System.Windows.Forms.Panel();
            this.picStationStatusAir2 = new System.Windows.Forms.PictureBox();
            this.picStationStatusAir1 = new System.Windows.Forms.PictureBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lblMainMenuTitle = new System.Windows.Forms.Label();
            this.pnSoftwareInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSurfaceWaterQuality = new System.Windows.Forms.Label();
            this.lblAutomaticMonitoring = new System.Windows.Forms.Label();
            this.lblThaiNguyenStation = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWaterLevel = new System.Windows.Forms.Label();
            this.lblHeaderNationName = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.picSamplerTank = new System.Windows.Forms.PictureBox();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.listen = new DataLogger.FlatButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.picStationStatusFireDetector = new System.Windows.Forms.PictureBox();
            this.picStationStatusMainDoor = new System.Windows.Forms.PictureBox();
            this.picStationStatusUPS = new System.Windows.Forms.PictureBox();
            this.picStationStatusMainPower = new System.Windows.Forms.PictureBox();
            this.lblair1 = new System.Windows.Forms.Label();
            this.lblFireDetector = new System.Windows.Forms.Label();
            this.lblMainDoor = new System.Windows.Forms.Label();
            this.lblair2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblMainPower = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblFilteringSystem = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblPumpingSystem = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAutorSampler = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAutoSamplerTesting = new System.Windows.Forms.Button();
            this.btnAutoSamplerHistoryData = new System.Windows.Forms.Button();
            this.picAutoSamplerStatus = new System.Windows.Forms.PictureBox();
            this.pnbottlePosition = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtAutoSamplerTemp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRRS = new System.Windows.Forms.Label();
            this.lblPumpRRS = new System.Windows.Forms.Label();
            this.lblLRS = new System.Windows.Forms.Label();
            this.lblPumpRFLTName = new System.Windows.Forms.Label();
            this.lblPumpRFLT = new System.Windows.Forms.Label();
            this.lblPumpLFLTName = new System.Windows.Forms.Label();
            this.lblPumpRAM = new System.Windows.Forms.Label();
            this.lblPumpLAM = new System.Windows.Forms.Label();
            this.lblPumpLRS = new System.Windows.Forms.Label();
            this.lblPumpLFLT = new System.Windows.Forms.Label();
            this.picPumpingSystemRRS = new System.Windows.Forms.PictureBox();
            this.picPumpingSystemRFLT = new System.Windows.Forms.PictureBox();
            this.picPump2_RunningType = new System.Windows.Forms.PictureBox();
            this.picPumpingSystemLRS = new System.Windows.Forms.PictureBox();
            this.picPumpingSystemLFLT = new System.Windows.Forms.PictureBox();
            this.picPump1_RunningType = new System.Windows.Forms.PictureBox();
            this.lblPump2 = new System.Windows.Forms.Label();
            this.picPump2 = new System.Windows.Forms.PictureBox();
            this.lblPump1 = new System.Windows.Forms.Label();
            this.picPump1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.btnMPSHistoryData = new System.Windows.Forms.Button();
            this.btnMPS1Hour = new System.Windows.Forms.Button();
            this.btnMPS5Minute = new System.Windows.Forms.Button();
            this.picMPSStatus = new System.Windows.Forms.PictureBox();
            this.txtMPSCondValue = new System.Windows.Forms.TextBox();
            this.txtMPSTurbValue = new System.Windows.Forms.TextBox();
            this.txtMPSDOValue = new System.Windows.Forms.TextBox();
            this.txtMPSTempValue = new System.Windows.Forms.TextBox();
            this.txtMPSORPValue = new System.Windows.Forms.TextBox();
            this.txtMPSpHValue = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.pictureBoxWater = new System.Windows.Forms.PictureBox();
            this.lblSamplerTank = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.picFilteringSystemCleaning = new System.Windows.Forms.PictureBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.lblCleaning = new System.Windows.Forms.Label();
            this.lblDrainValve = new System.Windows.Forms.Label();
            this.picDrainValue = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnLeftSide = new System.Windows.Forms.Panel();
            this.vprgMonthlyReport = new VerticalProgressBar.VerticalProgressBar();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAllHistory = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblControlPanel = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picDO4Status = new System.Windows.Forms.PictureBox();
            this.picDO3Status = new System.Windows.Forms.PictureBox();
            this.picDO2Status = new System.Windows.Forms.PictureBox();
            this.picDO1Status = new System.Windows.Forms.PictureBox();
            this.btnDO4 = new System.Windows.Forms.Button();
            this.btnDO3 = new System.Windows.Forms.Button();
            this.btnDO2 = new System.Windows.Forms.Button();
            this.btnDO1 = new System.Windows.Forms.Button();
            this.lblDO4 = new System.Windows.Forms.Label();
            this.lblDO3 = new System.Windows.Forms.Label();
            this.lblDO2 = new System.Windows.Forms.Label();
            this.lblDO1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picDO8Status = new System.Windows.Forms.PictureBox();
            this.btnDO8 = new System.Windows.Forms.Button();
            this.picDO7Status = new System.Windows.Forms.PictureBox();
            this.btnDO5 = new System.Windows.Forms.Button();
            this.picDO6Status = new System.Windows.Forms.PictureBox();
            this.btnDO7 = new System.Windows.Forms.Button();
            this.picDO5Status = new System.Windows.Forms.PictureBox();
            this.lblDO5 = new System.Windows.Forms.Label();
            this.btnDO6 = new System.Windows.Forms.Button();
            this.lblDO6 = new System.Windows.Forms.Label();
            this.lblDO7 = new System.Windows.Forms.Label();
            this.lblDO8 = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnLoginLogout = new System.Windows.Forms.Button();
            this.lblLoginDisplayName = new System.Windows.Forms.Label();
            this.lblHeadingTime = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.vprgTNValue = new VerticalProgressBar.VerticalProgressBar();
            this.btnTN1Hour = new System.Windows.Forms.Button();
            this.btnTN5Minute = new System.Windows.Forms.Button();
            this.btnTNHistoryData = new System.Windows.Forms.Button();
            this.txtTNValue = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.btnTNCalibrate = new System.Windows.Forms.Button();
            this.picTNStatus = new System.Windows.Forms.PictureBox();
            this.label53 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.vprgTPValue = new VerticalProgressBar.VerticalProgressBar();
            this.label49 = new System.Windows.Forms.Label();
            this.btnTP5Minute = new System.Windows.Forms.Button();
            this.btnTPCalibrate = new System.Windows.Forms.Button();
            this.btnTP1Hour = new System.Windows.Forms.Button();
            this.picTPStatus = new System.Windows.Forms.PictureBox();
            this.txtTPValue = new System.Windows.Forms.TextBox();
            this.btnTPHistoryData = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.vprgTOCValue = new VerticalProgressBar.VerticalProgressBar();
            this.txtTOCValue = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.picTOCStatus = new System.Windows.Forms.PictureBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btnTOCCalibrate = new System.Windows.Forms.Button();
            this.btnTOC5Minute = new System.Windows.Forms.Button();
            this.btnTOCHistoryData = new System.Windows.Forms.Button();
            this.btnTOC1Hour = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel23.SuspendLayout();
            this.panel25.SuspendLayout();
            this.pnStationStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusAir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusAir1)).BeginInit();
            this.panel20.SuspendLayout();
            this.pnSoftwareInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSamplerTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusFireDetector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusMainDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusUPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusMainPower)).BeginInit();
            this.panel30.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoSamplerStatus)).BeginInit();
            this.pnbottlePosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPumpingSystemRRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPumpingSystemRFLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump2_RunningType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPumpingSystemLRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPumpingSystemLFLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump1_RunningType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPSStatus)).BeginInit();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWater)).BeginInit();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilteringSystemCleaning)).BeginInit();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrainValue)).BeginInit();
            this.pnLeftSide.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDO4Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO3Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO2Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO1Status)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDO8Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO7Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO6Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO5Status)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTNStatus)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTPStatus)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTOCStatus)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortTN
            // 
            this.serialPortTN.PortName = "COM100";
            this.serialPortTN.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortTN_DataReceived);
            // 
            // serialPortTP
            // 
            this.serialPortTP.PortName = "COM100";
            this.serialPortTP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortTP_DataReceived);
            // 
            // serialPortTOC
            // 
            this.serialPortTOC.PortName = "COM100";
            this.serialPortTOC.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortTOC_DataReceived);
            // 
            // serialPortSAMP
            // 
            this.serialPortSAMP.PortName = "COM100";
            this.serialPortSAMP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortSAMP_DataReceived);
            // 
            // serialPortADAM
            // 
            this.serialPortADAM.PortName = "COM100";
            this.serialPortADAM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortADAM_DataReceived);
            // 
            // bgwMonthlyReport
            // 
            this.bgwMonthlyReport.WorkerReportsProgress = true;
            this.bgwMonthlyReport.WorkerSupportsCancellation = true;
            this.bgwMonthlyReport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMonthlyReport_DoWork);
            this.bgwMonthlyReport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerMonthlyReport_ProgressChanged);
            this.bgwMonthlyReport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMonthlyReport_RunWorkerCompleted);
            // 
            // backgroundWorkerMain
            // 
            this.backgroundWorkerMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMain_DoWork);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Controls.Add(this.pnStationStatus);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(73, 494);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(775, 161);
            this.panel23.TabIndex = 70;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.lblStationStatus);
            this.panel25.Location = new System.Drawing.Point(318, -2);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(152, 35);
            this.panel25.TabIndex = 8;
            // 
            // lblStationStatus
            // 
            this.lblStationStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.lblStationStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStationStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStationStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStationStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblStationStatus.Name = "lblStationStatus";
            this.lblStationStatus.Padding = new System.Windows.Forms.Padding(3);
            this.lblStationStatus.Size = new System.Drawing.Size(152, 35);
            this.lblStationStatus.TabIndex = 7;
            this.lblStationStatus.Text = "Station status";
            this.lblStationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStationStatus.Click += new System.EventHandler(this.lblStationStatus_Click);
            // 
            // pnStationStatus
            // 
            this.pnStationStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStationStatus.BackgroundImage = global::DataLogger.Properties.Resources.Station1;
            this.pnStationStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnStationStatus.Controls.Add(this.picStationStatusAir2);
            this.pnStationStatus.Controls.Add(this.picStationStatusAir1);
            this.pnStationStatus.Controls.Add(this.panel20);
            this.pnStationStatus.Controls.Add(this.picStationStatusFireDetector);
            this.pnStationStatus.Controls.Add(this.picStationStatusMainDoor);
            this.pnStationStatus.Controls.Add(this.picStationStatusUPS);
            this.pnStationStatus.Controls.Add(this.picStationStatusMainPower);
            this.pnStationStatus.Controls.Add(this.lblair1);
            this.pnStationStatus.Controls.Add(this.lblFireDetector);
            this.pnStationStatus.Controls.Add(this.lblMainDoor);
            this.pnStationStatus.Controls.Add(this.lblair2);
            this.pnStationStatus.Controls.Add(this.label20);
            this.pnStationStatus.Controls.Add(this.lblMainPower);
            this.pnStationStatus.Location = new System.Drawing.Point(7, 16);
            this.pnStationStatus.Margin = new System.Windows.Forms.Padding(10);
            this.pnStationStatus.Name = "pnStationStatus";
            this.pnStationStatus.Size = new System.Drawing.Size(775, 140);
            this.pnStationStatus.TabIndex = 5;
            // 
            // picStationStatusAir2
            // 
            this.picStationStatusAir2.BackColor = System.Drawing.Color.White;
            this.picStationStatusAir2.BackgroundImage = global::DataLogger.Properties.Resources._1442240221_gnome_control_center;
            this.picStationStatusAir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStationStatusAir2.Location = new System.Drawing.Point(647, 20);
            this.picStationStatusAir2.Name = "picStationStatusAir2";
            this.picStationStatusAir2.Size = new System.Drawing.Size(92, 92);
            this.picStationStatusAir2.TabIndex = 72;
            this.picStationStatusAir2.TabStop = false;
            // 
            // picStationStatusAir1
            // 
            this.picStationStatusAir1.BackColor = System.Drawing.Color.White;
            this.picStationStatusAir1.BackgroundImage = global::DataLogger.Properties.Resources._1442240221_gnome_control_center;
            this.picStationStatusAir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStationStatusAir1.Location = new System.Drawing.Point(526, 20);
            this.picStationStatusAir1.Name = "picStationStatusAir1";
            this.picStationStatusAir1.Size = new System.Drawing.Size(92, 92);
            this.picStationStatusAir1.TabIndex = 71;
            this.picStationStatusAir1.TabStop = false;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.lblMainMenuTitle);
            this.panel20.Controls.Add(this.pnSoftwareInfo);
            this.panel20.Controls.Add(this.pictureBox52);
            this.panel20.Controls.Add(this.btnExit);
            this.panel20.Controls.Add(this.lblWaterLevel);
            this.panel20.Controls.Add(this.lblHeaderNationName);
            this.panel20.Controls.Add(this.txtData);
            this.panel20.Controls.Add(this.picSamplerTank);
            this.panel20.Controls.Add(this.btnLanguage);
            this.panel20.Controls.Add(this.pictureBox5);
            this.panel20.Controls.Add(this.listen);
            this.panel20.Controls.Add(this.button5);
            this.panel20.Controls.Add(this.button4);
            this.panel20.Location = new System.Drawing.Point(14, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(28, 15);
            this.panel20.TabIndex = 70;
            // 
            // lblMainMenuTitle
            // 
            this.lblMainMenuTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenuTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainMenuTitle.Location = new System.Drawing.Point(-51, 33);
            this.lblMainMenuTitle.Name = "lblMainMenuTitle";
            this.lblMainMenuTitle.Size = new System.Drawing.Size(150, 22);
            this.lblMainMenuTitle.TabIndex = 3;
            this.lblMainMenuTitle.Text = "MAIN MENU";
            this.lblMainMenuTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMainMenuTitle.Visible = false;
            // 
            // pnSoftwareInfo
            // 
            this.pnSoftwareInfo.BackColor = System.Drawing.Color.White;
            this.pnSoftwareInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSoftwareInfo.Controls.Add(this.label6);
            this.pnSoftwareInfo.Controls.Add(this.lblSurfaceWaterQuality);
            this.pnSoftwareInfo.Controls.Add(this.lblAutomaticMonitoring);
            this.pnSoftwareInfo.Controls.Add(this.lblThaiNguyenStation);
            this.pnSoftwareInfo.Controls.Add(this.pictureBox3);
            this.pnSoftwareInfo.Controls.Add(this.pictureBox2);
            this.pnSoftwareInfo.Location = new System.Drawing.Point(-416, 23);
            this.pnSoftwareInfo.Name = "pnSoftwareInfo";
            this.pnSoftwareInfo.Size = new System.Drawing.Size(34, 13);
            this.pnSoftwareInfo.TabIndex = 4;
            this.pnSoftwareInfo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "2015";
            // 
            // lblSurfaceWaterQuality
            // 
            this.lblSurfaceWaterQuality.AutoSize = true;
            this.lblSurfaceWaterQuality.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurfaceWaterQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSurfaceWaterQuality.Location = new System.Drawing.Point(43, 117);
            this.lblSurfaceWaterQuality.Name = "lblSurfaceWaterQuality";
            this.lblSurfaceWaterQuality.Size = new System.Drawing.Size(214, 19);
            this.lblSurfaceWaterQuality.TabIndex = 5;
            this.lblSurfaceWaterQuality.Text = "SURFACE WATER QUALITY";
            // 
            // lblAutomaticMonitoring
            // 
            this.lblAutomaticMonitoring.AutoSize = true;
            this.lblAutomaticMonitoring.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomaticMonitoring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAutomaticMonitoring.Location = new System.Drawing.Point(43, 97);
            this.lblAutomaticMonitoring.Name = "lblAutomaticMonitoring";
            this.lblAutomaticMonitoring.Size = new System.Drawing.Size(220, 19);
            this.lblAutomaticMonitoring.TabIndex = 4;
            this.lblAutomaticMonitoring.Text = "AUTOMATIC MONITORING";
            // 
            // lblThaiNguyenStation
            // 
            this.lblThaiNguyenStation.AutoSize = true;
            this.lblThaiNguyenStation.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThaiNguyenStation.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblThaiNguyenStation.Location = new System.Drawing.Point(53, 66);
            this.lblThaiNguyenStation.Name = "lblThaiNguyenStation";
            this.lblThaiNguyenStation.Size = new System.Drawing.Size(126, 19);
            this.lblThaiNguyenStation.TabIndex = 3;
            this.lblThaiNguyenStation.Text = "DMM STATION";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::DataLogger.Properties.Resources.Flag_of_South_Korea_48x32;
            this.pictureBox3.Location = new System.Drawing.Point(202, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 32);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DataLogger.Properties.Resources.Flag_of_Vietnam_43x32;
            this.pictureBox2.Location = new System.Drawing.Point(76, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox52
            // 
            this.pictureBox52.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox52.BackgroundImage = global::DataLogger.Properties.Resources.SamplerTank_Ruler;
            this.pictureBox52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox52.Location = new System.Drawing.Point(138, 32);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(10, 25);
            this.pictureBox52.TabIndex = 63;
            this.pictureBox52.TabStop = false;
            this.pictureBox52.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.BackgroundImage = global::DataLogger.Properties.Resources.Shutdown_Box_Red;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Enabled = false;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(154, 32);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 10);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWaterLevel
            // 
            this.lblWaterLevel.AutoSize = true;
            this.lblWaterLevel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterLevel.Location = new System.Drawing.Point(-47, 36);
            this.lblWaterLevel.Name = "lblWaterLevel";
            this.lblWaterLevel.Size = new System.Drawing.Size(67, 15);
            this.lblWaterLevel.TabIndex = 31;
            this.lblWaterLevel.Text = "Water level";
            this.lblWaterLevel.Visible = false;
            // 
            // lblHeaderNationName
            // 
            this.lblHeaderNationName.AutoSize = true;
            this.lblHeaderNationName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderNationName.ForeColor = System.Drawing.Color.White;
            this.lblHeaderNationName.Location = new System.Drawing.Point(-316, 34);
            this.lblHeaderNationName.Name = "lblHeaderNationName";
            this.lblHeaderNationName.Size = new System.Drawing.Size(84, 17);
            this.lblHeaderNationName.TabIndex = 1;
            this.lblHeaderNationName.Text = "Vietnamese";
            this.lblHeaderNationName.Visible = false;
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.ForeColor = System.Drawing.Color.Maroon;
            this.txtData.Location = new System.Drawing.Point(94, 41);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(48, 10);
            this.txtData.TabIndex = 62;
            this.txtData.Text = "";
            this.txtData.Visible = false;
            // 
            // picSamplerTank
            // 
            this.picSamplerTank.BackColor = System.Drawing.Color.White;
            this.picSamplerTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSamplerTank.Image = global::DataLogger.Properties.Resources.SamplerTankerWater;
            this.picSamplerTank.Location = new System.Drawing.Point(110, 31);
            this.picSamplerTank.Name = "picSamplerTank";
            this.picSamplerTank.Size = new System.Drawing.Size(12, 26);
            this.picSamplerTank.TabIndex = 31;
            this.picSamplerTank.TabStop = false;
            this.picSamplerTank.Visible = false;
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.Transparent;
            this.btnLanguage.BackgroundImage = global::DataLogger.Properties.Resources.Flag_of_Vietnam_43x32;
            this.btnLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLanguage.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.Location = new System.Drawing.Point(-365, 29);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(43, 16);
            this.btnLanguage.TabIndex = 50;
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Visible = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DataLogger.Properties.Resources.WaterLevel;
            this.pictureBox5.Location = new System.Drawing.Point(-107, 34);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // listen
            // 
            this.listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.listen.BoderWidthActive = 2;
            this.listen.BoderWidthNormal = 1;
            this.listen.ColorBoderActive = System.Drawing.Color.Green;
            this.listen.ColorBoderHover = System.Drawing.Color.Gray;
            this.listen.ColorBoderNormal = System.Drawing.Color.Silver;
            this.listen.IsActive = false;
            this.listen.Location = new System.Drawing.Point(-487, 26);
            this.listen.Margin = new System.Windows.Forms.Padding(4);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(60, 10);
            this.listen.TabIndex = 68;
            this.listen.ToolTipHint = "";
            this.listen.Visible = false;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::DataLogger.Properties.Resources.logo;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(196)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(-226, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 22);
            this.button5.TabIndex = 67;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::DataLogger.Properties.Resources.clock;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(196)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(-173, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 24);
            this.button4.TabIndex = 66;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // picStationStatusFireDetector
            // 
            this.picStationStatusFireDetector.BackColor = System.Drawing.Color.White;
            this.picStationStatusFireDetector.BackgroundImage = global::DataLogger.Properties.Resources._1442240221_gnome_control_center;
            this.picStationStatusFireDetector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStationStatusFireDetector.Location = new System.Drawing.Point(402, 20);
            this.picStationStatusFireDetector.Name = "picStationStatusFireDetector";
            this.picStationStatusFireDetector.Size = new System.Drawing.Size(91, 91);
            this.picStationStatusFireDetector.TabIndex = 40;
            this.picStationStatusFireDetector.TabStop = false;
            // 
            // picStationStatusMainDoor
            // 
            this.picStationStatusMainDoor.BackColor = System.Drawing.Color.White;
            this.picStationStatusMainDoor.BackgroundImage = global::DataLogger.Properties.Resources._1442240221_gnome_control_center;
            this.picStationStatusMainDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStationStatusMainDoor.Location = new System.Drawing.Point(275, 20);
            this.picStationStatusMainDoor.Name = "picStationStatusMainDoor";
            this.picStationStatusMainDoor.Size = new System.Drawing.Size(92, 92);
            this.picStationStatusMainDoor.TabIndex = 39;
            this.picStationStatusMainDoor.TabStop = false;
            // 
            // picStationStatusUPS
            // 
            this.picStationStatusUPS.BackColor = System.Drawing.Color.White;
            this.picStationStatusUPS.BackgroundImage = global::DataLogger.Properties.Resources._1442240221_gnome_control_center;
            this.picStationStatusUPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStationStatusUPS.Location = new System.Drawing.Point(154, 20);
            this.picStationStatusUPS.Name = "picStationStatusUPS";
            this.picStationStatusUPS.Size = new System.Drawing.Size(92, 92);
            this.picStationStatusUPS.TabIndex = 37;
            this.picStationStatusUPS.TabStop = false;
            // 
            // picStationStatusMainPower
            // 
            this.picStationStatusMainPower.BackColor = System.Drawing.Color.White;
            this.picStationStatusMainPower.BackgroundImage = global::DataLogger.Properties.Resources._1442240221_gnome_control_center;
            this.picStationStatusMainPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStationStatusMainPower.Location = new System.Drawing.Point(33, 20);
            this.picStationStatusMainPower.Name = "picStationStatusMainPower";
            this.picStationStatusMainPower.Size = new System.Drawing.Size(92, 92);
            this.picStationStatusMainPower.TabIndex = 32;
            this.picStationStatusMainPower.TabStop = false;
            this.picStationStatusMainPower.Click += new System.EventHandler(this.picStationStatusMainPower_Click);
            // 
            // lblair1
            // 
            this.lblair1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblair1.Location = new System.Drawing.Point(521, 114);
            this.lblair1.Name = "lblair1";
            this.lblair1.Size = new System.Drawing.Size(100, 20);
            this.lblair1.TabIndex = 36;
            this.lblair1.Text = "Cooling 1";
            this.lblair1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblair1.Click += new System.EventHandler(this.lblHumidity_Click);
            // 
            // lblFireDetector
            // 
            this.lblFireDetector.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFireDetector.Location = new System.Drawing.Point(397, 114);
            this.lblFireDetector.Name = "lblFireDetector";
            this.lblFireDetector.Size = new System.Drawing.Size(100, 20);
            this.lblFireDetector.TabIndex = 35;
            this.lblFireDetector.Text = "Fire detector";
            this.lblFireDetector.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMainDoor
            // 
            this.lblMainDoor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainDoor.Location = new System.Drawing.Point(278, 113);
            this.lblMainDoor.Name = "lblMainDoor";
            this.lblMainDoor.Size = new System.Drawing.Size(87, 20);
            this.lblMainDoor.TabIndex = 34;
            this.lblMainDoor.Text = "Main door";
            this.lblMainDoor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblair2
            // 
            this.lblair2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblair2.Location = new System.Drawing.Point(644, 113);
            this.lblair2.Name = "lblair2";
            this.lblair2.Size = new System.Drawing.Size(100, 20);
            this.lblair2.TabIndex = 33;
            this.lblair2.Text = "Cooling 2";
            this.lblair2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(145, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 20);
            this.label20.TabIndex = 32;
            this.label20.Text = "Generator";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMainPower
            // 
            this.lblMainPower.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPower.Location = new System.Drawing.Point(28, 112);
            this.lblMainPower.Name = "lblMainPower";
            this.lblMainPower.Size = new System.Drawing.Size(100, 20);
            this.lblMainPower.TabIndex = 31;
            this.lblMainPower.Text = "Main Power";
            this.lblMainPower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMainPower.Click += new System.EventHandler(this.lblMainPower_Click);
            // 
            // panel30
            // 
            this.panel30.AutoSize = true;
            this.panel30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel30.BackColor = System.Drawing.Color.Transparent;
            this.panel30.BackgroundImage = global::DataLogger.Properties.Resources.main;
            this.panel30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel30.Controls.Add(this.panel19);
            this.panel30.Controls.Add(this.panel17);
            this.panel30.Controls.Add(this.panel15);
            this.panel30.Controls.Add(this.panel14);
            this.panel30.Controls.Add(this.panel13);
            this.panel30.Controls.Add(this.panel9);
            this.panel30.Controls.Add(this.panel5);
            this.panel30.Controls.Add(this.panel3);
            this.panel30.Controls.Add(this.panel1);
            this.panel30.Controls.Add(this.panel6);
            this.panel30.Controls.Add(this.panel22);
            this.panel30.Controls.Add(this.panel26);
            this.panel30.Controls.Add(this.lblDrainValve);
            this.panel30.Controls.Add(this.picDrainValue);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel30.Location = new System.Drawing.Point(80, 57);
            this.panel30.Margin = new System.Windows.Forms.Padding(10);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(761, 424);
            this.panel30.TabIndex = 65;
            this.panel30.Paint += new System.Windows.Forms.PaintEventHandler(this.panel30_Paint);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Transparent;
            this.panel19.Location = new System.Drawing.Point(205, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(40, 10);
            this.panel19.TabIndex = 74;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Location = new System.Drawing.Point(457, 411);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(40, 10);
            this.panel17.TabIndex = 73;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Location = new System.Drawing.Point(744, 10);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(40, 10);
            this.panel15.TabIndex = 72;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.panel14.Controls.Add(this.lblFilteringSystem);
            this.panel14.Location = new System.Drawing.Point(19, 298);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(160, 32);
            this.panel14.TabIndex = 71;
            // 
            // lblFilteringSystem
            // 
            this.lblFilteringSystem.AutoSize = true;
            this.lblFilteringSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.lblFilteringSystem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilteringSystem.ForeColor = System.Drawing.Color.White;
            this.lblFilteringSystem.Location = new System.Drawing.Point(7, 0);
            this.lblFilteringSystem.Name = "lblFilteringSystem";
            this.lblFilteringSystem.Padding = new System.Windows.Forms.Padding(5);
            this.lblFilteringSystem.Size = new System.Drawing.Size(142, 29);
            this.lblFilteringSystem.TabIndex = 5;
            this.lblFilteringSystem.Text = "Filtering system";
            this.lblFilteringSystem.Click += new System.EventHandler(this.lblFilteringSystem_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.panel13.Controls.Add(this.lblPumpingSystem);
            this.panel13.Location = new System.Drawing.Point(18, 10);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(149, 33);
            this.panel13.TabIndex = 70;
            // 
            // lblPumpingSystem
            // 
            this.lblPumpingSystem.AutoSize = true;
            this.lblPumpingSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.lblPumpingSystem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPumpingSystem.ForeColor = System.Drawing.Color.White;
            this.lblPumpingSystem.Location = new System.Drawing.Point(4, 2);
            this.lblPumpingSystem.Name = "lblPumpingSystem";
            this.lblPumpingSystem.Padding = new System.Windows.Forms.Padding(5);
            this.lblPumpingSystem.Size = new System.Drawing.Size(142, 29);
            this.lblPumpingSystem.TabIndex = 4;
            this.lblPumpingSystem.Text = "Pumping System";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(509, 6);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(3);
            this.panel9.Size = new System.Drawing.Size(114, 37);
            this.panel9.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 66;
            this.label2.Text = "MPS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.panel5.Controls.Add(this.lblAutorSampler);
            this.panel5.Location = new System.Drawing.Point(272, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(154, 37);
            this.panel5.TabIndex = 68;
            // 
            // lblAutorSampler
            // 
            this.lblAutorSampler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAutorSampler.AutoSize = true;
            this.lblAutorSampler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.lblAutorSampler.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorSampler.ForeColor = System.Drawing.Color.White;
            this.lblAutorSampler.Location = new System.Drawing.Point(20, 4);
            this.lblAutorSampler.Name = "lblAutorSampler";
            this.lblAutorSampler.Padding = new System.Windows.Forms.Padding(5);
            this.lblAutorSampler.Size = new System.Drawing.Size(120, 29);
            this.lblAutorSampler.TabIndex = 4;
            this.lblAutorSampler.Text = "Auto Sampler";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::DataLogger.Properties.Resources.Auto_Samper;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnAutoSamplerTesting);
            this.panel3.Controls.Add(this.btnAutoSamplerHistoryData);
            this.panel3.Controls.Add(this.picAutoSamplerStatus);
            this.panel3.Controls.Add(this.pnbottlePosition);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(264, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 270);
            this.panel3.TabIndex = 0;
            // 
            // btnAutoSamplerTesting
            // 
            this.btnAutoSamplerTesting.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoSamplerTesting.BackgroundImage = global::DataLogger.Properties.Resources._9;
            this.btnAutoSamplerTesting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutoSamplerTesting.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAutoSamplerTesting.FlatAppearance.BorderSize = 0;
            this.btnAutoSamplerTesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoSamplerTesting.Location = new System.Drawing.Point(134, 213);
            this.btnAutoSamplerTesting.Name = "btnAutoSamplerTesting";
            this.btnAutoSamplerTesting.Size = new System.Drawing.Size(48, 48);
            this.btnAutoSamplerTesting.TabIndex = 50;
            this.btnAutoSamplerTesting.UseVisualStyleBackColor = false;
            this.btnAutoSamplerTesting.Click += new System.EventHandler(this.btnAutoSamplerTesting_Click);
            this.btnAutoSamplerTesting.MouseHover += new System.EventHandler(this.btnAutoSamplerTesting_MouseHover);
            // 
            // btnAutoSamplerHistoryData
            // 
            this.btnAutoSamplerHistoryData.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoSamplerHistoryData.BackgroundImage = global::DataLogger.Properties.Resources._8;
            this.btnAutoSamplerHistoryData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutoSamplerHistoryData.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAutoSamplerHistoryData.FlatAppearance.BorderSize = 0;
            this.btnAutoSamplerHistoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoSamplerHistoryData.Location = new System.Drawing.Point(78, 214);
            this.btnAutoSamplerHistoryData.Name = "btnAutoSamplerHistoryData";
            this.btnAutoSamplerHistoryData.Size = new System.Drawing.Size(48, 48);
            this.btnAutoSamplerHistoryData.TabIndex = 50;
            this.btnAutoSamplerHistoryData.UseVisualStyleBackColor = false;
            this.btnAutoSamplerHistoryData.Click += new System.EventHandler(this.btnAutoSamplerHistoryData_Click);
            // 
            // picAutoSamplerStatus
            // 
            this.picAutoSamplerStatus.BackColor = System.Drawing.Color.Transparent;
            this.picAutoSamplerStatus.BackgroundImage = global::DataLogger.Properties.Resources.Normal;
            this.picAutoSamplerStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAutoSamplerStatus.Location = new System.Drawing.Point(11, 213);
            this.picAutoSamplerStatus.Name = "picAutoSamplerStatus";
            this.picAutoSamplerStatus.Size = new System.Drawing.Size(48, 48);
            this.picAutoSamplerStatus.TabIndex = 7;
            this.picAutoSamplerStatus.TabStop = false;
            this.picAutoSamplerStatus.MouseHover += new System.EventHandler(this.picAutoSamplerStatus_MouseHover);
            // 
            // pnbottlePosition
            // 
            this.pnbottlePosition.BackColor = System.Drawing.Color.Transparent;
            this.pnbottlePosition.BackgroundImage = global::DataLogger.Properties.Resources.model;
            this.pnbottlePosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnbottlePosition.Controls.Add(this.pictureBox4);
            this.pnbottlePosition.Controls.Add(this.txtAutoSamplerTemp);
            this.pnbottlePosition.Location = new System.Drawing.Point(4, 22);
            this.pnbottlePosition.Name = "pnbottlePosition";
            this.pnbottlePosition.Size = new System.Drawing.Size(178, 178);
            this.pnbottlePosition.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(104, 77);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 27);
            this.pictureBox4.TabIndex = 66;
            this.pictureBox4.TabStop = false;
            // 
            // txtAutoSamplerTemp
            // 
            this.txtAutoSamplerTemp.BackColor = System.Drawing.Color.White;
            this.txtAutoSamplerTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutoSamplerTemp.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSamplerTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtAutoSamplerTemp.Location = new System.Drawing.Point(68, 82);
            this.txtAutoSamplerTemp.Name = "txtAutoSamplerTemp";
            this.txtAutoSamplerTemp.ReadOnly = true;
            this.txtAutoSamplerTemp.Size = new System.Drawing.Size(30, 20);
            this.txtAutoSamplerTemp.TabIndex = 67;
            this.txtAutoSamplerTemp.Text = "---";
            this.txtAutoSamplerTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::DataLogger.Properties.Resources.Pumpling_System;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblRRS);
            this.panel1.Controls.Add(this.lblPumpRRS);
            this.panel1.Controls.Add(this.lblLRS);
            this.panel1.Controls.Add(this.lblPumpRFLTName);
            this.panel1.Controls.Add(this.lblPumpRFLT);
            this.panel1.Controls.Add(this.lblPumpLFLTName);
            this.panel1.Controls.Add(this.lblPumpRAM);
            this.panel1.Controls.Add(this.lblPumpLAM);
            this.panel1.Controls.Add(this.lblPumpLRS);
            this.panel1.Controls.Add(this.lblPumpLFLT);
            this.panel1.Controls.Add(this.picPumpingSystemRRS);
            this.panel1.Controls.Add(this.picPumpingSystemRFLT);
            this.panel1.Controls.Add(this.picPump2_RunningType);
            this.panel1.Controls.Add(this.picPumpingSystemLRS);
            this.panel1.Controls.Add(this.picPumpingSystemLFLT);
            this.panel1.Controls.Add(this.picPump1_RunningType);
            this.panel1.Controls.Add(this.lblPump2);
            this.panel1.Controls.Add(this.picPump2);
            this.panel1.Controls.Add(this.lblPump1);
            this.panel1.Controls.Add(this.picPump1);
            this.panel1.Location = new System.Drawing.Point(17, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 260);
            this.panel1.TabIndex = 0;
            // 
            // lblRRS
            // 
            this.lblRRS.AutoSize = true;
            this.lblRRS.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRRS.Location = new System.Drawing.Point(102, 345);
            this.lblRRS.Name = "lblRRS";
            this.lblRRS.Size = new System.Drawing.Size(68, 13);
            this.lblRRS.TabIndex = 78;
            this.lblRRS.Text = "Pump(R)RS";
            this.lblRRS.Visible = false;
            // 
            // lblPumpRRS
            // 
            this.lblPumpRRS.AutoSize = true;
            this.lblPumpRRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPumpRRS.Location = new System.Drawing.Point(114, 330);
            this.lblPumpRRS.Name = "lblPumpRRS";
            this.lblPumpRRS.Size = new System.Drawing.Size(33, 13);
            this.lblPumpRRS.TabIndex = 29;
            this.lblPumpRRS.Text = "Stop";
            this.lblPumpRRS.Visible = false;
            // 
            // lblLRS
            // 
            this.lblLRS.AutoSize = true;
            this.lblLRS.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLRS.Location = new System.Drawing.Point(13, 345);
            this.lblLRS.Name = "lblLRS";
            this.lblLRS.Size = new System.Drawing.Size(67, 13);
            this.lblLRS.TabIndex = 77;
            this.lblLRS.Text = "Pump(L)RS";
            this.lblLRS.Visible = false;
            // 
            // lblPumpRFLTName
            // 
            this.lblPumpRFLTName.AutoSize = true;
            this.lblPumpRFLTName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPumpRFLTName.Location = new System.Drawing.Point(102, 256);
            this.lblPumpRFLTName.Name = "lblPumpRFLTName";
            this.lblPumpRFLTName.Size = new System.Drawing.Size(71, 13);
            this.lblPumpRFLTName.TabIndex = 76;
            this.lblPumpRFLTName.Text = "Pump(R)FLT";
            this.lblPumpRFLTName.Visible = false;
            // 
            // lblPumpRFLT
            // 
            this.lblPumpRFLT.AutoSize = true;
            this.lblPumpRFLT.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPumpRFLT.Location = new System.Drawing.Point(113, 242);
            this.lblPumpRFLT.Name = "lblPumpRFLT";
            this.lblPumpRFLT.Size = new System.Drawing.Size(34, 13);
            this.lblPumpRFLT.TabIndex = 28;
            this.lblPumpRFLT.Text = "Fault";
            this.lblPumpRFLT.Click += new System.EventHandler(this.lblPumpRFLT_Click);
            // 
            // lblPumpLFLTName
            // 
            this.lblPumpLFLTName.AutoSize = true;
            this.lblPumpLFLTName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPumpLFLTName.Location = new System.Drawing.Point(13, 256);
            this.lblPumpLFLTName.Name = "lblPumpLFLTName";
            this.lblPumpLFLTName.Size = new System.Drawing.Size(70, 13);
            this.lblPumpLFLTName.TabIndex = 75;
            this.lblPumpLFLTName.Text = "Pump(L)FLT";
            this.lblPumpLFLTName.Visible = false;
            // 
            // lblPumpRAM
            // 
            this.lblPumpRAM.AutoSize = true;
            this.lblPumpRAM.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPumpRAM.Location = new System.Drawing.Point(102, 171);
            this.lblPumpRAM.Name = "lblPumpRAM";
            this.lblPumpRAM.Size = new System.Drawing.Size(74, 13);
            this.lblPumpRAM.TabIndex = 27;
            this.lblPumpRAM.Text = "Pump(R)A/M";
            // 
            // lblPumpLAM
            // 
            this.lblPumpLAM.AutoSize = true;
            this.lblPumpLAM.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPumpLAM.Location = new System.Drawing.Point(13, 171);
            this.lblPumpLAM.Name = "lblPumpLAM";
            this.lblPumpLAM.Size = new System.Drawing.Size(73, 13);
            this.lblPumpLAM.TabIndex = 26;
            this.lblPumpLAM.Text = "Pump(L)A/M";
            this.lblPumpLAM.Click += new System.EventHandler(this.lblPumpLAM_Click);
            // 
            // lblPumpLRS
            // 
            this.lblPumpLRS.AutoSize = true;
            this.lblPumpLRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPumpLRS.Location = new System.Drawing.Point(32, 330);
            this.lblPumpLRS.Name = "lblPumpLRS";
            this.lblPumpLRS.Size = new System.Drawing.Size(33, 13);
            this.lblPumpLRS.TabIndex = 22;
            this.lblPumpLRS.Text = "Stop";
            this.lblPumpLRS.Visible = false;
            // 
            // lblPumpLFLT
            // 
            this.lblPumpLFLT.AutoSize = true;
            this.lblPumpLFLT.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPumpLFLT.Location = new System.Drawing.Point(27, 242);
            this.lblPumpLFLT.Name = "lblPumpLFLT";
            this.lblPumpLFLT.Size = new System.Drawing.Size(34, 13);
            this.lblPumpLFLT.TabIndex = 20;
            this.lblPumpLFLT.Text = "Fault";
            // 
            // picPumpingSystemRRS
            // 
            this.picPumpingSystemRRS.Image = global::DataLogger.Properties.Resources.Stop_42x42;
            this.picPumpingSystemRRS.Location = new System.Drawing.Point(109, 278);
            this.picPumpingSystemRRS.Name = "picPumpingSystemRRS";
            this.picPumpingSystemRRS.Size = new System.Drawing.Size(42, 42);
            this.picPumpingSystemRRS.TabIndex = 18;
            this.picPumpingSystemRRS.TabStop = false;
            this.picPumpingSystemRRS.Visible = false;
            // 
            // picPumpingSystemRFLT
            // 
            this.picPumpingSystemRFLT.Image = global::DataLogger.Properties.Resources.Fault_42x42;
            this.picPumpingSystemRFLT.Location = new System.Drawing.Point(109, 193);
            this.picPumpingSystemRFLT.Name = "picPumpingSystemRFLT";
            this.picPumpingSystemRFLT.Size = new System.Drawing.Size(42, 42);
            this.picPumpingSystemRFLT.TabIndex = 17;
            this.picPumpingSystemRFLT.TabStop = false;
            // 
            // picPump2_RunningType
            // 
            this.picPump2_RunningType.Image = global::DataLogger.Properties.Resources.Fault_56x56;
            this.picPump2_RunningType.Location = new System.Drawing.Point(105, 108);
            this.picPump2_RunningType.Name = "picPump2_RunningType";
            this.picPump2_RunningType.Size = new System.Drawing.Size(73, 56);
            this.picPump2_RunningType.TabIndex = 16;
            this.picPump2_RunningType.TabStop = false;
            // 
            // picPumpingSystemLRS
            // 
            this.picPumpingSystemLRS.Image = global::DataLogger.Properties.Resources.Stop_42x42;
            this.picPumpingSystemLRS.Location = new System.Drawing.Point(27, 278);
            this.picPumpingSystemLRS.Name = "picPumpingSystemLRS";
            this.picPumpingSystemLRS.Size = new System.Drawing.Size(42, 42);
            this.picPumpingSystemLRS.TabIndex = 14;
            this.picPumpingSystemLRS.TabStop = false;
            this.picPumpingSystemLRS.Visible = false;
            // 
            // picPumpingSystemLFLT
            // 
            this.picPumpingSystemLFLT.Image = global::DataLogger.Properties.Resources.Fault_42x42;
            this.picPumpingSystemLFLT.Location = new System.Drawing.Point(27, 193);
            this.picPumpingSystemLFLT.Name = "picPumpingSystemLFLT";
            this.picPumpingSystemLFLT.Size = new System.Drawing.Size(42, 42);
            this.picPumpingSystemLFLT.TabIndex = 13;
            this.picPumpingSystemLFLT.TabStop = false;
            // 
            // picPump1_RunningType
            // 
            this.picPump1_RunningType.Image = global::DataLogger.Properties.Resources.Fault_56x56;
            this.picPump1_RunningType.Location = new System.Drawing.Point(12, 108);
            this.picPump1_RunningType.Name = "picPump1_RunningType";
            this.picPump1_RunningType.Size = new System.Drawing.Size(69, 56);
            this.picPump1_RunningType.TabIndex = 12;
            this.picPump1_RunningType.TabStop = false;
            // 
            // lblPump2
            // 
            this.lblPump2.AutoSize = true;
            this.lblPump2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPump2.Location = new System.Drawing.Point(102, 91);
            this.lblPump2.Name = "lblPump2";
            this.lblPump2.Size = new System.Drawing.Size(46, 13);
            this.lblPump2.TabIndex = 11;
            this.lblPump2.Text = "Pump 2";
            // 
            // picPump2
            // 
            this.picPump2.Image = global::DataLogger.Properties.Resources.pump_56x56;
            this.picPump2.Location = new System.Drawing.Point(105, 25);
            this.picPump2.Name = "picPump2";
            this.picPump2.Size = new System.Drawing.Size(56, 56);
            this.picPump2.TabIndex = 10;
            this.picPump2.TabStop = false;
            // 
            // lblPump1
            // 
            this.lblPump1.AutoSize = true;
            this.lblPump1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPump1.Location = new System.Drawing.Point(17, 90);
            this.lblPump1.Name = "lblPump1";
            this.lblPump1.Size = new System.Drawing.Size(46, 13);
            this.lblPump1.TabIndex = 9;
            this.lblPump1.Text = "Pump 1";
            // 
            // picPump1
            // 
            this.picPump1.Image = global::DataLogger.Properties.Resources.pump_56x56;
            this.picPump1.Location = new System.Drawing.Point(20, 25);
            this.picPump1.Name = "picPump1";
            this.picPump1.Size = new System.Drawing.Size(56, 56);
            this.picPump1.TabIndex = 7;
            this.picPump1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::DataLogger.Properties.Resources.mps129;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label64);
            this.panel6.Controls.Add(this.label63);
            this.panel6.Controls.Add(this.label62);
            this.panel6.Controls.Add(this.btnMPSHistoryData);
            this.panel6.Controls.Add(this.btnMPS1Hour);
            this.panel6.Controls.Add(this.btnMPS5Minute);
            this.panel6.Controls.Add(this.picMPSStatus);
            this.panel6.Controls.Add(this.txtMPSCondValue);
            this.panel6.Controls.Add(this.txtMPSTurbValue);
            this.panel6.Controls.Add(this.txtMPSDOValue);
            this.panel6.Controls.Add(this.txtMPSTempValue);
            this.panel6.Controls.Add(this.txtMPSORPValue);
            this.panel6.Controls.Add(this.txtMPSpHValue);
            this.panel6.Controls.Add(this.label40);
            this.panel6.Controls.Add(this.label41);
            this.panel6.Controls.Add(this.label38);
            this.panel6.Controls.Add(this.label39);
            this.panel6.Controls.Add(this.label37);
            this.panel6.Controls.Add(this.label36);
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(509, 28);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 263);
            this.panel6.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(183, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 19);
            this.label12.TabIndex = 66;
            this.label12.Text = "mV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(188, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.Black;
            this.label64.Location = new System.Drawing.Point(181, 177);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(49, 19);
            this.label64.TabIndex = 65;
            this.label64.Text = "uS/cm";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.Black;
            this.label63.Location = new System.Drawing.Point(181, 145);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(43, 19);
            this.label63.TabIndex = 64;
            this.label63.Text = "mg/L";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.Black;
            this.label62.Location = new System.Drawing.Point(183, 112);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(43, 19);
            this.label62.TabIndex = 63;
            this.label62.Text = "mg/L";
            this.label62.Click += new System.EventHandler(this.label62_Click);
            // 
            // btnMPSHistoryData
            // 
            this.btnMPSHistoryData.BackColor = System.Drawing.Color.Transparent;
            this.btnMPSHistoryData.BackgroundImage = global::DataLogger.Properties.Resources._8;
            this.btnMPSHistoryData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMPSHistoryData.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMPSHistoryData.FlatAppearance.BorderSize = 0;
            this.btnMPSHistoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPSHistoryData.Location = new System.Drawing.Point(185, 215);
            this.btnMPSHistoryData.Name = "btnMPSHistoryData";
            this.btnMPSHistoryData.Size = new System.Drawing.Size(42, 42);
            this.btnMPSHistoryData.TabIndex = 50;
            this.btnMPSHistoryData.UseVisualStyleBackColor = false;
            this.btnMPSHistoryData.Click += new System.EventHandler(this.btnMPSHistoryData_Click);
            // 
            // btnMPS1Hour
            // 
            this.btnMPS1Hour.BackColor = System.Drawing.Color.Transparent;
            this.btnMPS1Hour.BackgroundImage = global::DataLogger.Properties.Resources._11;
            this.btnMPS1Hour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMPS1Hour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMPS1Hour.FlatAppearance.BorderSize = 0;
            this.btnMPS1Hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPS1Hour.Location = new System.Drawing.Point(130, 215);
            this.btnMPS1Hour.Name = "btnMPS1Hour";
            this.btnMPS1Hour.Size = new System.Drawing.Size(42, 42);
            this.btnMPS1Hour.TabIndex = 50;
            this.btnMPS1Hour.UseVisualStyleBackColor = false;
            this.btnMPS1Hour.Click += new System.EventHandler(this.btnMPS1Hour_Click);
            // 
            // btnMPS5Minute
            // 
            this.btnMPS5Minute.BackColor = System.Drawing.Color.Transparent;
            this.btnMPS5Minute.BackgroundImage = global::DataLogger.Properties.Resources._10;
            this.btnMPS5Minute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMPS5Minute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMPS5Minute.FlatAppearance.BorderSize = 0;
            this.btnMPS5Minute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPS5Minute.Location = new System.Drawing.Point(78, 215);
            this.btnMPS5Minute.Name = "btnMPS5Minute";
            this.btnMPS5Minute.Size = new System.Drawing.Size(42, 42);
            this.btnMPS5Minute.TabIndex = 50;
            this.btnMPS5Minute.UseVisualStyleBackColor = true;
            this.btnMPS5Minute.Click += new System.EventHandler(this.btnMPS5Minute_Click);
            // 
            // picMPSStatus
            // 
            this.picMPSStatus.BackColor = System.Drawing.Color.Transparent;
            this.picMPSStatus.BackgroundImage = global::DataLogger.Properties.Resources.Normal;
            this.picMPSStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMPSStatus.Location = new System.Drawing.Point(9, 215);
            this.picMPSStatus.Name = "picMPSStatus";
            this.picMPSStatus.Size = new System.Drawing.Size(42, 42);
            this.picMPSStatus.TabIndex = 59;
            this.picMPSStatus.TabStop = false;
            // 
            // txtMPSCondValue
            // 
            this.txtMPSCondValue.BackColor = System.Drawing.Color.White;
            this.txtMPSCondValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMPSCondValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPSCondValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtMPSCondValue.Location = new System.Drawing.Point(84, 177);
            this.txtMPSCondValue.Name = "txtMPSCondValue";
            this.txtMPSCondValue.ReadOnly = true;
            this.txtMPSCondValue.Size = new System.Drawing.Size(64, 19);
            this.txtMPSCondValue.TabIndex = 56;
            this.txtMPSCondValue.Text = "117.242";
            this.txtMPSCondValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMPSTurbValue
            // 
            this.txtMPSTurbValue.BackColor = System.Drawing.Color.White;
            this.txtMPSTurbValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMPSTurbValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPSTurbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtMPSTurbValue.Location = new System.Drawing.Point(84, 145);
            this.txtMPSTurbValue.Name = "txtMPSTurbValue";
            this.txtMPSTurbValue.ReadOnly = true;
            this.txtMPSTurbValue.Size = new System.Drawing.Size(64, 19);
            this.txtMPSTurbValue.TabIndex = 55;
            this.txtMPSTurbValue.Text = "9.29";
            this.txtMPSTurbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMPSDOValue
            // 
            this.txtMPSDOValue.BackColor = System.Drawing.Color.White;
            this.txtMPSDOValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMPSDOValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPSDOValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtMPSDOValue.Location = new System.Drawing.Point(84, 112);
            this.txtMPSDOValue.Name = "txtMPSDOValue";
            this.txtMPSDOValue.ReadOnly = true;
            this.txtMPSDOValue.Size = new System.Drawing.Size(64, 19);
            this.txtMPSDOValue.TabIndex = 54;
            this.txtMPSDOValue.Text = "6.88";
            this.txtMPSDOValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMPSTempValue
            // 
            this.txtMPSTempValue.BackColor = System.Drawing.Color.White;
            this.txtMPSTempValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMPSTempValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPSTempValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtMPSTempValue.Location = new System.Drawing.Point(84, 79);
            this.txtMPSTempValue.Name = "txtMPSTempValue";
            this.txtMPSTempValue.ReadOnly = true;
            this.txtMPSTempValue.Size = new System.Drawing.Size(64, 19);
            this.txtMPSTempValue.TabIndex = 53;
            this.txtMPSTempValue.Text = "27.65";
            this.txtMPSTempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMPSORPValue
            // 
            this.txtMPSORPValue.BackColor = System.Drawing.Color.White;
            this.txtMPSORPValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMPSORPValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPSORPValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtMPSORPValue.Location = new System.Drawing.Point(84, 49);
            this.txtMPSORPValue.Name = "txtMPSORPValue";
            this.txtMPSORPValue.ReadOnly = true;
            this.txtMPSORPValue.Size = new System.Drawing.Size(64, 19);
            this.txtMPSORPValue.TabIndex = 52;
            this.txtMPSORPValue.Text = "426.17";
            this.txtMPSORPValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMPSpHValue
            // 
            this.txtMPSpHValue.BackColor = System.Drawing.Color.White;
            this.txtMPSpHValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMPSpHValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPSpHValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtMPSpHValue.Location = new System.Drawing.Point(83, 20);
            this.txtMPSpHValue.Name = "txtMPSpHValue";
            this.txtMPSpHValue.Size = new System.Drawing.Size(64, 19);
            this.txtMPSpHValue.TabIndex = 51;
            this.txtMPSpHValue.Text = "7.20";
            this.txtMPSpHValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMPSpHValue.TextChanged += new System.EventHandler(this.txtMPSpHValue_TextChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(36, 177);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(35, 19);
            this.label40.TabIndex = 50;
            this.label40.Text = "EC:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(29, 145);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(42, 19);
            this.label41.TabIndex = 49;
            this.label41.Text = "TSS:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(36, 112);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(38, 19);
            this.label38.TabIndex = 48;
            this.label38.Text = "DO:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(23, 80);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(51, 19);
            this.label39.TabIndex = 47;
            this.label39.Text = "Temp:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(27, 50);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 19);
            this.label37.TabIndex = 46;
            this.label37.Text = "ORP:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(40, 20);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 19);
            this.label36.TabIndex = 45;
            this.label36.Text = "pH:";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Transparent;
            this.panel22.BackgroundImage = global::DataLogger.Properties.Resources.SamplerTank;
            this.panel22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel22.Controls.Add(this.pictureBoxWater);
            this.panel22.Controls.Add(this.lblSamplerTank);
            this.panel22.Location = new System.Drawing.Point(510, 293);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(239, 55);
            this.panel22.TabIndex = 49;
            // 
            // pictureBoxWater
            // 
            this.pictureBoxWater.BackColor = System.Drawing.Color.White;
            this.pictureBoxWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWater.Location = new System.Drawing.Point(147, 3);
            this.pictureBoxWater.Name = "pictureBoxWater";
            this.pictureBoxWater.Size = new System.Drawing.Size(10, 44);
            this.pictureBoxWater.TabIndex = 63;
            this.pictureBoxWater.TabStop = false;
            // 
            // lblSamplerTank
            // 
            this.lblSamplerTank.AutoSize = true;
            this.lblSamplerTank.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamplerTank.ForeColor = System.Drawing.Color.Maroon;
            this.lblSamplerTank.Location = new System.Drawing.Point(20, 14);
            this.lblSamplerTank.Name = "lblSamplerTank";
            this.lblSamplerTank.Size = new System.Drawing.Size(125, 22);
            this.lblSamplerTank.TabIndex = 62;
            this.lblSamplerTank.Text = "Sampler Tank";
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.Transparent;
            this.panel26.BackgroundImage = global::DataLogger.Properties.Resources.Filter_system;
            this.panel26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel26.Controls.Add(this.panel27);
            this.panel26.Controls.Add(this.panel28);
            this.panel26.Location = new System.Drawing.Point(18, 311);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(179, 99);
            this.panel26.TabIndex = 63;
            // 
            // panel27
            // 
            this.panel27.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel27.BackColor = System.Drawing.Color.Transparent;
            this.panel27.Controls.Add(this.picFilteringSystemCleaning);
            this.panel27.Location = new System.Drawing.Point(107, 3);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(68, 93);
            this.panel27.TabIndex = 6;
            // 
            // picFilteringSystemCleaning
            // 
            this.picFilteringSystemCleaning.Image = global::DataLogger.Properties.Resources.Stop_42x42;
            this.picFilteringSystemCleaning.Location = new System.Drawing.Point(11, 34);
            this.picFilteringSystemCleaning.Name = "picFilteringSystemCleaning";
            this.picFilteringSystemCleaning.Size = new System.Drawing.Size(48, 48);
            this.picFilteringSystemCleaning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilteringSystemCleaning.TabIndex = 30;
            this.picFilteringSystemCleaning.TabStop = false;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.Transparent;
            this.panel28.Controls.Add(this.lblCleaning);
            this.panel28.Location = new System.Drawing.Point(3, 7);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(108, 89);
            this.panel28.TabIndex = 33;
            // 
            // lblCleaning
            // 
            this.lblCleaning.AutoSize = true;
            this.lblCleaning.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleaning.Location = new System.Drawing.Point(15, 42);
            this.lblCleaning.Name = "lblCleaning";
            this.lblCleaning.Size = new System.Drawing.Size(80, 19);
            this.lblCleaning.TabIndex = 0;
            this.lblCleaning.Text = "Cleaning";
            this.lblCleaning.Click += new System.EventHandler(this.lblCleaning_Click);
            // 
            // lblDrainValve
            // 
            this.lblDrainValve.AutoSize = true;
            this.lblDrainValve.BackColor = System.Drawing.Color.Transparent;
            this.lblDrainValve.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrainValve.ForeColor = System.Drawing.Color.Maroon;
            this.lblDrainValve.Location = new System.Drawing.Point(506, 366);
            this.lblDrainValve.Name = "lblDrainValve";
            this.lblDrainValve.Size = new System.Drawing.Size(106, 22);
            this.lblDrainValve.TabIndex = 61;
            this.lblDrainValve.Text = "Drain Valve";
            this.lblDrainValve.Click += new System.EventHandler(this.lblDrainValve_Click);
            // 
            // picDrainValue
            // 
            this.picDrainValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.picDrainValue.BackgroundImage = global::DataLogger.Properties.Resources.Valve_Close;
            this.picDrainValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDrainValue.Location = new System.Drawing.Point(615, 354);
            this.picDrainValue.Name = "picDrainValue";
            this.picDrainValue.Size = new System.Drawing.Size(30, 63);
            this.picDrainValue.TabIndex = 60;
            this.picDrainValue.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::DataLogger.Properties.Resources.footer;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 668);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(761, 46);
            this.flowLayoutPanel1.TabIndex = 62;
            // 
            // pnLeftSide
            // 
            this.pnLeftSide.AutoSize = true;
            this.pnLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.pnLeftSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLeftSide.Controls.Add(this.vprgMonthlyReport);
            this.pnLeftSide.Controls.Add(this.btnMaintenance);
            this.pnLeftSide.Controls.Add(this.btnMonthlyReport);
            this.pnLeftSide.Controls.Add(this.btnSetting);
            this.pnLeftSide.Controls.Add(this.btnUsers);
            this.pnLeftSide.Controls.Add(this.btnAllHistory);
            this.pnLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeftSide.Location = new System.Drawing.Point(0, 47);
            this.pnLeftSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnLeftSide.Name = "pnLeftSide";
            this.tableLayoutPanel1.SetRowSpan(this.pnLeftSide, 3);
            this.pnLeftSide.Size = new System.Drawing.Size(70, 677);
            this.pnLeftSide.TabIndex = 1;
            // 
            // vprgMonthlyReport
            // 
            this.vprgMonthlyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.vprgMonthlyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vprgMonthlyReport.BorderStyle = VerticalProgressBar.BorderStyles.None;
            this.vprgMonthlyReport.Color = System.Drawing.Color.Maroon;
            this.vprgMonthlyReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.vprgMonthlyReport.Location = new System.Drawing.Point(0, 70);
            this.vprgMonthlyReport.Maximum = 100;
            this.vprgMonthlyReport.Minimum = 0;
            this.vprgMonthlyReport.Name = "vprgMonthlyReport";
            this.vprgMonthlyReport.Size = new System.Drawing.Size(70, 218);
            this.vprgMonthlyReport.Step = 1;
            this.vprgMonthlyReport.Style = VerticalProgressBar.Styles.Solid;
            this.vprgMonthlyReport.TabIndex = 67;
            this.vprgMonthlyReport.Value = 90;
            this.vprgMonthlyReport.Visible = false;
            this.vprgMonthlyReport.Load += new System.EventHandler(this.vprgMonthlyReport_Load);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.btnMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Image = global::DataLogger.Properties.Resources.world_clock;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 421);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(70, 64);
            this.btnMaintenance.TabIndex = 50;
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnMonthlyReport.BackgroundImage = global::DataLogger.Properties.Resources.MonthlyReportButton;
            this.btnMonthlyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonthlyReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonthlyReport.FlatAppearance.BorderSize = 0;
            this.btnMonthlyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyReport.Location = new System.Drawing.Point(0, 0);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(70, 70);
            this.btnMonthlyReport.TabIndex = 49;
            this.btnMonthlyReport.UseVisualStyleBackColor = false;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSetting.Image = global::DataLogger.Properties.Resources.applications_system_60x60;
            this.btnSetting.Location = new System.Drawing.Point(0, 485);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(70, 64);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Image = global::DataLogger.Properties.Resources.user;
            this.btnUsers.Location = new System.Drawing.Point(0, 549);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(70, 64);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAllHistory
            // 
            this.btnAllHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.btnAllHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAllHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.btnAllHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllHistory.Image = global::DataLogger.Properties.Resources.maintenance;
            this.btnAllHistory.Location = new System.Drawing.Point(0, 613);
            this.btnAllHistory.Name = "btnAllHistory";
            this.btnAllHistory.Size = new System.Drawing.Size(70, 64);
            this.btnAllHistory.TabIndex = 3;
            this.btnAllHistory.UseVisualStyleBackColor = false;
            this.btnAllHistory.Click += new System.EventHandler(this.btnAllHistory_Click);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.panel16);
            this.panel21.Controls.Add(this.panel29);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(854, 494);
            this.panel21.Name = "panel21";
            this.tableLayoutPanel1.SetRowSpan(this.panel21, 2);
            this.panel21.Size = new System.Drawing.Size(490, 227);
            this.panel21.TabIndex = 71;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.panel16.Controls.Add(this.lblControlPanel);
            this.panel16.Location = new System.Drawing.Point(5, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(135, 37);
            this.panel16.TabIndex = 67;
            // 
            // lblControlPanel
            // 
            this.lblControlPanel.AutoSize = true;
            this.lblControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.lblControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblControlPanel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlPanel.ForeColor = System.Drawing.Color.White;
            this.lblControlPanel.Location = new System.Drawing.Point(0, 0);
            this.lblControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.lblControlPanel.Name = "lblControlPanel";
            this.lblControlPanel.Padding = new System.Windows.Forms.Padding(5);
            this.lblControlPanel.Size = new System.Drawing.Size(134, 32);
            this.lblControlPanel.TabIndex = 44;
            this.lblControlPanel.Text = "Control Panel";
            this.lblControlPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.Transparent;
            this.panel29.BackgroundImage = global::DataLogger.Properties.Resources.Control;
            this.panel29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel29.Controls.Add(this.panel2);
            this.panel29.Controls.Add(this.panel4);
            this.panel29.Location = new System.Drawing.Point(3, 15);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(460, 209);
            this.panel29.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.picDO4Status);
            this.panel2.Controls.Add(this.picDO3Status);
            this.panel2.Controls.Add(this.picDO2Status);
            this.panel2.Controls.Add(this.picDO1Status);
            this.panel2.Controls.Add(this.btnDO4);
            this.panel2.Controls.Add(this.btnDO3);
            this.panel2.Controls.Add(this.btnDO2);
            this.panel2.Controls.Add(this.btnDO1);
            this.panel2.Controls.Add(this.lblDO4);
            this.panel2.Controls.Add(this.lblDO3);
            this.panel2.Controls.Add(this.lblDO2);
            this.panel2.Controls.Add(this.lblDO1);
            this.panel2.Location = new System.Drawing.Point(3, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 197);
            this.panel2.TabIndex = 42;
            // 
            // picDO4Status
            // 
            this.picDO4Status.Image = ((System.Drawing.Image)(resources.GetObject("picDO4Status.Image")));
            this.picDO4Status.Location = new System.Drawing.Point(190, 157);
            this.picDO4Status.Name = "picDO4Status";
            this.picDO4Status.Size = new System.Drawing.Size(30, 30);
            this.picDO4Status.TabIndex = 51;
            this.picDO4Status.TabStop = false;
            // 
            // picDO3Status
            // 
            this.picDO3Status.Image = ((System.Drawing.Image)(resources.GetObject("picDO3Status.Image")));
            this.picDO3Status.Location = new System.Drawing.Point(190, 112);
            this.picDO3Status.Name = "picDO3Status";
            this.picDO3Status.Size = new System.Drawing.Size(30, 30);
            this.picDO3Status.TabIndex = 50;
            this.picDO3Status.TabStop = false;
            // 
            // picDO2Status
            // 
            this.picDO2Status.Image = ((System.Drawing.Image)(resources.GetObject("picDO2Status.Image")));
            this.picDO2Status.Location = new System.Drawing.Point(190, 69);
            this.picDO2Status.Name = "picDO2Status";
            this.picDO2Status.Size = new System.Drawing.Size(30, 30);
            this.picDO2Status.TabIndex = 49;
            this.picDO2Status.TabStop = false;
            this.picDO2Status.Click += new System.EventHandler(this.picDO2Status_Click);
            // 
            // picDO1Status
            // 
            this.picDO1Status.Image = global::DataLogger.Properties.Resources.Run_2_28x28;
            this.picDO1Status.Location = new System.Drawing.Point(190, 25);
            this.picDO1Status.Name = "picDO1Status";
            this.picDO1Status.Size = new System.Drawing.Size(30, 30);
            this.picDO1Status.TabIndex = 31;
            this.picDO1Status.TabStop = false;
            // 
            // btnDO4
            // 
            this.btnDO4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDO4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDO4.Image = global::DataLogger.Properties.Resources.OFF_switch_96x25;
            this.btnDO4.Location = new System.Drawing.Point(82, 152);
            this.btnDO4.Name = "btnDO4";
            this.btnDO4.Size = new System.Drawing.Size(90, 39);
            this.btnDO4.TabIndex = 48;
            this.btnDO4.UseVisualStyleBackColor = true;
            this.btnDO4.Click += new System.EventHandler(this.btnDO4_Click);
            // 
            // btnDO3
            // 
            this.btnDO3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDO3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDO3.Image = global::DataLogger.Properties.Resources.OFF_switch_96x25;
            this.btnDO3.Location = new System.Drawing.Point(83, 108);
            this.btnDO3.Name = "btnDO3";
            this.btnDO3.Size = new System.Drawing.Size(90, 39);
            this.btnDO3.TabIndex = 47;
            this.btnDO3.UseVisualStyleBackColor = true;
            this.btnDO3.Click += new System.EventHandler(this.btnDO3_Click);
            // 
            // btnDO2
            // 
            this.btnDO2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDO2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDO2.Image = global::DataLogger.Properties.Resources.OFF_switch_96x25;
            this.btnDO2.Location = new System.Drawing.Point(83, 64);
            this.btnDO2.Name = "btnDO2";
            this.btnDO2.Size = new System.Drawing.Size(90, 39);
            this.btnDO2.TabIndex = 46;
            this.btnDO2.UseVisualStyleBackColor = true;
            this.btnDO2.Click += new System.EventHandler(this.btnDO2_Click);
            // 
            // btnDO1
            // 
            this.btnDO1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDO1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDO1.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDO1.Image = global::DataLogger.Properties.Resources.ON_switch_96x25;
            this.btnDO1.Location = new System.Drawing.Point(83, 19);
            this.btnDO1.Name = "btnDO1";
            this.btnDO1.Size = new System.Drawing.Size(90, 39);
            this.btnDO1.TabIndex = 6;
            this.btnDO1.UseVisualStyleBackColor = true;
            this.btnDO1.Click += new System.EventHandler(this.btnDO1_Click);
            // 
            // lblDO4
            // 
            this.lblDO4.AutoSize = true;
            this.lblDO4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDO4.Location = new System.Drawing.Point(16, 166);
            this.lblDO4.Name = "lblDO4";
            this.lblDO4.Size = new System.Drawing.Size(47, 15);
            this.lblDO4.TabIndex = 45;
            this.lblDO4.Text = "D/O #4";
            // 
            // lblDO3
            // 
            this.lblDO3.AutoSize = true;
            this.lblDO3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDO3.Location = new System.Drawing.Point(16, 121);
            this.lblDO3.Name = "lblDO3";
            this.lblDO3.Size = new System.Drawing.Size(47, 15);
            this.lblDO3.TabIndex = 44;
            this.lblDO3.Text = "D/O #3";
            // 
            // lblDO2
            // 
            this.lblDO2.AutoSize = true;
            this.lblDO2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDO2.Location = new System.Drawing.Point(17, 77);
            this.lblDO2.Name = "lblDO2";
            this.lblDO2.Size = new System.Drawing.Size(47, 15);
            this.lblDO2.TabIndex = 43;
            this.lblDO2.Text = "D/O #2";
            this.lblDO2.Click += new System.EventHandler(this.lblDO2_Click);
            // 
            // lblDO1
            // 
            this.lblDO1.AutoSize = true;
            this.lblDO1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDO1.Location = new System.Drawing.Point(17, 32);
            this.lblDO1.Name = "lblDO1";
            this.lblDO1.Size = new System.Drawing.Size(47, 15);
            this.lblDO1.TabIndex = 42;
            this.lblDO1.Text = "D/O #1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.picDO8Status);
            this.panel4.Controls.Add(this.btnDO8);
            this.panel4.Controls.Add(this.picDO7Status);
            this.panel4.Controls.Add(this.btnDO5);
            this.panel4.Controls.Add(this.picDO6Status);
            this.panel4.Controls.Add(this.btnDO7);
            this.panel4.Controls.Add(this.picDO5Status);
            this.panel4.Controls.Add(this.lblDO5);
            this.panel4.Controls.Add(this.btnDO6);
            this.panel4.Controls.Add(this.lblDO6);
            this.panel4.Controls.Add(this.lblDO7);
            this.panel4.Controls.Add(this.lblDO8);
            this.panel4.Location = new System.Drawing.Point(237, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 198);
            this.panel4.TabIndex = 43;
            // 
            // picDO8Status
            // 
            this.picDO8Status.Image = ((System.Drawing.Image)(resources.GetObject("picDO8Status.Image")));
            this.picDO8Status.Location = new System.Drawing.Point(185, 157);
            this.picDO8Status.Name = "picDO8Status";
            this.picDO8Status.Size = new System.Drawing.Size(30, 30);
            this.picDO8Status.TabIndex = 55;
            this.picDO8Status.TabStop = false;
            // 
            // btnDO8
            // 
            this.btnDO8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDO8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDO8.Image = global::DataLogger.Properties.Resources.OFF_switch_96x25;
            this.btnDO8.Location = new System.Drawing.Point(73, 154);
            this.btnDO8.Name = "btnDO8";
            this.btnDO8.Size = new System.Drawing.Size(90, 39);
            this.btnDO8.TabIndex = 56;
            this.btnDO8.UseVisualStyleBackColor = true;
            this.btnDO8.Click += new System.EventHandler(this.btnDO8_Click);
            // 
            // picDO7Status
            // 
            this.picDO7Status.Image = global::DataLogger.Properties.Resources.Run_2_28x28;
            this.picDO7Status.Location = new System.Drawing.Point(185, 113);
            this.picDO7Status.Name = "picDO7Status";
            this.picDO7Status.Size = new System.Drawing.Size(30, 30);
            this.picDO7Status.TabIndex = 54;
            this.picDO7Status.TabStop = false;
            // 
            // btnDO5
            // 
            this.btnDO5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDO5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDO5.Image = global::DataLogger.Properties.Resources.OFF_switch_96x25;
            this.btnDO5.Location = new System.Drawing.Point(73, 19);
            this.btnDO5.Name = "btnDO5";
            this.btnDO5.Size = new System.Drawing.Size(90, 39);
            this.btnDO5.TabIndex = 49;
            this.btnDO5.UseVisualStyleBackColor = true;
            this.btnDO5.Click += new System.EventHandler(this.btnDO5_Click);
            // 
            // picDO6Status
            // 
            this.picDO6Status.Image = ((System.Drawing.Image)(resources.GetObject("picDO6Status.Image")));
            this.picDO6Status.Location = new System.Drawing.Point(185, 69);
            this.picDO6Status.Name = "picDO6Status";
            this.picDO6Status.Size = new System.Drawing.Size(30, 30);
            this.picDO6Status.TabIndex = 53;
            this.picDO6Status.TabStop = false;
            // 
            // btnDO7
            // 
            this.btnDO7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDO7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDO7.Image = global::DataLogger.Properties.Resources.OFF_switch_96x25;
            this.btnDO7.Location = new System.Drawing.Point(73, 109);
            this.btnDO7.Name = "btnDO7";
            this.btnDO7.Size = new System.Drawing.Size(90, 39);
            this.btnDO7.TabIndex = 55;
            this.btnDO7.UseVisualStyleBackColor = true;
            this.btnDO7.Click += new System.EventHandler(this.btnDO7_Click);
            // 
            // picDO5Status
            // 
            this.picDO5Status.Image = global::DataLogger.Properties.Resources.Run_2_28x28;
            this.picDO5Status.Location = new System.Drawing.Point(185, 23);
            this.picDO5Status.Name = "picDO5Status";
            this.picDO5Status.Size = new System.Drawing.Size(30, 30);
            this.picDO5Status.TabIndex = 52;
            this.picDO5Status.TabStop = false;
            // 
            // lblDO5
            // 
            this.lblDO5.AutoSize = true;
            this.lblDO5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDO5.Location = new System.Drawing.Point(18, 32);
            this.lblDO5.Name = "lblDO5";
            this.lblDO5.Size = new System.Drawing.Size(47, 15);
            this.lblDO5.TabIndex = 50;
            this.lblDO5.Text = "D/O #5";
            // 
            // btnDO6
            // 
            this.btnDO6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDO6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDO6.Image = global::DataLogger.Properties.Resources.OFF_switch_96x25;
            this.btnDO6.Location = new System.Drawing.Point(73, 64);
            this.btnDO6.Name = "btnDO6";
            this.btnDO6.Size = new System.Drawing.Size(90, 39);
            this.btnDO6.TabIndex = 54;
            this.btnDO6.UseVisualStyleBackColor = true;
            this.btnDO6.Click += new System.EventHandler(this.btnDO6_Click);
            // 
            // lblDO6
            // 
            this.lblDO6.AutoSize = true;
            this.lblDO6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDO6.Location = new System.Drawing.Point(18, 77);
            this.lblDO6.Name = "lblDO6";
            this.lblDO6.Size = new System.Drawing.Size(47, 15);
            this.lblDO6.TabIndex = 51;
            this.lblDO6.Text = "D/O #6";
            // 
            // lblDO7
            // 
            this.lblDO7.AutoSize = true;
            this.lblDO7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDO7.Location = new System.Drawing.Point(18, 122);
            this.lblDO7.Name = "lblDO7";
            this.lblDO7.Size = new System.Drawing.Size(47, 15);
            this.lblDO7.TabIndex = 52;
            this.lblDO7.Text = "D/O #7";
            // 
            // lblDO8
            // 
            this.lblDO8.AutoSize = true;
            this.lblDO8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDO8.Location = new System.Drawing.Point(18, 166);
            this.lblDO8.Name = "lblDO8";
            this.lblDO8.Size = new System.Drawing.Size(47, 15);
            this.lblDO8.TabIndex = 53;
            this.lblDO8.Text = "D/O #8";
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pnHeader, 3);
            this.pnHeader.Controls.Add(this.label9);
            this.pnHeader.Controls.Add(this.label4);
            this.pnHeader.Controls.Add(this.label3);
            this.pnHeader.Controls.Add(this.panel18);
            this.pnHeader.Controls.Add(this.lblHeadingTime);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1347, 47);
            this.pnHeader.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(45, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 31);
            this.label9.TabIndex = 70;
            this.label9.Text = "STATION";
            // 
            // label4
            // 
            this.label4.Image = global::DataLogger.Properties.Resources.clock;
            this.label4.Location = new System.Drawing.Point(976, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 37);
            this.label4.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.Image = global::DataLogger.Properties.Resources.logo;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 37);
            this.label3.TabIndex = 68;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.panel18.Controls.Add(this.btnLoginLogout);
            this.panel18.Controls.Add(this.lblLoginDisplayName);
            this.panel18.Location = new System.Drawing.Point(1174, 1);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(173, 48);
            this.panel18.TabIndex = 65;
            // 
            // btnLoginLogout
            // 
            this.btnLoginLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginLogout.BackgroundImage = global::DataLogger.Properties.Resources.login;
            this.btnLoginLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(196)))));
            this.btnLoginLogout.FlatAppearance.BorderSize = 0;
            this.btnLoginLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginLogout.Location = new System.Drawing.Point(133, 5);
            this.btnLoginLogout.Name = "btnLoginLogout";
            this.btnLoginLogout.Size = new System.Drawing.Size(37, 37);
            this.btnLoginLogout.TabIndex = 64;
            this.btnLoginLogout.UseVisualStyleBackColor = false;
            this.btnLoginLogout.Click += new System.EventHandler(this.btnLoginLogout_Click);
            // 
            // lblLoginDisplayName
            // 
            this.lblLoginDisplayName.AutoSize = true;
            this.lblLoginDisplayName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginDisplayName.ForeColor = System.Drawing.Color.White;
            this.lblLoginDisplayName.Location = new System.Drawing.Point(8, 15);
            this.lblLoginDisplayName.Name = "lblLoginDisplayName";
            this.lblLoginDisplayName.Size = new System.Drawing.Size(120, 17);
            this.lblLoginDisplayName.TabIndex = 51;
            this.lblLoginDisplayName.Text = "Welcome, Guest!";
            // 
            // lblHeadingTime
            // 
            this.lblHeadingTime.AutoSize = true;
            this.lblHeadingTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTime.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTime.Location = new System.Drawing.Point(1019, 15);
            this.lblHeadingTime.Name = "lblHeadingTime";
            this.lblHeadingTime.Size = new System.Drawing.Size(143, 17);
            this.lblHeadingTime.TabIndex = 2;
            this.lblHeadingTime.Text = "25-09-2015 12:11:19";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.panel12);
            this.panel24.Controls.Add(this.panel8);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(854, 50);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(490, 438);
            this.panel24.TabIndex = 72;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(170)))));
            this.panel12.Controls.Add(this.label1);
            this.panel12.Location = new System.Drawing.Point(8, 8);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(126, 37);
            this.panel12.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analyzer";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = global::DataLogger.Properties.Resources.Aplyzer;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(6, 24);
            this.panel8.Margin = new System.Windows.Forms.Padding(10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(456, 405);
            this.panel8.TabIndex = 0;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.vprgTNValue);
            this.panel11.Controls.Add(this.btnTN1Hour);
            this.panel11.Controls.Add(this.btnTN5Minute);
            this.panel11.Controls.Add(this.btnTNHistoryData);
            this.panel11.Controls.Add(this.txtTNValue);
            this.panel11.Controls.Add(this.label52);
            this.panel11.Controls.Add(this.btnTNCalibrate);
            this.panel11.Controls.Add(this.picTNStatus);
            this.panel11.Controls.Add(this.label53);
            this.panel11.Location = new System.Drawing.Point(12, 280);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(436, 110);
            this.panel11.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(98)))));
            this.label8.Location = new System.Drawing.Point(52, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 68;
            this.label8.Text = "MONI-TN";
            // 
            // vprgTNValue
            // 
            this.vprgTNValue.BackColor = System.Drawing.Color.White;
            this.vprgTNValue.BorderStyle = VerticalProgressBar.BorderStyles.None;
            this.vprgTNValue.Color = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.vprgTNValue.Location = new System.Drawing.Point(12, 1);
            this.vprgTNValue.Maximum = 100;
            this.vprgTNValue.Minimum = 0;
            this.vprgTNValue.Name = "vprgTNValue";
            this.vprgTNValue.Size = new System.Drawing.Size(20, 95);
            this.vprgTNValue.Step = 1;
            this.vprgTNValue.Style = VerticalProgressBar.Styles.Solid;
            this.vprgTNValue.TabIndex = 67;
            this.vprgTNValue.Value = 90;
            // 
            // btnTN1Hour
            // 
            this.btnTN1Hour.BackColor = System.Drawing.Color.Transparent;
            this.btnTN1Hour.BackgroundImage = global::DataLogger.Properties.Resources._11;
            this.btnTN1Hour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTN1Hour.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTN1Hour.FlatAppearance.BorderSize = 0;
            this.btnTN1Hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTN1Hour.Location = new System.Drawing.Point(375, 11);
            this.btnTN1Hour.Name = "btnTN1Hour";
            this.btnTN1Hour.Size = new System.Drawing.Size(42, 42);
            this.btnTN1Hour.TabIndex = 50;
            this.btnTN1Hour.UseVisualStyleBackColor = false;
            this.btnTN1Hour.Click += new System.EventHandler(this.btnTN1Hour_Click);
            // 
            // btnTN5Minute
            // 
            this.btnTN5Minute.BackColor = System.Drawing.Color.Transparent;
            this.btnTN5Minute.BackgroundImage = global::DataLogger.Properties.Resources._10;
            this.btnTN5Minute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTN5Minute.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTN5Minute.FlatAppearance.BorderSize = 0;
            this.btnTN5Minute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTN5Minute.Location = new System.Drawing.Point(315, 11);
            this.btnTN5Minute.Name = "btnTN5Minute";
            this.btnTN5Minute.Size = new System.Drawing.Size(42, 42);
            this.btnTN5Minute.TabIndex = 50;
            this.btnTN5Minute.UseVisualStyleBackColor = false;
            this.btnTN5Minute.Click += new System.EventHandler(this.btnTN5Minute_Click);
            // 
            // btnTNHistoryData
            // 
            this.btnTNHistoryData.BackColor = System.Drawing.Color.Transparent;
            this.btnTNHistoryData.BackgroundImage = global::DataLogger.Properties.Resources._8;
            this.btnTNHistoryData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTNHistoryData.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTNHistoryData.FlatAppearance.BorderSize = 0;
            this.btnTNHistoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTNHistoryData.Location = new System.Drawing.Point(315, 59);
            this.btnTNHistoryData.Name = "btnTNHistoryData";
            this.btnTNHistoryData.Size = new System.Drawing.Size(40, 40);
            this.btnTNHistoryData.TabIndex = 50;
            this.btnTNHistoryData.UseVisualStyleBackColor = false;
            this.btnTNHistoryData.Click += new System.EventHandler(this.btnTNHistoryData_Click);
            // 
            // txtTNValue
            // 
            this.txtTNValue.BackColor = System.Drawing.Color.White;
            this.txtTNValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTNValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTNValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtTNValue.Location = new System.Drawing.Point(88, 70);
            this.txtTNValue.Name = "txtTNValue";
            this.txtTNValue.ReadOnly = true;
            this.txtTNValue.Size = new System.Drawing.Size(64, 22);
            this.txtTNValue.TabIndex = 51;
            this.txtTNValue.Text = "7.20";
            this.txtTNValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Location = new System.Drawing.Point(168, 73);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(43, 19);
            this.label52.TabIndex = 60;
            this.label52.Text = "mg/L";
            this.label52.Click += new System.EventHandler(this.label52_Click);
            // 
            // btnTNCalibrate
            // 
            this.btnTNCalibrate.BackColor = System.Drawing.Color.Transparent;
            this.btnTNCalibrate.BackgroundImage = global::DataLogger.Properties.Resources._12;
            this.btnTNCalibrate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTNCalibrate.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTNCalibrate.FlatAppearance.BorderSize = 0;
            this.btnTNCalibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTNCalibrate.Location = new System.Drawing.Point(375, 59);
            this.btnTNCalibrate.Name = "btnTNCalibrate";
            this.btnTNCalibrate.Size = new System.Drawing.Size(40, 40);
            this.btnTNCalibrate.TabIndex = 50;
            this.btnTNCalibrate.UseVisualStyleBackColor = false;
            this.btnTNCalibrate.Click += new System.EventHandler(this.btnTNCalibrate_Click);
            // 
            // picTNStatus
            // 
            this.picTNStatus.BackColor = System.Drawing.Color.Transparent;
            this.picTNStatus.BackgroundImage = global::DataLogger.Properties.Resources.Normal_status;
            this.picTNStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTNStatus.Location = new System.Drawing.Point(225, 38);
            this.picTNStatus.Name = "picTNStatus";
            this.picTNStatus.Size = new System.Drawing.Size(42, 42);
            this.picTNStatus.TabIndex = 59;
            this.picTNStatus.TabStop = false;
            this.picTNStatus.MouseHover += new System.EventHandler(this.picTNStatus_MouseHover);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.Black;
            this.label53.Location = new System.Drawing.Point(58, 73);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(29, 17);
            this.label53.TabIndex = 45;
            this.label53.Text = "TN";
            this.label53.Click += new System.EventHandler(this.label53_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.vprgTPValue);
            this.panel10.Controls.Add(this.label49);
            this.panel10.Controls.Add(this.btnTP5Minute);
            this.panel10.Controls.Add(this.btnTPCalibrate);
            this.panel10.Controls.Add(this.btnTP1Hour);
            this.panel10.Controls.Add(this.picTPStatus);
            this.panel10.Controls.Add(this.txtTPValue);
            this.panel10.Controls.Add(this.btnTPHistoryData);
            this.panel10.Controls.Add(this.label47);
            this.panel10.Location = new System.Drawing.Point(12, 162);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(436, 110);
            this.panel10.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(98)))));
            this.label7.Location = new System.Drawing.Point(52, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 65;
            this.label7.Text = "MONI-TP";
            // 
            // vprgTPValue
            // 
            this.vprgTPValue.BackColor = System.Drawing.Color.White;
            this.vprgTPValue.BorderStyle = VerticalProgressBar.BorderStyles.None;
            this.vprgTPValue.Color = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.vprgTPValue.Location = new System.Drawing.Point(12, 3);
            this.vprgTPValue.Maximum = 100;
            this.vprgTPValue.Minimum = 0;
            this.vprgTPValue.Name = "vprgTPValue";
            this.vprgTPValue.Size = new System.Drawing.Size(20, 96);
            this.vprgTPValue.Step = 1;
            this.vprgTPValue.Style = VerticalProgressBar.Styles.Solid;
            this.vprgTPValue.TabIndex = 64;
            this.vprgTPValue.Value = 10;
            this.vprgTPValue.Load += new System.EventHandler(this.vprgTPValue_Load);
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(58, 67);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(43, 15);
            this.label49.TabIndex = 45;
            this.label49.Text = "TP";
            this.label49.Click += new System.EventHandler(this.label49_Click);
            // 
            // btnTP5Minute
            // 
            this.btnTP5Minute.BackColor = System.Drawing.Color.Transparent;
            this.btnTP5Minute.BackgroundImage = global::DataLogger.Properties.Resources._10;
            this.btnTP5Minute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTP5Minute.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTP5Minute.FlatAppearance.BorderSize = 0;
            this.btnTP5Minute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTP5Minute.Location = new System.Drawing.Point(315, 9);
            this.btnTP5Minute.Name = "btnTP5Minute";
            this.btnTP5Minute.Size = new System.Drawing.Size(42, 42);
            this.btnTP5Minute.TabIndex = 50;
            this.btnTP5Minute.UseVisualStyleBackColor = false;
            this.btnTP5Minute.Click += new System.EventHandler(this.btnTP5Minute_Click);
            // 
            // btnTPCalibrate
            // 
            this.btnTPCalibrate.BackColor = System.Drawing.Color.Transparent;
            this.btnTPCalibrate.BackgroundImage = global::DataLogger.Properties.Resources._12;
            this.btnTPCalibrate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTPCalibrate.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTPCalibrate.FlatAppearance.BorderSize = 0;
            this.btnTPCalibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTPCalibrate.Location = new System.Drawing.Point(375, 61);
            this.btnTPCalibrate.Name = "btnTPCalibrate";
            this.btnTPCalibrate.Size = new System.Drawing.Size(40, 40);
            this.btnTPCalibrate.TabIndex = 50;
            this.btnTPCalibrate.UseVisualStyleBackColor = false;
            this.btnTPCalibrate.Click += new System.EventHandler(this.btnTPCalibrate_Click);
            // 
            // btnTP1Hour
            // 
            this.btnTP1Hour.BackColor = System.Drawing.Color.Transparent;
            this.btnTP1Hour.BackgroundImage = global::DataLogger.Properties.Resources._11;
            this.btnTP1Hour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTP1Hour.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTP1Hour.FlatAppearance.BorderSize = 0;
            this.btnTP1Hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTP1Hour.Location = new System.Drawing.Point(375, 9);
            this.btnTP1Hour.Name = "btnTP1Hour";
            this.btnTP1Hour.Size = new System.Drawing.Size(42, 42);
            this.btnTP1Hour.TabIndex = 50;
            this.btnTP1Hour.UseVisualStyleBackColor = false;
            this.btnTP1Hour.Click += new System.EventHandler(this.btnTP1Hour_Click);
            // 
            // picTPStatus
            // 
            this.picTPStatus.BackColor = System.Drawing.Color.Transparent;
            this.picTPStatus.BackgroundImage = global::DataLogger.Properties.Resources.Normal_status;
            this.picTPStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTPStatus.Location = new System.Drawing.Point(224, 33);
            this.picTPStatus.Name = "picTPStatus";
            this.picTPStatus.Size = new System.Drawing.Size(42, 42);
            this.picTPStatus.TabIndex = 59;
            this.picTPStatus.TabStop = false;
            this.picTPStatus.Click += new System.EventHandler(this.picTPStatus_Click);
            this.picTPStatus.MouseHover += new System.EventHandler(this.picTPStatus_MouseHover);
            // 
            // txtTPValue
            // 
            this.txtTPValue.BackColor = System.Drawing.Color.White;
            this.txtTPValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTPValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtTPValue.Location = new System.Drawing.Point(95, 66);
            this.txtTPValue.Name = "txtTPValue";
            this.txtTPValue.ReadOnly = true;
            this.txtTPValue.Size = new System.Drawing.Size(57, 22);
            this.txtTPValue.TabIndex = 51;
            this.txtTPValue.Text = "7.20";
            this.txtTPValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTPValue.TextChanged += new System.EventHandler(this.txtTPValue_TextChanged);
            // 
            // btnTPHistoryData
            // 
            this.btnTPHistoryData.BackColor = System.Drawing.Color.Transparent;
            this.btnTPHistoryData.BackgroundImage = global::DataLogger.Properties.Resources._8;
            this.btnTPHistoryData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTPHistoryData.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTPHistoryData.FlatAppearance.BorderSize = 0;
            this.btnTPHistoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTPHistoryData.Location = new System.Drawing.Point(315, 61);
            this.btnTPHistoryData.Name = "btnTPHistoryData";
            this.btnTPHistoryData.Size = new System.Drawing.Size(40, 40);
            this.btnTPHistoryData.TabIndex = 50;
            this.btnTPHistoryData.UseVisualStyleBackColor = false;
            this.btnTPHistoryData.Click += new System.EventHandler(this.btnTPHistoryData_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.Black;
            this.label47.Location = new System.Drawing.Point(168, 66);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(43, 19);
            this.label47.TabIndex = 60;
            this.label47.Text = "mg/L";
            this.label47.Click += new System.EventHandler(this.label47_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.vprgTOCValue);
            this.panel7.Controls.Add(this.txtTOCValue);
            this.panel7.Controls.Add(this.label48);
            this.panel7.Controls.Add(this.picTOCStatus);
            this.panel7.Controls.Add(this.label43);
            this.panel7.Controls.Add(this.btnTOCCalibrate);
            this.panel7.Controls.Add(this.btnTOC5Minute);
            this.panel7.Controls.Add(this.btnTOCHistoryData);
            this.panel7.Controls.Add(this.btnTOC1Hour);
            this.panel7.Location = new System.Drawing.Point(12, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(436, 110);
            this.panel7.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(98)))));
            this.label5.Location = new System.Drawing.Point(52, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 62;
            this.label5.Text = "MONI-TOC";
            // 
            // vprgTOCValue
            // 
            this.vprgTOCValue.BackColor = System.Drawing.Color.White;
            this.vprgTOCValue.BorderStyle = VerticalProgressBar.BorderStyles.None;
            this.vprgTOCValue.Color = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.vprgTOCValue.Location = new System.Drawing.Point(13, 3);
            this.vprgTOCValue.Maximum = 100;
            this.vprgTOCValue.Minimum = 0;
            this.vprgTOCValue.Name = "vprgTOCValue";
            this.vprgTOCValue.Size = new System.Drawing.Size(20, 104);
            this.vprgTOCValue.Step = 1;
            this.vprgTOCValue.Style = VerticalProgressBar.Styles.Solid;
            this.vprgTOCValue.TabIndex = 61;
            this.vprgTOCValue.Value = 10;
            // 
            // txtTOCValue
            // 
            this.txtTOCValue.BackColor = System.Drawing.Color.White;
            this.txtTOCValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTOCValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOCValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(160)))), ((int)(((byte)(186)))));
            this.txtTOCValue.Location = new System.Drawing.Point(95, 68);
            this.txtTOCValue.Name = "txtTOCValue";
            this.txtTOCValue.ReadOnly = true;
            this.txtTOCValue.Size = new System.Drawing.Size(57, 22);
            this.txtTOCValue.TabIndex = 51;
            this.txtTOCValue.Text = "7.20";
            this.txtTOCValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTOCValue.TextChanged += new System.EventHandler(this.txtTOCValue_TextChanged);
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(58, 71);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(43, 15);
            this.label48.TabIndex = 45;
            this.label48.Text = "TOC";
            this.label48.Click += new System.EventHandler(this.label48_Click);
            // 
            // picTOCStatus
            // 
            this.picTOCStatus.BackColor = System.Drawing.Color.Transparent;
            this.picTOCStatus.BackgroundImage = global::DataLogger.Properties.Resources.Normal_status;
            this.picTOCStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTOCStatus.Location = new System.Drawing.Point(225, 35);
            this.picTOCStatus.Name = "picTOCStatus";
            this.picTOCStatus.Size = new System.Drawing.Size(42, 42);
            this.picTOCStatus.TabIndex = 59;
            this.picTOCStatus.TabStop = false;
            this.picTOCStatus.Click += new System.EventHandler(this.picTOCStatus_Click);
            this.picTOCStatus.MouseHover += new System.EventHandler(this.picTOCStatus_MouseHover);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(168, 70);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(43, 19);
            this.label43.TabIndex = 60;
            this.label43.Text = "mg/L";
            this.label43.Click += new System.EventHandler(this.label43_Click);
            // 
            // btnTOCCalibrate
            // 
            this.btnTOCCalibrate.BackColor = System.Drawing.Color.Transparent;
            this.btnTOCCalibrate.BackgroundImage = global::DataLogger.Properties.Resources._12;
            this.btnTOCCalibrate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTOCCalibrate.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTOCCalibrate.FlatAppearance.BorderSize = 0;
            this.btnTOCCalibrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTOCCalibrate.Location = new System.Drawing.Point(375, 65);
            this.btnTOCCalibrate.Name = "btnTOCCalibrate";
            this.btnTOCCalibrate.Size = new System.Drawing.Size(40, 40);
            this.btnTOCCalibrate.TabIndex = 50;
            this.btnTOCCalibrate.UseVisualStyleBackColor = false;
            this.btnTOCCalibrate.Click += new System.EventHandler(this.btnTOCCalibrate_Click);
            // 
            // btnTOC5Minute
            // 
            this.btnTOC5Minute.BackColor = System.Drawing.Color.Transparent;
            this.btnTOC5Minute.BackgroundImage = global::DataLogger.Properties.Resources._10;
            this.btnTOC5Minute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTOC5Minute.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTOC5Minute.FlatAppearance.BorderSize = 0;
            this.btnTOC5Minute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTOC5Minute.Location = new System.Drawing.Point(315, 6);
            this.btnTOC5Minute.Name = "btnTOC5Minute";
            this.btnTOC5Minute.Size = new System.Drawing.Size(42, 42);
            this.btnTOC5Minute.TabIndex = 50;
            this.btnTOC5Minute.UseVisualStyleBackColor = false;
            this.btnTOC5Minute.Click += new System.EventHandler(this.btnTOC5Minute_Click);
            // 
            // btnTOCHistoryData
            // 
            this.btnTOCHistoryData.BackColor = System.Drawing.Color.Transparent;
            this.btnTOCHistoryData.BackgroundImage = global::DataLogger.Properties.Resources._8;
            this.btnTOCHistoryData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTOCHistoryData.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTOCHistoryData.FlatAppearance.BorderSize = 0;
            this.btnTOCHistoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTOCHistoryData.Location = new System.Drawing.Point(315, 65);
            this.btnTOCHistoryData.Name = "btnTOCHistoryData";
            this.btnTOCHistoryData.Size = new System.Drawing.Size(40, 40);
            this.btnTOCHistoryData.TabIndex = 50;
            this.btnTOCHistoryData.UseVisualStyleBackColor = false;
            this.btnTOCHistoryData.Click += new System.EventHandler(this.btnTOCHistoryData_Click);
            // 
            // btnTOC1Hour
            // 
            this.btnTOC1Hour.BackColor = System.Drawing.Color.Transparent;
            this.btnTOC1Hour.BackgroundImage = global::DataLogger.Properties.Resources._11;
            this.btnTOC1Hour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTOC1Hour.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTOC1Hour.FlatAppearance.BorderSize = 0;
            this.btnTOC1Hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTOC1Hour.Location = new System.Drawing.Point(375, 7);
            this.btnTOC1Hour.Name = "btnTOC1Hour";
            this.btnTOC1Hour.Size = new System.Drawing.Size(42, 42);
            this.btnTOC1Hour.TabIndex = 50;
            this.btnTOC1Hour.UseVisualStyleBackColor = false;
            this.btnTOC1Hour.Click += new System.EventHandler(this.btnTOC1Hour_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.26636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.73364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 495F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.26636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.73364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 482F));
            this.tableLayoutPanel1.Controls.Add(this.panel24, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel23, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel21, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnLeftSide, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel30, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.619239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.38076F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.619239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.38076F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1347, 724);
            this.tableLayoutPanel1.TabIndex = 69;
            // 
            // frmNewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1354, 727);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewMain";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewMain_FormClosing);
            this.Load += new System.EventHandler(this.frmNewMain_Load);
            this.panel23.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.pnStationStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusAir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusAir1)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.pnSoftwareInfo.ResumeLayout(false);
            this.pnSoftwareInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSamplerTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusFireDetector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusMainDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusUPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStationStatusMainPower)).EndInit();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAutoSamplerStatus)).EndInit();
            this.pnbottlePosition.ResumeLayout(false);
            this.pnbottlePosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPumpingSystemRRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPumpingSystemRFLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump2_RunningType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPumpingSystemLRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPumpingSystemLFLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump1_RunningType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPump1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPSStatus)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWater)).EndInit();
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFilteringSystemCleaning)).EndInit();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrainValue)).EndInit();
            this.pnLeftSide.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDO4Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO3Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO2Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO1Status)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDO8Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO7Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO6Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDO5Status)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTNStatus)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTPStatus)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTOCStatus)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.IO.Ports.SerialPort serialPortTN;
        public System.IO.Ports.SerialPort serialPortTP;
        public System.IO.Ports.SerialPort serialPortTOC;
        public System.IO.Ports.SerialPort serialPortADAM;
        public System.ComponentModel.BackgroundWorker bgwMonthlyReport;
        public System.IO.Ports.SerialPort serialPortSAMP;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMain;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel25;
        public System.Windows.Forms.Label lblStationStatus;
        public System.Windows.Forms.Panel pnStationStatus;
        public System.Windows.Forms.PictureBox picStationStatusAir2;
        public System.Windows.Forms.PictureBox picStationStatusAir1;
        private System.Windows.Forms.Panel panel20;
        public System.Windows.Forms.Label lblMainMenuTitle;
        public System.Windows.Forms.Panel pnSoftwareInfo;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblSurfaceWaterQuality;
        public System.Windows.Forms.Label lblAutomaticMonitoring;
        public System.Windows.Forms.Label lblThaiNguyenStation;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox52;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblWaterLevel;
        public System.Windows.Forms.Label lblHeaderNationName;
        public System.Windows.Forms.RichTextBox txtData;
        public System.Windows.Forms.PictureBox picSamplerTank;
        public System.Windows.Forms.Button btnLanguage;
        public System.Windows.Forms.PictureBox pictureBox5;
        public FlatButton listen;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.PictureBox picStationStatusFireDetector;
        public System.Windows.Forms.PictureBox picStationStatusMainDoor;
        public System.Windows.Forms.PictureBox picStationStatusUPS;
        public System.Windows.Forms.PictureBox picStationStatusMainPower;
        public System.Windows.Forms.Label lblair1;
        public System.Windows.Forms.Label lblFireDetector;
        public System.Windows.Forms.Label lblMainDoor;
        public System.Windows.Forms.Label lblair2;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label lblMainPower;
        public System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel15;
        public System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.Label lblFilteringSystem;
        public System.Windows.Forms.Panel panel13;
        public System.Windows.Forms.Label lblPumpingSystem;
        public System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label lblAutorSampler;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnAutoSamplerTesting;
        public System.Windows.Forms.Button btnAutoSamplerHistoryData;
        public System.Windows.Forms.PictureBox picAutoSamplerStatus;
        public System.Windows.Forms.Panel pnbottlePosition;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox txtAutoSamplerTemp;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblPumpRRS;
        public System.Windows.Forms.Label lblPumpRFLT;
        public System.Windows.Forms.Label lblPumpRAM;
        public System.Windows.Forms.Label lblPumpLAM;
        public System.Windows.Forms.Label lblPumpLRS;
        public System.Windows.Forms.Label lblPumpLFLT;
        public System.Windows.Forms.PictureBox picPumpingSystemRRS;
        public System.Windows.Forms.PictureBox picPumpingSystemRFLT;
        public System.Windows.Forms.PictureBox picPump2_RunningType;
        public System.Windows.Forms.PictureBox picPumpingSystemLRS;
        public System.Windows.Forms.PictureBox picPumpingSystemLFLT;
        public System.Windows.Forms.PictureBox picPump1_RunningType;
        public System.Windows.Forms.Label lblPump2;
        public System.Windows.Forms.PictureBox picPump2;
        public System.Windows.Forms.Label lblPump1;
        public System.Windows.Forms.PictureBox picPump1;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label64;
        public System.Windows.Forms.Label label63;
        public System.Windows.Forms.Label label62;
        public System.Windows.Forms.Button btnMPSHistoryData;
        public System.Windows.Forms.Button btnMPS1Hour;
        public System.Windows.Forms.Button btnMPS5Minute;
        public System.Windows.Forms.PictureBox picMPSStatus;
        public System.Windows.Forms.TextBox txtMPSCondValue;
        public System.Windows.Forms.TextBox txtMPSTurbValue;
        public System.Windows.Forms.TextBox txtMPSDOValue;
        public System.Windows.Forms.TextBox txtMPSTempValue;
        public System.Windows.Forms.TextBox txtMPSORPValue;
        public System.Windows.Forms.TextBox txtMPSpHValue;
        public System.Windows.Forms.Label label40;
        public System.Windows.Forms.Label label41;
        public System.Windows.Forms.Label label38;
        public System.Windows.Forms.Label label39;
        public System.Windows.Forms.Label label37;
        public System.Windows.Forms.Label label36;
        public System.Windows.Forms.Panel panel22;
        public System.Windows.Forms.PictureBox pictureBoxWater;
        public System.Windows.Forms.Label lblSamplerTank;
        public System.Windows.Forms.Panel panel26;
        public System.Windows.Forms.Panel panel27;
        public System.Windows.Forms.PictureBox picFilteringSystemCleaning;
        public System.Windows.Forms.Panel panel28;
        public System.Windows.Forms.Label lblCleaning;
        public System.Windows.Forms.Label lblDrainValve;
        public System.Windows.Forms.PictureBox picDrainValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Panel pnLeftSide;
        public VerticalProgressBar.VerticalProgressBar vprgMonthlyReport;
        public System.Windows.Forms.Button btnMaintenance;
        public System.Windows.Forms.Button btnMonthlyReport;
        public System.Windows.Forms.Button btnSetting;
        public System.Windows.Forms.Button btnUsers;
        public System.Windows.Forms.Button btnAllHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel24;
        public System.Windows.Forms.Panel panel12;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.Label label8;
        public VerticalProgressBar.VerticalProgressBar vprgTNValue;
        public System.Windows.Forms.Button btnTN1Hour;
        public System.Windows.Forms.Button btnTN5Minute;
        public System.Windows.Forms.Button btnTNHistoryData;
        public System.Windows.Forms.TextBox txtTNValue;
        public System.Windows.Forms.Label label52;
        public System.Windows.Forms.Button btnTNCalibrate;
        public System.Windows.Forms.PictureBox picTNStatus;
        public System.Windows.Forms.Label label53;
        public System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.Label label7;
        public VerticalProgressBar.VerticalProgressBar vprgTPValue;
        public System.Windows.Forms.Label label49;
        public System.Windows.Forms.Button btnTP5Minute;
        public System.Windows.Forms.Button btnTPCalibrate;
        public System.Windows.Forms.Button btnTP1Hour;
        public System.Windows.Forms.PictureBox picTPStatus;
        public System.Windows.Forms.TextBox txtTPValue;
        public System.Windows.Forms.Button btnTPHistoryData;
        public System.Windows.Forms.Label label47;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label label5;
        public VerticalProgressBar.VerticalProgressBar vprgTOCValue;
        public System.Windows.Forms.TextBox txtTOCValue;
        public System.Windows.Forms.Label label48;
        public System.Windows.Forms.PictureBox picTOCStatus;
        public System.Windows.Forms.Label label43;
        public System.Windows.Forms.Button btnTOCCalibrate;
        public System.Windows.Forms.Button btnTOC5Minute;
        public System.Windows.Forms.Button btnTOCHistoryData;
        public System.Windows.Forms.Button btnTOC1Hour;
        public System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel18;
        public System.Windows.Forms.Button btnLoginLogout;
        public System.Windows.Forms.Label lblLoginDisplayName;
        public System.Windows.Forms.Label lblHeadingTime;
        private System.Windows.Forms.Panel panel21;
        public System.Windows.Forms.Panel panel16;
        public System.Windows.Forms.Label lblControlPanel;
        public System.Windows.Forms.Panel panel29;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox picDO4Status;
        public System.Windows.Forms.PictureBox picDO3Status;
        public System.Windows.Forms.PictureBox picDO2Status;
        public System.Windows.Forms.PictureBox picDO1Status;
        public System.Windows.Forms.Button btnDO4;
        public System.Windows.Forms.Button btnDO3;
        public System.Windows.Forms.Button btnDO2;
        public System.Windows.Forms.Button btnDO1;
        public System.Windows.Forms.Label lblDO4;
        public System.Windows.Forms.Label lblDO3;
        public System.Windows.Forms.Label lblDO2;
        public System.Windows.Forms.Label lblDO1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox picDO8Status;
        public System.Windows.Forms.Button btnDO8;
        public System.Windows.Forms.PictureBox picDO7Status;
        public System.Windows.Forms.Button btnDO5;
        public System.Windows.Forms.PictureBox picDO6Status;
        public System.Windows.Forms.Button btnDO7;
        public System.Windows.Forms.PictureBox picDO5Status;
        public System.Windows.Forms.Label lblDO5;
        public System.Windows.Forms.Button btnDO6;
        public System.Windows.Forms.Label lblDO6;
        public System.Windows.Forms.Label lblDO7;
        public System.Windows.Forms.Label lblDO8;
        public System.Windows.Forms.Label lblRRS;
        public System.Windows.Forms.Label lblLRS;
        public System.Windows.Forms.Label lblPumpRFLTName;
        public System.Windows.Forms.Label lblPumpLFLTName;
    }
}