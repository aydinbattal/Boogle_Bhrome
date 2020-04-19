using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group9Project.Deep_s_Pages
{
    class SlotGame
    {
        public int Money;
        public int Bonus;
        public bool IsJackpot;

        public SlotGame()
        {
            Money = 400;
        }


        public bool IsSlotOver()
        {
            return Money == 0 && Bonus == 0;
        }

        private void CalculateMoney(List<int> numbers)
        {
            IsJackpot = false;
            if (numbers[0] == numbers[1] && numbers[1] == numbers[2])
            {
                if (numbers[0] == 4) 
                {
                    Money += 1000;
                    IsJackpot = true;
                }

                else
                {
                    Money += 500;
                }

            }

            else if (numbers[0] == numbers[1] || numbers[1] == numbers[2] || numbers[0] == numbers[2])
            {
                Bonus++;
            }

            else
            {
                if (Money > 0)
                    Money -= 100;
                else
                    Bonus--;
            }

        }

        public List<int> Roll()
        {
            if (IsSlotOver())
            {
                throw new Exception("You have no more money");
            }

            
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
