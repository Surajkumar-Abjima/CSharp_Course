using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course {
    struct Structure {
        public string Name;
        public int Age;
        public Structure(string name, int age) {
            Name = name;
            Age = age;
        }

        public void Display() {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }

}
