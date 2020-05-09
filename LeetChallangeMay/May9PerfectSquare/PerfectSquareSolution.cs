using System;

namespace LeetChallengeMay.May9PerfectSquare
{
    public class PerfectSquareSolution
    {
        public bool IsPerfectSquare(int num)
        {
            if (num == 1)
                return true;
            var squareRoot = Math.Sqrt(num);
            var diff = squareRoot - Math.Floor(squareRoot);
            return ! (diff > 0);
        }
    }
}