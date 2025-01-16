using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Data;
using Binding = System.Windows.Forms.Binding;

namespace VSCameraControl
{
    public partial class TabCamera : Form, INotifyPropertyChanged
    {
        public TabCamera(string name)
        {
            InitializeComponent();

            cbLocation.SelectedIndex = 0;
            objVSCam1 = new Camera();
            lbName.Text = name;

            Binding dataBinding_RunMode = new Binding("Text", objVSCam1, "RunMode", true, DataSourceUpdateMode.OnPropertyChanged);
            dataBinding_RunMode.BindingComplete += BindingCplt_Runmode;
            tRunMode.DataBindings.Add(dataBinding_RunMode);
            Binding dataBinding_CurrentLocation = new Binding("Text", objVSCam1, "CurrentLocation", true, DataSourceUpdateMode.OnPropertyChanged);
            tLocation.DataBindings.Add(dataBinding_CurrentLocation);
            Binding dataBinding_CurrentProgramNo = new Binding("Text", objVSCam1, "CurrentProgramNo", true, DataSourceUpdateMode.OnPropertyChanged);
            tProgramNo.DataBindings.Add(dataBinding_CurrentProgramNo);
            Binding dataBinding_Connected = new Binding("Text", objVSCam1, "Connected", true, DataSourceUpdateMode.OnPropertyChanged);
            tConnected.DataBindings.Add(dataBinding_Connected);
            Binding dataBinding_Connected2 = new Binding("Text", objVSCam1, "Connected", true, DataSourceUpdateMode.OnPropertyChanged);
            btnConnectCam1.DataBindings.Add(dataBinding_Connected2);
            Binding dataBinding_btnConnected = new Binding("Enabled", objVSCam1, "Connected", true, DataSourceUpdateMode.OnPropertyChanged);
            bDisconnect.DataBindings.Add(dataBinding_btnConnected);
            Binding dataBinding_btnConnected1 = new Binding("Enabled", objVSCam1, "Connected", true, DataSourceUpdateMode.OnPropertyChanged);
            btnTrigger1.DataBindings.Add(dataBinding_btnConnected1);
            Binding dataBinding_btnConnected2 = new Binding("Enabled", objVSCam1, "Connected", true, DataSourceUpdateMode.OnPropertyChanged);
            btnReset.DataBindings.Add(dataBinding_btnConnected2);
            Binding dataBinding_btnConnected3 = new Binding("Enabled", objVSCam1, "Connected", true, DataSourceUpdateMode.OnPropertyChanged);
            bClearError.DataBindings.Add(dataBinding_btnConnected3);
            Binding dataBinding_btnConnected4 = new Binding("Enabled", objVSCam1, "Connected", true, DataSourceUpdateMode.OnPropertyChanged);
            bRun.DataBindings.Add(dataBinding_btnConnected4);
            Binding dataBinding_btnConnected5 = new Binding("Enabled", objVSCam1, "Connected", true, DataSourceUpdateMode.OnPropertyChanged);
            bSetup.DataBindings.Add(dataBinding_btnConnected5);
            Binding dataBinding_btnConnected6 = new Binding("Enabled", objVSCam1, "Connected", true, DataSourceUpdateMode.OnPropertyChanged);
            bChangeProgram.DataBindings.Add(dataBinding_btnConnected6);
        }

        private void BindingCplt_Runmode(object sender, BindingCompleteEventArgs e)
        {
            if (!objVSCam1.Connected) Mode = "Not Connect";
            else if (objVSCam1.Connected) Mode = objVSCam1.RunMode;
        }

        private Camera objVSCam1;
        private string runMode;
        private bool connected;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Mode
        {
            get => runMode;
            set
            {
                if (runMode != value)
                {
                    runMode = value;
                    OnPropertyChanged(nameof(Mode));
                }
            }
        }

        public bool Connected { get => connected; }

