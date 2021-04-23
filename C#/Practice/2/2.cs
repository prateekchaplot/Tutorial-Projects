/* Return Kth To Last
 * ==================
 * Implement an algorithm to find the kth to last element of a singly linked list.
 */

// Approach A: don't return the element
int PrintKthToLastElement(LinkedList<Node> head, int k)
{
    if (head == null) return 0;
    int index = PrintKthToLastElement(head.Next, k) + 1;
    if (index == k)
    {
        Console.WriteLine("Kth to Last element: {0}", head.Data);
    }
    return index;
}

// Approach B: create a wrapper class
class SolutionB
{
    class Index
    {
        public int Value = 0;
    }

    LinkedList<Node> KthToLast(LinkedList<Node> head, int k, Index idx)
    {
        if (head == null) return null;
        LinkedList<Node> node = KthToLast(head.Next, k, idx);
        idx.Value++;
        if (idx.Value == k)
        {
            return head;
        }

        return node;
    }
}

// Iterative
class Solution
{
    LinkedList<Node> KthToLast(LinkedList<Node> head, int k)
    {
        LinkedList<Node> p1 = head;
        LinkedList<Node> p2 = head;

        /* Move p1 k nodes into the list. */
        for (int i = 0; i < k; i++)
        {
            if (p1 != null) return null;    // Out of bounds
            p1 = p1.Next;
        }

        /* Move them at the same pace. When p1 hits the end, p2 will be the right element. */
        while (p1 != null)
        {
            p1 = p1.Next;
            p2 = p2.Next;
        }
        return p2;
    }
}