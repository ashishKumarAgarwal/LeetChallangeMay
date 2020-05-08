namespace LeetChallengeMay.May7CousinsInBinaryTree
{
    public class CousinsInBinaryTreeSolution
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            int depthOfx = 0;
            int depthOfy = 0;
            var parentOfx = GetParentAndAssignDepth(x, ref depthOfx, root, root);
            var parentOfy = GetParentAndAssignDepth(y, ref depthOfy, root, root);
            if (parentOfx.val != parentOfy.val)
            {
                return depthOfx == depthOfy;
            }
            return false;
        }

        private TreeNode GetParentAndAssignDepth(int valueToBeFound, ref int depth, TreeNode current, TreeNode parent)
        {
            if (current.val != parent.val)
            {
                depth++;
            }

            if (current.val == valueToBeFound)
            {
                return parent;
            }

            if (current.left != null)
            {
                var currentDepth = depth;
                var parentNode = GetParentAndAssignDepth(valueToBeFound, ref depth, current.left, current);
                if (parentNode != null)
                {
                    return parentNode;
                }

                depth = currentDepth;
            }
            if (current.right != null)
            {
                var currentDepth = depth;
                var parentNode = GetParentAndAssignDepth(valueToBeFound, ref depth, current.right, current);
                if (parentNode != null)
                {
                    return parentNode;
                }
                depth = currentDepth;
            }
            return null;
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