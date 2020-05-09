namespace LeetChallengeMay.May8CheckIfInStraightLine
{
    public class CheckIfInStraightLineSolution
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            var coordinatesLength = coordinates.Length;
            if (coordinatesLength.Equals(2))
                return true;

            var baseSlope = GetSlope(coordinates[0], coordinates[1]);
            for (int index = 1; index < coordinatesLength - 2; index++)
            {
                if (!GetSlope(coordinates[index], coordinates[index + 1]).Equals(baseSlope))
                {
                    return false;
                }
            }
            return true;
        }

        private float GetSlope(int[] x, int[] y)
        {
            if (y[0] - x[0] == 0)
            {
                return 0;
            }
            return ((float)(y[1] - x[1]) / (y[0] - x[0]));
        }
    }
}