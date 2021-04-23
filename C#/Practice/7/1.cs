/* Deck of Cards
 * =============
 * Design the data structure for a generic deck of cards. Explain how you would subclass the data structures
 * to implement blackjack.
 */

class Solution
{
    public enum Suit { Club = 0, Diamond = 1, Heart = 2, Spade = 3 };
    public static class SuitMethods
    {
        private int _value;
        private SuitMethods _suitMethods;
        
        private SuitMethods(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }

        public static SuitMethods GetSuitMethodsFromValue(int value)
        {
            if (_suitMethods == null) _suitMethods = new SuitMethods(value);
            return _suitMethods;
        }
    }

    public class Deck<T : Card>
    {
        
    }
}