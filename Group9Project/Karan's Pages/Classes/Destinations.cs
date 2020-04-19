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
            seats.Add(new Seat
            {
                Country = "Canada",
                Number = seatNumber.ToString(),
                Description = "Canada is cool",
                ImageName = "Canada.gif",
                BoardingTime = boardingTime
            });
            seats.Add(new Seat
            {
                Country = "Australia",
                Number = seatNumber.ToString(),
                Description = "Australia is cool",
                ImageName = "Australia.gif",
                BoardingTime = boardingTime
            });
            seats.Add(new Seat
            {
                Country = "Japan",
                Number = seatNumber.ToString(),
                Description = "Japan is cool",
                ImageName = "Japan.gif",
                BoardingTime = boardingTime
            });
            seats.Add(new Seat
            {
                Country = "United-Kingdom",
                Number = seatNumber.ToString(),
                Description = "United-Kingdom is cool",
                ImageName = "United-Kingdom.gif",
                BoardingTime = boardingTime
            });
            seats.Add(new Seat
            {
                Country = "USA",
                Number = seatNumber.ToString(),
                Description = "USA is cool",
                ImageName = "USA.gif",
                BoardingTime = boardingTime
            });

            return seats;
        }
    }
}
