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
        /// <summary>
        /// This method will return member of the Fibonacci sequence based on <paramref name="fibonacciNumber"/>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <param name="fibonacciNumber"></param>
        /// <returns>Integer member of the Fibonacci row</returns>
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
