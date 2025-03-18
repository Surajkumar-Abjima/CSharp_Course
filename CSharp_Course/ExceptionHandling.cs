using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course {
    class ExceptionHandling {
        public static void Exceptions() {
            bool looping = true;
            while (looping) {
                try {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);
                    looping = false;
                } catch (FormatException) {
                    Console.WriteLine("Please enter only number");
                } catch (Exception) {
                    Console.WriteLine("Something went wrong");
                }
            }
        }

    }
}
