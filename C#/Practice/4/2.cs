/* Minimal Tree
 * ============
 * Given a sorted (increasing order) array with unique integer elements, write an algorithm to create 
 * binary search tree with minimal height.
 */

class Solution
{
    TreeNode CreateMinimalBST(int[] array)
    {
        return CreateMinimalBST(array, 0, array.Length - 1);
    }

    TreeNode CreateMinimalBST(int[] array, int start, int end)
    {
        if (end < start) return null;
        int mid = (start + end) / 2;
        TreeNode n = new TreeNode(array[mid]);
        n.Left = CreateMinimalBST(array, start, mid);
        n.Right = CreateMinimalBST(array, mid, end);
        return n;
    }
}