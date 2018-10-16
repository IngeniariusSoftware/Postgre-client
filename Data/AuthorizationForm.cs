using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Data
{
    using Data.Properties;

    public partial class AuthorizationForm : Form
    {
        private byte _lampState = 0;

        private bool _isEyeOpen = false;

        private bool _isThreadFree = true;

        private int _waitTime = 1500;

        private Login _currentLogin = null;

        public AuthorizationForm()
        {
            InitializeComponent();
            // Загрузка автозаполнений
            // PasswordTextBox;
            // HostMaskedTextBox;
            // UserTextBox;
            // DataBaseTextBox;
            //  HostMaskedTextBox;
            UpdateTimer.Start();
        }

        private async void TextChanged(object sender, EventArgs e)
        {
            if (HostTextBox.Text.Length > 0 && DataBaseTextBox.Text.Length > 0 && UserTextBox.Text.Length > 0)
            {
                _waitTime = 1500;
            }
        }

        private void EyeIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isEyeOpen)
            {
                PasswordTextBox.PasswordChar = Char.MinValue;
                _isEyeOpen = false;
                EyeIcon.Image = Resources.CloseEye;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                _isEyeOpen = true;
                EyeIcon.Image = Resources.OpenEye;
            }
        }

        private async void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (_waitTime > UpdateTimer.Interval)
            {
                _waitTime -= UpdateTimer.Interval;
                StartButton.Enabled = false;
                LampIcon.Image = Resources.LampOff;
            }
            else
            {
                _waitTime = 0;
                if (HostTextBox.Text.Length > 0 && DataBaseTextBox.Text.Length > 0 && UserTextBox.Text.Length > 0
                    && _isThreadFree)
                {
                    Login login = new Login(
                        HostTextBox.Text,
                        DataBaseTextBox.Text,
                        UserTextBox.Text,
                        PasswordTextBox.Text,
                        PortTextBox.Text);
                    if (_currentLogin == null || !_currentLogin.Equals(login))
                    {
                        _isThreadFree = false;
                        LampIcon.Image = Resources.LampOn;
                        _currentLogin = login;
                        Authenticator authenticator = new Authenticator();
                        if (await authenticator.Connect(login))
                        {
                            if (_waitTime == 0)
                            {
                                LampIcon.Image = Resources.LampOk;
                                StartButton.Enabled = true;
                            }
                            else
                            {
                                LampIcon.Image = Resources.LampOff;
                                StartButton.Enabled = false;
                            }
                            
                        }
                        else
                        {
                            if (_waitTime == 0)
                            {
                                LampIcon.Image = Resources.LampNo;
                            }
                            else
                            {
                                LampIcon.Image = Resources.LampOff;
                            }

                            StartButton.Enabled = false;
                        }

                        _isThreadFree = true;
                    }
                }
            }
        }
    }
}
