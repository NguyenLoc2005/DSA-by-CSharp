


class LongestSubstringWithoutRepeatingCharacters
{
    static void Main()
    {
        string s = "abcabcbb";

        int count = 0;

        for (int left = 0; left < s.Length; left++)
        {
            int maxLength = 0;
            HashSet<char> chars = new HashSet<char>();

            for (int right = left + 1; right < s.Length; right++)
            {

                if (chars.Contains(s[right]))
                {
                    break;
                }
                
                chars.Add(s[right]);
                maxLength++;
                
            }

            if(maxLength > count)
            {
                count = maxLength;
            }
            
       }

        Console.WriteLine("" + count);
    }
}