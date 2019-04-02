using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    

    class Program
    {
        public static void Mean(out double mean, params double[] arr)
        {
            double sum = 0;
            for(int i = 0; i < arr.Length; i++)
                sum+= arr[i];
            sum /= 5;
            mean = sum;
        }

        static void Main(string[] args)
        {
            double[] arr = new double[] { 1, 2, 3, 4 };
            double mean = 0;
            Mean(out mean, arr);
            Console.WriteLine(mean);

        }
    }
}
