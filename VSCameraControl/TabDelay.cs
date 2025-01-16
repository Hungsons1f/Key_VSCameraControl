using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace VSCameraControl
{
    public partial class TabDelay : Form, INotifyPropertyChanged
    {
        System.Windows.Forms.Timer timTimer;

        private bool tick;

        public bool Tick
        {
            get => tick; 
            private set
            {
                if (tick != value)
                {
                    tick = value;
                    OnPropertyChanged("Tick");
                    if (tick)
                    {
                        _tickEvent.Set(); // Signal the event
                    }
                }
            }
        }

        public TabDelay(string name)
        {
            InitializeComponent();
            timTimer = new System.Windows.Forms.Timer();
            timTimer.Tick += onTimTimer_Tick;

            lbName.Text = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private ManualResetEvent _tickEvent = new ManualResetEvent(false);

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void tbDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being entered
            }
        }

        private void onTimTimer_Tick(object sender, EventArgs e)
        {
            timTimer.Stop();
            Tick = true;
            btnLight.BackColor = Color.Lime;
        }

        public void Start()
        {
            timTimer.Start();
            Tick = false;
            btnLight.BackColor = Color.White;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Tick = false;
            btnLight.BackColor = Color.White;
        }

        private void tbDelay_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbDelay.Text, out int interval))
            {
                if (interval > 0) timTimer.Interval = interval;
            }
        }

        public async Task WaitForTick()
        {
            await Task.Run(() => _tickEvent.WaitOne()); // Wait for the signal
            _tickEvent.Reset(); // Reset the event for future use
        }
    }
}
