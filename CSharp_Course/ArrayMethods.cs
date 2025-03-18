namespace CSharp_Course {
    class ArrayMethods {
        public static void ArraySort() {
            int[] arr = new int[] {
                1,101,102,111,112,1112,200
            };
            //Array.Sort(arr);
            //foreach(int item in arr) {
            //    Console.WriteLine(item);
            //}


            //Bubble sort
            //for(int i = 0; i < arr.Length - 1; i++) {
            //    for (int j = 0; j < arr.Length - 1 - i; j++) {
            //        if (arr[j] > arr[j + 1]) {
            //            int temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}


            //selection sort: repeatedly finding smallest element and moving it to front
            for(int i = 0; i < arr.Length - 1; i++) {
                int minindex = i;
                for(int j = i; j < arr.Length; j++) {
                    if (arr[j] < arr[minindex]) {
                        minindex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minindex];
                arr[minindex] = temp;
            }
            foreach (int i in arr) {
                Console.WriteLine(i);
            }

        }

        public static void ArrayReverse() {
            int[] arr = new int[] {
                1,2,3,4,5,6,7,8,9
            };
            Array.Reverse(arr);

            Console.WriteLine(string.Join(", ", arr));
        }

        public static void ArrayFind() {
            int[] arr = { 1, 23, 4, 5, 23, 67, 65,12,14,2,13456 };
            int[] x =Array.FindAll(arr, num => num % 2 == 0);
            Console.WriteLine(string.Join(", ",x));
        }

        public static void ArrayCopy() {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] copyArray = new int[5];
            //Array.Copy(arr, copyArray, 3);
            Array.Copy(arr, 1, copyArray, 1, 2);
            Console.WriteLine(string.Join(", ", copyArray));
        }

        public static void ArrayClone() {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] cloneArray = (int[])arr.Clone();
            Console.WriteLine(string.Join(", ", cloneArray));
        }
    }
}
