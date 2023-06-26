namespace WordLib
{
    public class Worder
    {
        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new ArgumentException("Word cannot be null or empty.");

            string palindrome = new string(word.ToLower().ToCharArray().Reverse().ToArray());

            if (word.Equals(palindrome))
            {
                return true;
            }

            return false;

        }
        public static int CountLetters(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return 0;
            }

            int letterCount = 0;

            foreach (char l in word)
            {
                if (char.IsLetter(l))
                {
                    letterCount++;
                }
            }

            return letterCount;
        }

    }
}