        private async void btnConnectCam1_Click(object sender, EventArgs e)
        {
            try
            {
                await objVSCam1.Connect(tbIPAddress.Text, Convert.ToInt16(tbPort.Text));

                if (!objVSCam1.Connected)
                {
                    MessageBox.Show("Cannot connect. Error: Cannot find IP Address or Port", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    await objVSCam1.ReadDataAsync();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Cannot connect. Error: " + er.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being entered
            }
        }

        private void btnTrigger1_Click(object sender, EventArgs e)
        {
            if (!objVSCam1.Connected || !objVSCam1.Trigger())
            {
                MessageBox.Show("Cannot Trigger!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            objVSCam1.Dispose();
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            if (!objVSCam1.Connected || !objVSCam1.Reset())
            {
                MessageBox.Show("Cannot Reset!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bRun1_Click(object sender, EventArgs e)
        {
            if (!objVSCam1.Connected || !objVSCam1.Run())
            {
                MessageBox.Show("Cannot Run!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSetup1_Click(object sender, EventArgs e)
        {
            if (!objVSCam1.Connected || !objVSCam1.Setup())
            {
                MessageBox.Show("Cannot Setup!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bDisconnect1_Click(object sender, EventArgs e)
        {
            objVSCam1?.Disconnect();
            tConnected.Text = "Not Connect";
        }

        private void bClearError1_Click(object sender, EventArgs e)
        {
            if (!objVSCam1.Connected || !objVSCam1.ClearError())
            {
                MessageBox.Show("Cannot Clear Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bChangeProgram1_Click(object sender, EventArgs e)
        {
            if (!objVSCam1.Connected || !objVSCam1.ChangeProgram(Convert.ToInt16(tbProgramNumber.Text), cbLocation.SelectedIndex + 1))
            {
                MessageBox.Show("Cannot Change program!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbProgramNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being entered
            }
        }

        public void TriggerCamera ()
        {
            if (!objVSCam1.Connected || !objVSCam1.Trigger())
            {
                MessageBox.Show("Cannot Trigger!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tConnected_TextChanged(object sender, EventArgs e)
        {
            if (tConnected.Text == "True")
            {
                tConnected.Text = "Connected";
                tConnected.BackColor = Color.Lime;
            }
            else if (tConnected.Text == "False")
            {
                tConnected.Text = "Not Connect";
                tConnected.BackColor = Color.White;
            }
        }

        private void tRunMode_TextChanged(object sender, EventArgs e)
        {
            if (tRunMode.Text == "Run Mode") tRunMode.BackColor = Color.Lime;
            if (tRunMode.Text == "Setup Mode") tRunMode.BackColor = Color.Cyan;
            if (tRunMode.Text == "Unknown") tRunMode.BackColor = Color.White;
        }

        private void tLocation_TextChanged(object sender, EventArgs e)
        {
            if (tLocation.Text == "1") tLocation.Text = "Internal Memory";
            if (tLocation.Text == "2") tLocation.Text = "SD Card";
            if (tLocation.Text == "0") tLocation.Text = "--";
        }

        private void tProgramNo_TextChanged(object sender, EventArgs e)
        {
            if (tProgramNo.Text == "-1") tProgramNo.Text = "--";
        }

        private void btnConnectCam1_TextChanged(object sender, EventArgs e)
        {
            if (btnConnectCam1.Text == "True")
            {
                btnConnectCam1.Text = "Connect";
                btnConnectCam1.Enabled = false;
            }
            if (btnConnectCam1.Text == "False")
            {
                btnConnectCam1.Text = "Connect";
                btnConnectCam1.Enabled = true;
            }
        }
    }

    public class Camera : Form, IDisposable, INotifyPropertyChanged 
    {
        public Camera()
        {


        }

        public void Dispose()
        {
            stream?.Close();
            stream?.Dispose();
            tcpClient?.Dispose();
            base.Dispose();
        }

        TcpClient tcpClient;
        NetworkStream stream;
        Timer timTimer;

        public bool Connected
        {
            get => connected;
            private set
            {
                if (connected != value)
                {
                    connected = value;
                    OnPropertyChanged(nameof(connected));

                    if (value == false)
                    {
                        stream?.Close();
                        tcpClient?.Close();
                        timTimer?.Stop();
                        if (timTimer != null) timTimer.Tick -= onTimTimer_Tick;
                        timTimer?.Dispose();

                        RunMode = "0";
                        CurrentLocation = 0;
                        CurrentProgramNo = -1;
                    }
                }
            }
        }
        public string RunMode
        {
            get
            {
                if (tcpClient == null || !tcpClient.Connected)
                    return "Unknown";
                else if (runMode == false && tcpClient.Connected)
                    return "Setup Mode";
                else if (runMode == true && tcpClient.Connected)
                    return "Run Mode";
                else
                    return "Unknown";
            }
            private set
            {
                runMode = Convert.ToBoolean(Convert.ToInt32(value));
                OnPropertyChanged(nameof(RunMode));
            }
        }
        public int CurrentLocation 
        { 
            get => currentLocation; 
            private set 
            {
                if (currentLocation != value)
                {
                    currentLocation = value;
                    OnPropertyChanged(nameof(CurrentLocation));
                }
            } 
        }
        public int CurrentProgramNo 
        { 
            get => currentProgramNumber;
            private set
            {
                if (currentProgramNumber != value)
                {
                    currentProgramNumber = value;
                    OnPropertyChanged(nameof(CurrentProgramNo));
                }
            }
        }

        private bool connected;
        private bool runMode;
        private int currentLocation;
        private int currentProgramNumber;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task<bool> Connect(string sIPAddress, int uPort)
        {
            try
            {
                tcpClient = new TcpClient();
                await tcpClient.ConnectAsync(sIPAddress, uPort);
                stream = tcpClient.GetStream();
                Connected = true;

                timTimer = new Timer();
                timTimer.Tick += onTimTimer_Tick;
                timTimer.Interval = 1000;
                timTimer.Start();

                return true;
            }
            catch (Exception)
            {
                Connected = false;
                return false;
            }           
        }

        public bool Disconnect()
        {
            try
            {
                Connected = false;
                return true;
            }
            catch (Exception)
            {
                Connected = false;
                return false;
            }
        }

        public bool WriteCmd(string sCmd)
        {
            if (!tcpClient.Connected)
            {
                Connected = false;
                return false;
            }
            try
            {
                string sMessage = sCmd + "\r";
                byte[] iData = System.Text.Encoding.UTF8.GetBytes(sMessage);
                stream.Write(iData, 0, iData.Length);
                return true;
            }
            catch (Exception)
            {
                if (!tcpClient.Connected) Connected = false; 
                return false;
            }
        }

        public bool ReadData(out string sData)
        {
            if (!tcpClient.Connected)
            {
                sData = null;
                Connected = false;
                return false;
            }

            try
            {
                byte[] data = new byte[256];
                int bytes = stream.Read(data, 0, data.Length);
                sData = Encoding.ASCII.GetString(data, 0, bytes);
                return true;
            }
            catch (Exception)
            {
                if(!tcpClient.Connected) Connected = false;
                sData = null;
                return false;
            }
        }

        public async Task ReadDataAsync ()
        {
            try
            {
                int bytesRead;
                byte[] buffer = new byte[128];
                var handle = this.Handle;
                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (IsHandleCreated)
                    {
                        Invoke(new Action(() => {
                            int indexer = data.IndexOf("MOR");
                            if (indexer >= 0)
                            {
                                RunMode = data.Substring(indexer + 4, 1);
                            }

                            indexer = data.IndexOf("PR");
                            if (indexer >= 0 && !(indexer >=3 && data.Substring(indexer - 3,2) == "ER"))
                            {
                                var a = data.Substring(indexer + 4, 1);
                                CurrentLocation = Convert.ToInt16(data.Substring(indexer + 3, 1));
                                int endString = (data.Substring(indexer + 5, data.Length - indexer - 5)).IndexOf("\r");
                                CurrentProgramNo = Convert.ToInt16(data.Substring(indexer + 5, endString));
                            }
                        }));

                    }
                }
            }
            catch (Exception ex)
            {
                if (!tcpClient.Connected) Connected = false;
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        public bool Trigger()
        {
            return WriteCmd("TRG");
        }

        public bool Reset()
        {
            return WriteCmd("RS");
        }

        public bool Run()
        {
            return WriteCmd("RUN");
        }

        public bool Setup()
        {
            return WriteCmd("SET");
        }

        public bool ClearError()
        {
            return (WriteCmd("ERC,0") && WriteCmd("ERC,1"));
        }

        public bool ChangeProgram(int iProgramNumber, int iLocation)
        {
            if (iLocation != 1 && iLocation != 2)
                return false;
            if (!WriteCmd("PL," + iLocation + "," + iProgramNumber))
                return false;
            return true;
        }

        private void onTimTimer_Tick(object sender, EventArgs e)
        {
            if (!tcpClient.Connected)
            {
                Connected = false;
                return;
            }
            try
            {
                string sCmd;
                if (runMode)
                    sCmd = "MOR\r" + "PR\r";
                else sCmd = "MOR\r";

                if (!WriteCmd(sCmd))
                {
                    return;
                }         
            }
            catch (Exception)
            {
                if (!tcpClient.Connected) Connected = false;
                return;
            }
        }

    }
}
