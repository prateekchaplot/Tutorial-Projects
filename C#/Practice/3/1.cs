/* Three in One
 * ============
 * Describe how you could use a single array to implement three stacks.
*/

// Solution 1: Fixed division
class FixedMultiStack
{
    private int _numberOfStacks = 3;
    private int _stackCapacity;
    private int[] _values;
    private int[] _sizes;

    public FixedMultiStack(int stackSize)
    {
        _stackCapacity = stackSize;
        _values = new int[_numberOfStacks * _stackCapacity];
        _sizes = new int[_numberOfStacks];
    }

    public void Push(int stackNum, int value)
    {
        if (IsFull(stackNum)) throw new System.Exception("Full stack.");

        _sizes[stackNum]++;
        _values[IndexOfTop(stackNum)] = value;
    }

    public int Pop(int stackNum)
    {
        if (IsEmpty(stackNum)) throw new System.Exception("Empty stack.");

        int topIndex = IndexOfTop(stackNum);
        int value = _values[topIndex];
        _values[topIndex] = 0;
        _sizes[stackNum]--;
        return value;
    }

    public int Peek(int stackNum)
    {
        if (IsEmpty(stackNum)) throw new System.Exception("Empty stack.");
        return _values[IndexOfTop(stackNum)];
    }

    private bool IsFull(int stackNum)
    {
        return _sizes[stackNum] == _stackCapacity;
    }

    private bool IsEmpty(int stackNum)
    {
        return _sizes[stackNum] == 0;
    }

    private int IndexOfTop(int stackNum)
    {
        int offset = stackNum * _stackCapacity;
        int size = _sizes[stackNum];
        return offset + size - 1;
    }
}