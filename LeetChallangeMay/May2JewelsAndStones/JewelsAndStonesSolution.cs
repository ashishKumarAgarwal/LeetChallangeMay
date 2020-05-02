namespace LeetChallengeMay.May2JewelsAndStones
{
   public class JewelsAndStonesSolution
    {
        public int NumJewelsInStones(string J, string S)
        {

            int numberOfJewels = 0;
            for (int index = 0; index < S.Length; index++)
            {
                if (J.Contains(S[index]))
                {
                    numberOfJewels++;
                }
            }
            return numberOfJewels;
        }
    }


    
}
