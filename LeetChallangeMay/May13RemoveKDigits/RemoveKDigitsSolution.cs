using System.Text;

namespace LeetChallengeMay.May13RemoveKDigits
{
    public class RemoveKDigitsSolution
    {
        public string RemoveKdigits(string num, int k)
        {
            if (num.Length == k)
                return "0";

            StringBuilder numberBuilder = new StringBuilder(num);

            for (int i = 0; i < k; i++)
            {
                int indexOfNumberToBeRemoved = 0;
                while (indexOfNumberToBeRemoved < numberBuilder.Length - 1
                       && numberBuilder[indexOfNumberToBeRemoved] <= numberBuilder[indexOfNumberToBeRemoved + 1])
                {
                    indexOfNumberToBeRemoved++;
                }
                numberBuilder.Remove(indexOfNumberToBeRemoved, 1);
            }

            while (numberBuilder.Length > 1 && numberBuilder[0] == '0')
                numberBuilder.Remove(0, 1);

            if (numberBuilder.Length == 0)
            {
                return "0";
            }

            return numberBuilder.ToString();
        }
    }
}