using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Group9Project.Dylan_s_Pages;

namespace Group9Project.Deep_s_Pages
{
    class SlotGame
    {
        
        public int Bonus;
        public bool IsJackpot;

        
        public bool IsSlotOver()
        {
            return User.Money == 0.0  && Bonus == 0;
        }

        private void CalculateMoney(List<int> numbers)
        {
            IsJackpot = false;
            if (numbers[0] == numbers[1] && numbers[1] == numbers[2])
            {
                if (numbers[0] == 4) 
                {
                    User.Money += 100;
                    IsJackpot = true;
                }

                else
                {
                    User.Money += 50;
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
