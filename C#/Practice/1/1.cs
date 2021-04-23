/* Is Unique
 * =========
 * Implement an algorithm to determine if a string has all unique characters. What if you cannot use
 * additional data structure.
 */

class Solution1
{
    // Assumption: ASCII character set.
    bool IsUnique(string str)
    {
        if (str.Length > 128) return false;
        bool[] char_set = new bool[128];
        foreach (char c in str)
        {
            if (char_set[c] == true) return false;
            char_set[c] = true;
        }
        return true;
    }
}

class Solution2
{
    // Assumption: values lie between 'a' through 'z'.
    bool IsUnique(string str)
    {
        int checker = 0;
        foreach (char c in str)
        {
            int value = c - 'a';
            if ((checker & (1 << value)) > 0)
            {
                return false;
            }
            checker |= (1 << value);
        }

        return true;
    }
}