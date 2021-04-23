/* Insertion
 * =========
 * You are given two 32-bit numbers, N and M, and two bit position, i and j. Write a method to insert M into N
 * such that M starts at bit j and ends at bit i.
 */

int UpdateBits(int n, int m, int i, int j)
{
    /* Create mask to clear bits i through j in n. */
    // 1s before position j, then 0s.
    int allOnes = ~0;
    int left = allOnes << (j + 1);

    // 1s after postion i.
    int right = ((1 << i) - 1);

    // All 1s, except for 0s between i and j.
    int mask = left | right;

    // Clear bits j through i then put m in there.
    int n_cleared = n & mask;
    int m_shifted = m << i;

    return n_cleared | m_shifted;
}