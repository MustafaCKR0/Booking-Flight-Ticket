using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            lblReturnDay.Text = "";
            lblDepatureDay.Text = "";

            
        }

        
        private void FlyingForm_Load(object sender, EventArgs e)
        {
            PopulateTicketItems();
            PopulateSearchItems();
            sidebarContainer.AutoScroll = true;
        }
        private void PopulateSearchItems()
        {
            SearchCityOrAirport[] searchingLists = new SearchCityOrAirport[20];

           
                searchingLists[0] = new SearchCityOrAirport();
                searchingLists[0].CityAndCountryName = "İstanbul, Turkey";
                searchingLists[0].AirportName = "All Airports";
                searchingCountainer.Controls.Add(searchingLists[0]);

            searchingLists[1] = new SearchCityOrAirport();
            searchingLists[1].CityAndCountryName = "İstanbul, Turkey";
            searchingLists[1].AirportName = "İstanbul Airport";
            searchingCountainer.Controls.Add(searchingLists[1]);

            searchingLists[2] = new SearchCityOrAirport();
            searchingLists[2].CityAndCountryName = "Adana, Turkey";
            searchingLists[2].AirportName = "Adana Airport";
            searchingCountainer.Controls.Add(searchingLists[2]);

            searchingLists[3] = new SearchCityOrAirport();
            searchingLists[3].CityAndCountryName = "Ankara, Turkey";
            searchingLists[3].AirportName = "Esenboğa Airport";
            searchingCountainer.Controls.Add(searchingLists[3]);

            



        }
        private void PopulateTicketItems()
        {
            TicketList[] ticketLists = new TicketList[20];

            for (int i = 0; i < ticketLists.Length; i++)
            {
                ticketLists[i] = new TicketList();

                ticketLists[i].LuggageAmount = 6 + i;
                ticketLists[i].DepartureTime = "20:45";
                ticketLists[i].LandingTime = "23:45";
                ticketLists[i].DepartureLocation = "ISTA";
                ticketLists[i].LandingLocation = "ESB";
                ticketLists[i].TravelTime = "3 Hour";
                ticketLists[i].Price = 4.987;

                if (i%2 == 0)
                {
                    ticketLists[i].IsTransfer = false;
                    ticketLists[i].TravelType = "Direct";
                }else
                {
                    ticketLists[i].IsTransfer = true;
                    ticketLists[i].TravelType = "1 Transfer (SAW)";

                }

                getTicketContainer.Controls.Add(ticketLists[i]);


            }
        }

        bool placeExpand = false;
        private void placeTransition_Tick(object sender, EventArgs e)
        {
            if (placeExpand == false)
            {
                placeContainer.Height += 10;
                if (placeContainer.Height >= 288)
                {
                    placeTransition.Stop();
                    placeExpand = true;
                }
            }
            else
            {
                placeContainer.Height -= 10;
                if (placeContainer.Height <= 100)
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

        bool isDepatureDate;

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            dateTransition.Start();
            isDepatureDate = true;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            dateTransition.Start();
            isDepatureDate = false;
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            
            //sidebarContainer.WrapContents = false;
            if (sidebarExpand)
            {
                
                if (sidebarContainer.Width <= 10)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    sidebarContainer.AutoScroll = false;

                } else
                {
                    sidebarContainer.Width -= 10;
                    sidebarContainer.AutoScroll = false;
                    ElementsCountainer.Location = new Point(ElementsCountainer.Location.X - 5, ElementsCountainer.Location.Y);
                    getTicketContainer.Location = new Point(getTicketContainer.Location.X - 5, getTicketContainer.Location.Y);
                }
            }
            else
            {

                if (sidebarContainer.Width >= 307)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    sidebarContainer.AutoScroll = true;
                }
                else
                {
                    sidebarContainer.Width += 10;
                    ElementsCountainer.Location = new Point(ElementsCountainer.Location.X + 5, ElementsCountainer.Location.Y);
                    getTicketContainer.Location = new Point(getTicketContainer.Location.X + 5, getTicketContainer.Location.Y);

                }
            }
            AdjustPictureBoxPosition();
        }

        private void AdjustPictureBoxPosition()
        {
            int sidebarWidth = sidebarContainer.Width;
            int pictureboxX = sidebarWidth - pictureBox1.Width / 3;
            pictureBox1.Location = new Point(pictureboxX, pictureBox1.Location.Y);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            this.lbltimer.Text = ((DateTime.Now.Hour <= 9) ? ("0" + DateTime.Now.Hour.ToString()) : DateTime.Now.Hour.ToString()) + ":" + ((DateTime.Now.Minute <= 9) ? ("0" + DateTime.Now.Minute.ToString()) : DateTime.Now.Minute.ToString()) + ":" + ((DateTime.Now.Second <= 9) ? ("0" + DateTime.Now.Second.ToString()) : DateTime.Now.Second.ToString());
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateTransition.Start();
            if(isDepatureDate)
            {
                kryptonButton4.Text = monthCalendar1.SelectionStart.ToString("dd MMMM", new CultureInfo("en-US"));
                lblDepatureDay.Text = monthCalendar1.SelectionStart.ToString("dddd", new CultureInfo("en-US"));
            }
            else
            {
                kryptonButton5.Text = monthCalendar1.SelectionStart.ToString("dd MMMM", new CultureInfo("en-US"));
                lblReturnDay.Text = monthCalendar1.SelectionStart.ToString("dddd", new CultureInfo("en-US"));
            }
        }

        private void lblAdultNumber_TextChanged(object sender, EventArgs e)
        {
            int totalPeopleNumber = 0;
            totalPeopleNumber += Convert.ToInt32(lblAdultNumber.Text);
            totalPeopleNumber += Convert.ToInt32(lblChildNumber.Text);
            totalPeopleNumber += Convert.ToInt32(lblBabyNumber.Text);
            lblTotalPeopleNumber.Text = totalPeopleNumber.ToString();
        }

        private void btnSidebarSearch_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
