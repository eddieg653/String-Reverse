using System;

namespace String_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word, changeword;
            Word = "Race car";
            Word = Word.ToLower().Replace(" ", "");
            char[] changedWord = Word.ToCharArray();
            Array.Reverse(changedWord);
            changeword = new string(changedWord);
            bool b = Word.Equals(changeword, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine($"{Word} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{Word} is not a Palindrome");
            }
        }
    }
}
