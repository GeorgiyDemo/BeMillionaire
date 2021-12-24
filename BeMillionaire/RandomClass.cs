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
        public static List<int> GetList(bool newgeneration, int size)
        {
            if (newgeneration == true)
            {
                listNumbers = new List<int>();
                Random rand = new Random();
                int number;
                for (int i = 0; i < size; i++)
                {
                    do
                    {
                        number = rand.Next(1, 30);
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
