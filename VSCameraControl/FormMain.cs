using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Data;
using System.Windows.Forms;
using Binding = System.Windows.Forms.Binding;

namespace VSCameraControl
{
    public partial class FormMain : Form
    {
        private int tabCounter;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void btnRemoveCam_Click(object sender, EventArgs e)
        {            
            if (tabControl.SelectedTab != null)
            {
                string tabName = tabControl.SelectedTab.Text;

                foreach (Form control in tabControl.SelectedTab.Controls)
                {
                    control.Close();
                    tabControl.SelectedTab.Controls.Remove(control);
                    control.Dispose();
                }
                tabControl.TabPages.Remove(tabControl.SelectedTab);

                foreach (Control control in ctCamBtn.Controls)
                {
                    if (control is Button button && button.Text == tabName)
                    {
                        ctCamBtn.Controls.Remove(button);
                        button.Dispose();
                        break;
                    }
                }
            }
        }

        private void btnAddCam_Click(object sender, EventArgs e)
        {
            string tabName = "Cam " + tabCounter++;
            TabPage tabPage = new TabPage(tabName);
            tabPage.Name = tabName;
            TabCamera objTabCam = new TabCamera(tabName);
            objTabCam.Name = tabName;
            
            objTabCam.TopLevel = false;
            objTabCam.Dock = DockStyle.Fill;
            objTabCam.FormBorderStyle = FormBorderStyle.None;
            objTabCam.Visible = true;

            tabPage.Controls.Add(objTabCam);
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            Button btnCamNew = new Button();
            btnCamNew.Text = tabName;
            btnCamNew.Click += (s, args) => btnCamN_Click(tabControl, btnCamNew.Text);
            ctCamBtn.Controls.Add(btnCamNew);

            Binding dataBinding = new Binding("Tag", objTabCam, "Mode", true, DataSourceUpdateMode.OnPropertyChanged);
            dataBinding.BindingComplete += BindingCplt;
            btnCamNew.DataBindings.Add(dataBinding);
        }

        private void BindingCplt(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteState == BindingCompleteState.Success)
            {
                Button btnCamNew = (Button)e.Binding.Control;
                TabCamera objTabCam = (TabCamera)e.Binding.DataSource;

                if (objTabCam.Mode == "Not Connect") btnCamNew.BackColor = Color.White;
                else if (objTabCam.Mode == "Run Mode") btnCamNew.BackColor = Color.Lime;
                else if (objTabCam.Mode == "Setup Mode") btnCamNew.BackColor = Color.Cyan;
            }
        }

        private void btnCamN_Click(TabControl tabControl, string tabName)
        {
            string tab = tabControl.TabPages[1].Name;
            tabControl.SelectTab(tabName);
        }

        private void btnAddDelay_Click(object sender, EventArgs e)
        {
            string tabName = "Delay " + tabCounter++;
            TabPage tabPage = new TabPage(tabName);
            tabPage.Name = tabName;
            TabDelay objTabDelay = new TabDelay(tabName);

            objTabDelay.TopLevel = false;
            objTabDelay.Dock = DockStyle.Fill;
            objTabDelay.FormBorderStyle = FormBorderStyle.None;
            objTabDelay.Visible = true;

            tabPage.Controls.Add(objTabDelay);
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            Button btnCamNew = new Button();
            btnCamNew.Text = tabName;
            btnCamNew.Click += (s, args) => btnCamN_Click(tabControl, btnCamNew.Text);
            ctCamBtn.Controls.Add(btnCamNew);
        }

        private async void btnTriggerAll_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                foreach (Form form in tab.Controls)
                {
                    if (form is TabCamera cam)
                    {
                        cam.TriggerCamera();
                    }
                    else if (form is TabDelay delay)
                    {
                        delay.Start();
                        await delay.WaitForTick();
                    }
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an application used for demo and trial with Keyence camera VS. " +
                "It is intended to used inside Keyence internal devices. " +
                "Do not disclose to outside customer or use for personal reason. " +
                "We don't take responsibility for any damage or effect that resulted from wrong usage!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class MultiBindingConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 2 && values[0] is bool connected && values[1] is string runMode)
            {
                if (!connected)
                    return Color.White;
                else if (connected && runMode == "RunMode")
                    return Color.Cyan;
                else if (connected && runMode == "SetupMode")
                    return Color.Green;
            }
            return Color.White;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
