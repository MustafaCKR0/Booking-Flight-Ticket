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
    public partial class PersonelForm : KryptonForm
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {

        }

        private void StaffFormTimelabel_Click(object sender, EventArgs e)
        {

        }

        private void StaffFormPagetimer_Tick(object sender, EventArgs e)
        {
            StaffFormDatelabel.Text = DateTime.Now.ToShortDateString();
            StaffFormTimelabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void StaffFormWelcomeBack_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
