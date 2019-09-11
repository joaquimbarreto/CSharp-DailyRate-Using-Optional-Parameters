using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double fee = calculateFee(500.0, 3);
            Console.WriteLine($"Fee is  {fee}");
        }
        private double calculateFee(double dailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("calculateFee using two optimal parameters");
            return dailyRate * noOfDays;
        }
        private double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("calculateFee using two optimal parameters");
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }
    }
}
