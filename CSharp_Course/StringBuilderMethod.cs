using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course {
    class StringBuilderMethod {
        public static StringBuilder StringAppend(string str) {

            StringBuilder sb = new StringBuilder(str);

            return sb.Append(" World");
            //return sb.ToString();
        }

        public static string InsertString(string str) {
            StringBuilder sb = new StringBuilder(str);
            sb.Insert(5, " C#");
            return sb.ToString();
              
        }

        public static StringBuilder RemoveString(String str) {
            StringBuilder sb = new StringBuilder(str);
            return sb.Remove(2, 3);
        }

        public static StringBuilder ReplaceString(string str) {
            StringBuilder sb = new StringBuilder(str);
            return sb.Replace(str, "World");
        }

    }
}
