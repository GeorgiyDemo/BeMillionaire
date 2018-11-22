using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeMillionaire
{
    class RandomClass
    {
        public static List<int> listNumbers;
        public static List<int> GetList(bool newgeneration)
        {
            if (newgeneration == true)
            {
                listNumbers = new List<int>();
                Random rand = new Random();
                int number;
                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        number = rand.Next(1, 10);
                    } while (listNumbers.Contains(number));
                    listNumbers.Add(number);
                }
            return listNumbers;
            }
            else
            {
                return listNumbers;
            }
        }
    }
}
