using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevFinalProject.Karan_s_Pages.Classes
{
    class Destinations
    {
        
        static Random r = new Random();
        static int seatNumber = r.Next(0, 100);
        static string boardingTime = DateTime.Now.AddHours(24).ToString("h:mm:ss tt");
        public static List<Seat> GetSeats()
        {
            List<Seat> seats = new List<Seat>();
            seats.Add(new Seat
            {
                Country = "Germany",
                Number = seatNumber.ToString(),
                Description = "Germany is cool",
                ImageName = "Germany.gif",
                BoardingTime = boardingTime


            });
        
            return seats;
        }
    }
}
