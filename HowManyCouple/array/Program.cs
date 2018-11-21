using System;

namespace array
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];

            for (int i=0; i<numbers.Length; ++i) {
                numbers[i]=rnd.Next(1,100);
            }
            Array.Sort(numbers);
            for (int k=0; k<numbers.Length; ++k) {
                Console.WriteLine(numbers[k]);
            }
            int n = 2;
            int result = HowManyCouples(numbers, n);
            Console.WriteLine("Il numero "+ n + " è la somma di " + result + " numeri nell'array.");
        }

        public static int HowManyCouples(int[] array, int n) {
            int sum=0, count=0;
            for(int i=0; i<array.Length; ++i) {
                for (int j=1; j<array.Length; ++j) {
                    sum=array[i]+array[j];
                    if(sum==n) {
                        ++count;
                    }
                }
            }
            return count;
        }
    }
}
