using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Group9Project.Dylan_s_Pages;

namespace Group9Project.Deep_s_Pages
{
    //Class that contains all the required methods for the slot machine game to function
    class SlotGame
    {
        
        //Properties that represent the bonus turns and a jackpot boolean.
        public int Bonus;
        public bool IsJackpot;

        
        //Method that calculates if the slot game is over or not.
        public bool IsSlotOver()
        {
            return User.Money == 0.0  && Bonus == 0;
        }

        //Method that calculates all the winnings and losses everytime the game is played.
        private void CalculateMoney(List<int> numbers)
        {
            IsJackpot = false;
            if (numbers[0] == numbers[1] && numbers[1] == numbers[2])
            {
                if (numbers[0] == 4) 
                {
                    User.Money += 500;
                    IsJackpot = true;
                }

                else
                {
                    User.Money += 100;
                }

            }

            else if (numbers[0] == numbers[1] || numbers[1] == numbers[2] || numbers[0] == numbers[2])
            {
                Bonus++;
            }

            else
            {
                if (User.Money > 0)
                    User.Money -= 25;
                else
                    Bonus--;
            }

        }

        //Method that is responsible to assign the slot machine pictures into a list of 3 to be displayed.
        public List<int> Roll()
        {
            Random randomNumberGenerator = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                numbers.Add(randomNumberGenerator.Next(0, 5));

            }
            
            CalculateMoney(numbers);
            return numbers;

        }
    }

}
