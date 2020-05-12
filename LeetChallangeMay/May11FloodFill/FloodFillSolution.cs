namespace LeetChallengeMay.May11FloodFill
{
    public class FloodFillSolution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] != newColor)
            {
                Fill(image, sr, sc, image[sr][sc], newColor);
            }

            return image;
        }

        private void Fill(int[][] image, int i, int j, int color, int newColor)
        {
            if (i < 0 || i >= image.Length || j < 0 || j >= image[i].Length || image[i][j] != color)
            {
                return;
            }

            image[i][j] = newColor;
            Fill(image, i + 1, j, color, newColor);
            Fill(image, i - 1, j, color, newColor);
            Fill(image, i, j + 1, color, newColor);
            Fill(image, i, j - 1, color, newColor);
        }

        // My initial solution

        //private int[][] GetNewImage(int[][] image, int sr, int sc, int newColor,int reference)
        //{
        //    if (image[sr][sc] == newColor)
        //    {
        //        return image;
        //    }

        //    if (image[sr][sc] == reference)
        //    {
        //        image[sr][sc] = newColor;

        //        //left
        //        if (!((sc - 1) < 0))
        //        {
        //            image = GetNewImage(image, sr, sc - 1, newColor, reference);
        //        }

        //        //right
        //        if (!((sc + 1) > (image.Length - 1)))
        //        {
        //            image = GetNewImage(image, sr, sc + 1, newColor,reference);
        //        }

        //        //top
        //        if (!((sr - 1) < 0))
        //        {
        //            image = GetNewImage(image, sr - 1, sc, newColor,reference);
        //        }

        //        //bottom
        //        if (!((sr + 1) > (image.Length - 1)))
        //        {
        //            image = GetNewImage(image, sr + 1, sc, newColor,reference);
        //        }
        //    }

        //    return image;
        //}
    }
}