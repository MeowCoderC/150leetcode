public class Solution 
{
    public int LongestConsecutive(int[] nums)
    {
        int          res     = 0;
        HashSet<int> hashSet = new HashSet<int>(nums);

        foreach (var num in nums)
        {
            if (!hashSet.Contains(num - 1))
            {
                int l = 1;
                while (hashSet.Contains(num + l))
                {
                    l++;
                }
                
                res = Math.Max(res,l);
            }
        }
        
        return res;
    }
}