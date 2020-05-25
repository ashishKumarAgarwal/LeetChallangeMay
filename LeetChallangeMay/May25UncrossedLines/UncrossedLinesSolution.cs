using System;

namespace LeetChallengeMay.May25UncrossedLines
{
    public class UncrossedLinesSolution
    {
        public int MaxUncrossedLines(int[] A, int[] B)
        {
        
            int m = A.Length;
            int n = B.Length;
            int[,] arr = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (A[i - 1] == B[j - 1])
                    {
                        arr[i, j] = arr[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        arr[i, j] = Math.Max(arr[i - 1, j], arr[i, j - 1]);
                    }
                }
            }
            return arr[m, n];

            //int baseA = GetMaxLines(A, B);
            //int baseB = GetMaxLines(B, A);

            //return baseA>baseB?baseA:baseB;
        }

        //My Previous unsuccessful attempt
        //private static int GetMaxLines(int[] A, int[] B)
        //{
        //    List<int> visitedIndexes = new List<int>();
        //    var notVisitedIndex = 0;
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (i < B.Length)
        //        {
        //            for (int j = notVisitedIndex; j < B.Length; j++)
        //            {
        //                if (A[i] == B[j] && !visitedIndexes.Contains(notVisitedIndex))
        //                {
        //                    visitedIndexes.Add(j);
        //                    notVisitedIndex = j + 1;
        //                    break;
        //                }
        //            }
        //        }
        //    }

        //    return visitedIndexes.Count;
        //}
    }
}