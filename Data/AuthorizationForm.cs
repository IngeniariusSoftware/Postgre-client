using System;
using System.Windows.Forms;


namespace Data
{
    using Data.Properties;

    public partial class AuthorizationForm : Form
    {
        public bool isStart = false;

        private bool _isEyeOpen = false, _isThreadFree = true;

        private int _waitTime = 0;

        private Login _currentLogin, _bufLogin;

        public Authenticator Authentication = new Authenticator();

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
            CreateLogin(out _bufLogin);
        }

        private void CreateLogin(out Login login)
        {
            login = new Login(
                HostTextBox.Text,
                DataBaseTextBox.Text,
                UserTextBox.Text,
                PasswordTextBox.Text,
                PortTextBox.Text);
        }

        private void TextChanged(object sender, EventArgs e)
        {
            if (HostTextBox.Text.Length > 0 && DataBaseTextBox.Text.Length > 0 && UserTextBox.Text.Length > 0)
            {
                CreateLogin(out _bufLogin);
                _waitTime = 1500;
                UpdateTimer.Start();
            }
        }

        private void EyeIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isEyeOpen)
            {
                PasswordTextBox.PasswordChar = '*';
                _isEyeOpen = false;
                EyeIcon.Image = Resources.CloseEye;
            }
            else
            {
                PasswordTextBox.PasswordChar = Char.MinValue;
                _isEyeOpen = true;
                EyeIcon.Image = Resources.OpenEye;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            isStart = true;
            Close();
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
                UpdateTimer.Stop();
                if (HostTextBox.Text.Length > 0 && DataBaseTextBox.Text.Length > 0 && UserTextBox.Text.Length > 0)
                {
                    if (_isThreadFree && _bufLogin != null && _currentLogin != _bufLogin)
                    {
                        _currentLogin = _bufLogin;
                        _isThreadFree = false;
                        LampIcon.Image = Resources.LampOn;
                        if (await Authentication.Connect(_currentLogin))
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
                else
                {
                    LampIcon.Image = Resources.LampOff;
                    StartButton.Enabled = false;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextChanged(null, null);
        }
    }
}
