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
    public partial class MainPageForm : KryptonForm
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void MainPageFormKryptonPalette_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        
       

        private void MainPageForm_Load(object sender, EventArgs e)
        {

        }

        private void MainPageTimerDate_Tick_1(object sender, EventArgs e)
        {
            MainPageLabelDate.Text = DateTime.Now.ToShortDateString();
            MainPageLabelTime.Text = DateTime.Now.ToShortTimeString();
        }
        int intImgNum = 0;
        private void MainPageTimerImage_Tick_1(object sender, EventArgs e)
        {
            MainPagePictureBoxImage.Image = MainPageImageList.Images[intImgNum];
            if (intImgNum == MainPageImageList.Images.Count - 1)
            {
                intImgNum = 0;
            }
            else
            {
                intImgNum++;
            }
        }
    }
    }

