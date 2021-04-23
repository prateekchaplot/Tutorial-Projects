/* Stack Min
 * =========
 * How would you design a stack which, in addition to push and pop, has a function min which returns
 * the minimum element? Push, pop and min should all operate in O(1) time.
*/

// Solution 1
public class StackWithMin : Stack<NodeWithMin>
{
    public void Push(int value)
    {
        int newMin = Math.Min(value, Min());
        super.Push(new NodeWithMin(value, newMin));
    }

    public int Min()
    {
        if (this.IsEmpty()) return Int16.MaxValue;  // Error value
        return Peek().Min;
    }

    class NodeWithMin
    {
        public int Value { get; set; }
        public int Min { get; set; }

        public NodeWithMin(int value, int min)
        {
            Value = value;
            Min = min;
        }
    }
}

// Solution 2
public class StackWithMin2 : Stack<int>
{
    private Stack<int> _stack;

    public StackWithMin2()
    {
        _stack = new Stack<int>();
    }

    public void Push(int value)
    {
        if (value < Min()) _stack.Push(value);
        super.Push(value);
    }

    public int Pop()
    {
        int value = super.Pop();
        if (value == Min()) _stack.Pop();
        return value;
    }

    public int Min()
    {
        if (_stack.IsEmpty()) return Int16.MaxValue;    // Error value
        return _stack.Peek();
    }
}