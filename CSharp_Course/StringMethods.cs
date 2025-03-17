
namespace CSharp_Course {

    class StringMethods {
        public static int StringLength(string name) {
            return name.Length;
        }
        public static string StringUpper(string name) {
            return name.ToUpper();
        }

        public static string StringLower(string name) {
            return name.ToLower();
        }

        public static bool StringContains(string a, string b) {
            return a.Contains(b);
        }

        public static string StringReplace(string name) {
            return name.Replace("s", "S");
        }

        public static string StringSubstring(String name) {
            Console.WriteLine(name.Length);
            return name.Substring(6, 5);
        }

        public static char StringElement(string name, int ele) {
            return name.ElementAt(ele);
        }

        public static string[] StringSplit(string name) {
            return name.Split(' ');
        }
    }
}