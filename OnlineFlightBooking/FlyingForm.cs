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
    public partial class FlyingForm : KryptonForm
    {

        


        public FlyingForm()
        {
            InitializeComponent();
        }

        private void FlyingForm_Load(object sender, EventArgs e)
        {

        }
        bool placeExpand = false;
        private void placeTransition_Tick(object sender, EventArgs e)
        {
            if (placeExpand == false) {
                placeContainer.Height += 10;
                if(placeContainer.Height >= 233)
                {
                    placeTransition.Stop();
                    placeExpand = true;
                }
            }
            else
            {
                placeContainer.Height -= 10;
                if(placeContainer.Height <= 100)
                {
                    placeTransition.Stop();
                    placeExpand = false;
                }
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            placeTransition.Start();
        }

        private void FromBtn_Click(object sender, EventArgs e)
        {
            placeTransition.Start();
        }
        bool dateExpand = false;
        private void dateTransition_Tick(object sender, EventArgs e)
        {
            if (dateExpand == false)
            {
                dateContainer.Height += 10;
                if (dateContainer.Height >= 274)
                {
                    dateTransition.Stop();
                    dateExpand = true;
                }
            }
            else
            {
                dateContainer.Height -= 10;
                if (dateContainer.Height <= 100)
                {
                    dateTransition.Stop();
                    dateExpand = false;
                }
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            dateTransition.Start();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            dateTransition.Start();

        }

        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 0)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 290)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
            AdjustPictureBoxPosition();
        }

        private void AdjustPictureBoxPosition()
        {
            int sidebarWidth = sidebarContainer.Width;
            int pictureboxX = sidebarWidth;
            pictureBox1.Location = new Point(pictureboxX, pictureBox1.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
