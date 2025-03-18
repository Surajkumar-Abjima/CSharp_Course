using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course {
    class DictionaryCSharp {
        public static void DictionaryMethods() {
            Dictionary<int, string> student = new Dictionary<int, string> {
                {1,"Rohit" },
                {2,"Gill" },
                {3,"Kohli" },
                {4,"Axar" }
            };
            foreach (var pair in student) {
                Console.WriteLine($"Key: {pair.Key} Value: {pair.Value}");
            }
            Console.WriteLine("------------------------");
            student.Add(5, "Rahul");
            foreach (var pair in student) {
                Console.WriteLine($"Key: {pair.Key} Value: {pair.Value}");
            }
            Console.WriteLine("------------------------");

            Console.WriteLine(student.ContainsKey(3));

            Console.WriteLine(student.ContainsValue("Rahul"));

            Console.WriteLine(student[1]);

            Console.WriteLine(student.Count);
        }

    }
}
