using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineFlightBooking
{
    public partial class SearchCityOrAirport : UserControl
    {
        public bool _isSelected = false;
        public SearchCityOrAirport()
        {
            InitializeComponent();
        }




        #region Proporties

        private string _cityAndCountryName;
        private string _airportName;
        
        [Category("Custom Props")]
        public string CityAndCountryName
        {
            get
            {
                return _cityAndCountryName;
            }
            set
            {
                _cityAndCountryName = value;
                lblCityCountry.Text = value.ToString();
            }
        }

        [Category("Custom Props")]
        public string AirportName
        {
            get
            {
                return _airportName;
            }
            set
            {
                _airportName = value;
                lblAirportName.Text = value;
            }
        }

        #endregion

        private void SearchCityOrAirport_MouseEnter(object sender, EventArgs e)
        {
            _isSelected = true;
        }

        private void btnAirportSelect_Click(object sender, EventArgs e)
        {
            int index = lblCityCountry.Text.IndexOf(",");
            
                var result = lblCityCountry.Text.Substring(0, index).Trim();
                Console.WriteLine(result); // Çıktı: İstanbul
            
            var placeContainer = this.Parent as Panel;
            var flyingForm = placeContainer.TopLevelControl as KryptonForm;
            ((ComponentFactory.Krypton.Toolkit.KryptonButton)flyingForm.Controls.Find("kryptonButton2", true)[0]).Text = result;
        }
    }
}
