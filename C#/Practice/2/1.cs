/* Remove Dups
 * ===========
 * Write code to remove duplicates from an unsorted linked list.
 */

// Solution 1
void RemoveDups(LinkedList<Node> head)
{
    HashSet<int> set = new HashSet<int>();
    LinkedList<Node> current = head;
    LinkedList<Node> previous = null;
    while (current != null)
    {
        if (set.Contains(current.Data))
        {
            previous.Next = current.Next;
        }
        else
        {
            set.Add(current.Data);
            previous = previous.Next;
        }
        current = current.Next;
    }
}

void DeleteDups(LinkedList<Node> head)
{
    LinkedList<Node> p1 = head;
    while (p1 != null)
    {
        LinkedList<Node> p2 = p1;
        while (p2.Next != null)
        {
            if (p2.Next.Data == p1.Data) p2.Next = p2.Next.Next;
            else p2 = p2.Next;
        }
        p1 = p1.Next;
    }
}