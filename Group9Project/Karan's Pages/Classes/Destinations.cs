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
        static string boardingTime = DateTime.Now.AddHours(24).ToString("yyyy-M-d dddd");
        public static List<Seat> GetSeats()
        {
            List<Seat> seats = new List<Seat>();
            seats.Add(new Seat
            {
                Country = "Germany",
                Number = seatNumber.ToString(),
                Price = 400,
                Description = "One way ticket to Germany's Capital from Toronto Pearson (YYZ) \n Capital = Berlin (BER)",
                ImageName = "Germany.gif",
                BoardingTime = boardingTime
            });
            seats.Add(new Seat
            {
                Country = "Canada",
                Number = seatNumber.ToString(),
                Price = 200,
                Description = "One way ticket to Canada's Capital from Toronto Pearson (YYZ) \n Capital = Ottawa (YOW)",
                ImageName = "Canada.gif",
                BoardingTime = boardingTime
            });
            seats.Add(new Seat
            {
                Country = "Australia",
                Number = seatNumber.ToString(),
                Price = 700,
                Description = "One way ticket to Australia's Capital from Toronto Pearson (YYZ) \n Capital = Canberra (CBR)",
                ImageName = "Australia.gif",
                BoardingTime = boardingTime
            });
            seats.Add(new Seat
            {
                Country = "Japan",
                Number = seatNumber.ToString(),
                Price = 650,
                Description = "One way ticket to Japan's Capital from Toronto Pearson (YYZ) \n Capital = Tokyo (HND)",
                ImageName = "Japan.gif",
                BoardingTime = boardingTime
            });
            seats.Add(new Seat
            {
                Country = "United-Kingdom",
                Price = 300,
                Number = seatNumber.ToString(),
                Description = "One way ticket to United Kingdom's Capital from Toronto Pearson (YYZ) \n Capital = London (YXU)",
                ImageName = "United-Kingdom.gif",
                BoardingTime = boardingTime
            });
            seats.Add(new Seat
            {
                Country = "USA",
                Price = 150,
                Number = seatNumber.ToString(),
                Description = "One way ticket to USA's Capital from Toronto Pearson (YYZ) \n Capital = Washington (IAD)",
                ImageName = "USA.gif",
                BoardingTime = boardingTime
            });

            return seats;
        }
    }
}
