public class Solution 
{
    public int Trap(int[] height)
    {
        int res  = 0;
        int head = 0;
        int tail = height.Length - 1;

        int maxHead = height[head];
        int maxTail = height[tail];

        while (head < tail)
        {
            if (maxHead < maxTail)
            {
                head++;
                maxHead =  Math.Max(maxHead, height[head]);
                res     += maxHead - height[head];
            }
            else 
            {
                tail--;
                maxTail =  Math.Max(maxTail, height[tail]);
                res     += maxTail - height[tail];
            }
            
        }
        
        return res;
    }
}