/* Binary to String
 * ================
 * Given a real number between 0 and 1 (eg., 0.72) that is passed in as a double, print the binary
 * representation. If the number cannot be represented accurately in binary with at most 32 characters, print
 * "ERROR".
 */

class Solution2A
{
    string PrintBinary(double num)
    {
        if (num >= 1 || num <= 0) return "ERROR";

        StringBuilder binary = new StringBuilder();
        binary.Append(".");
        while (num > 0)
        {
            /* Setting a limit on length: 32 characters */
            if (binary.Length >= 32)
            {
                return "ERROR";
            }

            double r = num * 2;
            if (r >= 1)
            {
                binary.Append("1");
                num = r - 1;
            }
            else
            {
                binary.Append("0");
                num = r;
            }
        }
        return binary.ToString();
    }
}

class Solution2B
{
    string PrintBinary(double num)
    {
        if (num >= 1 || num <= 0) return "ERROR";

        StringBuilder binary = new StringBuilder();
        double frac = 0.5;
        binary.Append(".");
        while (num > 0)
        {
            /* Setting a limit on length: 32 characters */
            if (binary.Length > 32) return "ERROR";

            if (num >= frac)
            {
                binary.Append("1");
                num -= frac;
            }
            else
            {
                binary.Append("0");
            }
            frac /= 2;
        }
        return binary.ToString();
    }
}