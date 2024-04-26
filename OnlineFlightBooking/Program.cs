using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFlightBooking
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
            Application.Run(new MainPageForm());
=======
<<<<<<< Updated upstream
            Application.Run(new FlyingForm());
=======
            Application.Run(new CheckinForm());
>>>>>>> Stashed changes
>>>>>>> Stashed changes
        }
    }
}
