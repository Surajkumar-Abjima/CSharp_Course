using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course
{
    class CSharpArray
    {   
        public static void ArrayIntro() {
            int[] numbers = new int[3];

            for(int i = 0; i < numbers.Length; i++) {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int num in numbers) {
                Console.Write($"{num} ");
            }

        }

    }
}
