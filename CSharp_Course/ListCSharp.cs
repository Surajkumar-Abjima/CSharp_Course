using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace CSharp_Course {
    class ListCSharp {
        public static void ListMethods() {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

            fruits.Add("Mango");

            Console.WriteLine(string.Join(", ", fruits));

            fruits.Insert(1, "Guava");
            Console.WriteLine(string.Join(", ", fruits));

            fruits.InsertRange(1, new string[] { "Pineapple", "Berry" });
            Console.WriteLine(string.Join(", ", fruits));

            fruits.Remove("Berry");
            Console.WriteLine(string.Join(", ", fruits));

            fruits.RemoveAt(0);
            Console.WriteLine(string.Join(", ", fruits));

            fruits.RemoveRange(0, 2);
            Console.WriteLine(string.Join(", ", fruits));

            Console.WriteLine(fruits.Contains("Banana"));

            Console.WriteLine(fruits.Find(fruit => fruit == "Banana"));
            fruits.Add("Banana");

            Console.WriteLine(string.Join(", ",fruits.FindAll(fruit => fruit == "Banana")));
        }


    }


}



