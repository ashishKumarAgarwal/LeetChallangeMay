namespace LeetChallengeMay.May10FindTheTownJudge
{
    public class FindTheTownJudgeSolution
    {
        public int FindJudge(int N, int[][] trust)
        {


            /*
             * My original solution
             * if (N == 1)
                 return 1;

             Dictionary<int, List<int>> judgeTrustMapping = new Dictionary<int, List<int>>();

             foreach (var trustMapping in trust)
             {
                 if (judgeTrustMapping.ContainsKey(trustMapping[0]))
                 {
                     judgeTrustMapping[trustMapping[0]].Add(trustMapping[1]);
                 }
                 else
                 {
                     judgeTrustMapping.Add(trustMapping[0], new List<int> { trustMapping[1] });
                 }
             }

             var possibleJudges = judgeTrustMapping.FirstOrDefault().Value;
             var possibleJudgesCount = 0;
             var possibleJudge = -1;
             for (int index = 0; index < possibleJudges.Count; index++)
             {
                 var isTrustPresentForAll = true;
                 foreach (var trustMapping in judgeTrustMapping)
                 {
                     if (!trustMapping.Value.Contains(possibleJudges[index]))
                     {
                         isTrustPresentForAll = false;
                     }
                 }
                 if (isTrustPresentForAll)
                 {
                     if (!judgeTrustMapping.ContainsKey(possibleJudges[index]))
                     {
                         possibleJudge = possibleJudges[index];
                         possibleJudgesCount++;
                     }

                 }
             }

             return possibleJudgesCount == 1 ? possibleJudge : -1; */


            //After refering better solutions
            if (N == 1)
                return 1;
            int[] numberOfTrustInfo = new int[N + 1];
            for (int i = 0; i < trust.Length; i++)
            {
                numberOfTrustInfo[trust[i][0]]--;
                numberOfTrustInfo[trust[i][1]]++;
            }
            for (int i = 1; i <= N; i++)
            {
                if (numberOfTrustInfo[i] == N - 1)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}