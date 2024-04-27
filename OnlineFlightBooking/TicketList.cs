using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFlightBooking
{
    public partial class TicketList : UserControl
    {
        public TicketList()
        {
            InitializeComponent();
        }

        #region Proporties

        private int _luggageAmount;
        private string _departureTime;
        private string _landingTime;
        private string _departureLocation;
        private string _landingLocation;
        private string _travelType;
        private string _travelTime;
        private bool _isTransfer;
        private double _price;

        [Category("Custom Props")]
        public int LuggageAmount
        {
            get { 
                return _luggageAmount; 
            }
            set { 
                _luggageAmount = value; 
                lblLuggageAmount.Text = value.ToString() + " Kg"; 
            }
        }

        [Category("Custom Props")]
        public string DepartureTime
        {
            get
            {
                return _departureTime;
            }
            set
            {
                _departureTime = value;
                lblDepartureTime.Text = value;
            }
        }

        [Category("Custom Props")]
        public string LandingTime
        {
            get
            {
                return _landingTime;
            }
            set
            {
                _landingTime = value;
                lblLandingTime.Text = value;
            }
        }

        [Category("Custom Props")]
        public string DepartureLocation
        {
            get
            {
                return _departureLocation;
            }
            set
            {
                _departureLocation = value;
                lblDepartureLocation.Text = value;
            }
        }

        [Category("Custom Props")]
        public string LandingLocation
        {
            get
            {
                return _landingLocation;
            }
            set
            {
                _landingLocation = value;
                lblLandingLocation.Text = value;
            }
        }


        [Category("Custom Props")]
        public string TravelType
        {
            get
            {
                return _travelType;
            }
            set
            {
                _travelType = value;
                lblTravelType.Text = value;
            }
        }


        [Category("Custom Props")]
        public string TravelTime
        {
            get
            {
                return _travelTime;
            }
            set
            {
                _travelTime = value;
                lblTravelTime.Text = value;
            }
        }


        [Category("Custom Props")]
        public bool IsTransfer
        {
            get
            {
                return _isTransfer;
            }
            set
            {
                _isTransfer = value;
                if(_isTransfer)
                {
                    pictureTransfer.Visible = true;
                } else
                {
                    pictureTransfer.Visible = false;
                }
                
            }
        }

        [Category("Custom Props")]
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                btnPrice.Text = value.ToString() + " ₺";
            }
        }
        #endregion

        private void TicketList_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void TicketList_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
