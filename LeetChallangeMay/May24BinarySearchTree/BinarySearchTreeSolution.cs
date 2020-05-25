namespace LeetChallengeMay.May25UncrossedLines
{
    public class BinarySearchTreeSolution
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            //8, 5, 1, 7, 10, 12
            TreeNode rootNode = new TreeNode(preorder[0]);
            for (int i = 1; i < preorder.Length; i++)
            {
                AssignNode(preorder[i], rootNode);
            }
            return rootNode;
        }

        private static void AssignNode(int preorder, TreeNode rootNode)
        {
            if (rootNode.val > preorder)
            {
                if (rootNode.left != null)
                {
                    AssignNode(preorder, rootNode.left);
                }
                else
                {
                    rootNode.left = new TreeNode(preorder);
                }
            }
            else
            {
                if (rootNode.right != null)
                {
                    AssignNode(preorder, rootNode.right);
                }
                else
                {
                    rootNode.right = new TreeNode(preorder);
                }
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}