/* Check Permutation
 * =================
 * Given two strings, write a method to decide if one is a permuation of the other.
 */

// sort the strings.
class Solution1
{
    string Sort(string str)
    {
        char[] arr = str.ToCharArray();
        Arrays.Sort(arr);
        return new string(arr);
    }

    bool IsPermutation(string s, string t)
    {
        if (s.Length != t.Length) return false;
        return Sort(s).Equals(Sort(t));
    }
}

// check if the two strings have identical character counts.
class Solution2
{
    bool IsPermutation(string s, string t)
    {
        if (s.Length != t.Length) return false;

        int[] letters = new int[128];   // Assumption

        foreach (char c in s) letters[c]++;
        foreach (char c in t)
        {
            letters[c]--;
            if (letters[c] < 0) return false;
        }

        return true;
    }
}