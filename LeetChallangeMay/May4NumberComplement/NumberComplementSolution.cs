using System;

namespace LeetChallengeMay.May4NumberComplement
{
    public class NumberComplementSolution
    {
        public int FindComplement(int num)
        {
            string binaryRepresentation = Convert.ToString(num, 2);
            char[] reverseRepresentation = new char[binaryRepresentation.Length];
            for (int index = 0; index < binaryRepresentation.Length; index++)
            {
                reverseRepresentation[index] = binaryRepresentation[index] == '1' ? '0' : '1';
            }

            var reversedNumber = Convert.ToInt32(new String(reverseRepresentation), 2);
            return reversedNumber;
        }
    }
}