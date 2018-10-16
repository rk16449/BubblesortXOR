using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblesortXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1000 entries
            int length = 1000;
            ushort[] nums = new ushort[length];

            // random object
            Random r = new Random();

            // fill up the array with random values
            for(int i=0; i<length; i++)
            {
                nums[i] = (ushort) r.Next(0, 65535);
            }

            // O(n^2)
            int highest = 0;
            for(int i=0; i<length; i++)
            {
                for(int z=1; z<length; z++)
                {
                    int v = nums[i] ^ nums[z];

                    if(v > highest)
                    {
                        highest = v; 
                    }
                }
            }

            // print highest
            Console.WriteLine("the highest value is " + highest);
            Console.ReadKey();
        }
    }

}
