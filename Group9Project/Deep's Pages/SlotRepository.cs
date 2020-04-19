using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group9Project.Deep_s_Pages
{
    class SlotRepository
    {
        public static List<SlotTemplate> GetHistory()
        {
            List<SlotTemplate> movies = new List<SlotTemplate>();

            movies.Add(new SlotTemplate
            {

                Description = "The first Slot machine was developed by the New York based company called Sittman and Pitt in 1891.The game had five drums" +
                              "and a total of fifty playing cards. Players would insert their coins and pull the level to play.The payout would depend on the" +
                              "lining up of poker hands displayed on the drums. The first machine had no direct payout mechanism, therefore wins were paid at" +
                              " the bar the machine was. These wins were non monetary prizes such as drinks and cigars.",
                ImageName = "1891SlotMachine.jpg",
                Year = 1891
            });

            movies.Add(new SlotTemplate
            {

                Description = "The first fully electromechanical slot called Money Honey was release by Bally. The reels were entirely electrical but the game" +
                              " was still played by pulling the level. This was due to people already being used to the level mechanism and would have been" +
                              " unfamiliar otherwise. It was the first slot machine with a bottomless hopper which made it so that the payout was automatic up" +
                              " to five hundred coins. This game was hugely popular and led to increasing dominance of electromechanical slots and soon after" +
                              " the lever mechanism was removed from new slot machines.",
                ImageName = "1964SlotMachine.jpg",
                Year = 1964
            });

            movies.Add(new SlotTemplate
            {

                Description = "The next milestone came in 1996 when the Reel Em by WMS industries Inc was released. This was the first video slot machine to" +
                              " feature a second screen bonus round. When this bonus round was triggered, a completely different screen was displayed where" +
                              " the bonus game took place. Additional payouts could be won during this round. During this time, slows became very popular at" +
                              " casinos and were responsible for seventy percent of a casino’s income and also took up the same amount of percentage of the" +
                              " available floor space.",
                ImageName = "1996+SlotMachine.jpg",
                Year = 1996
            });



            return movies;
        }
    }
}
