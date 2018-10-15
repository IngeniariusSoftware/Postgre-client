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

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            if (_lampState != 0)
            {
                _lampState = 0;
                LampIcon.Image = Resources.LampOff;
            }

            if (HostMaskedTextBox.Text.Length > 0 & DataBaseTextBox.Text.Length > 0 & PortTextBox.Text.Length > 0
                & UserTextBox.Text.Length > 0 & PasswordTextBox.Text.Length > 0)
            {

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
    }
}
