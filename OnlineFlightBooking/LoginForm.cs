using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace OnlineFlightBooking
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void kryptonPalette1_PalettePaint(object sender, ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }

        private void LoginFormLinkLabelCreat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFormPanelGood.Visible = false;
            LoginFormPanelLogin.Visible = false;
            LoginFormPanelCreate.Visible = true;

        }

        private void LoginFormButtonCreate_Click(object sender, EventArgs e)
        {
            LoginFormPanelGood.Visible = true; 
            LoginFormPanelLogin.Visible = true;
            LoginFormPanelCreate.Visible = false;
        }
    }
}
