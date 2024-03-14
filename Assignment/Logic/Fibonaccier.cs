using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Logic
{
    public class Fibonaccier : IFibonaccier
    {
        public async Task<int> GetFibonacciNumberAsync(int fibonacciNumber)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(fibonacciNumber);

            await Task.Delay(new Random().Next(10, 1000));
            if (fibonacciNumber < 2)
            {
                return fibonacciNumber;
            }
            return await GetFibonacciNumberAsync(fibonacciNumber - 1) + await GetFibonacciNumberAsync(fibonacciNumber - 2);
        }
    }
}
