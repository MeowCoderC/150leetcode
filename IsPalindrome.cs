public class Solution {
    public bool IsPalindrome(string s)
    {
        var sb = new StringBuilder(s.Length);
        foreach (var c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                sb.Append(char.ToLower(c));
            }
        }
        
        string newStr = sb.ToString();
        
        return newStr == new string(newStr.Reverse().ToArray());
    }
    
    // Two Pointers
    public bool IsPalindrome(string s)
    {
        int head = 0;
        int tail = s.Length - 1;

        while (head < tail)
        {
            while (head < tail && !char.IsLetterOrDigit(s[head]))
            {
                head++;
            }

            while (tail > head && !char.IsLetterOrDigit(s[tail]))
            {
                tail--;
            }

            if (char.ToLower(s[head]) != char.ToLower(s[tail]))
            {
                return false;
            }
            head++;
            tail--;
        }
	    
        return true;
    }
}