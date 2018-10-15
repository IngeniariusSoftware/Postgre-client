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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            LampIcon.Load("");
            if (HostMaskedTextBox.Text.Length > 0 & DataBaseTextBox.Text.Length > 0 & PortTextBox.Text.Length > 0
                & UserTextBox.Text.Length > 0 & PasswordTextBox.Text.Length > 0)
            {

            }
        }




    }
}
