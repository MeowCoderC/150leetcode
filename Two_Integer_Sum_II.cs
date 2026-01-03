public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int head = 0;
        int tail = numbers.Length - 1;

        while (head < tail)
        {
            int curSum = numbers[head] + numbers[tail];

            if (curSum > target)
            {
                tail--;
            }
            else if (curSum < target)
            {
                head++;
            }
            else
            {
                return new[] { head+1, tail+1 };
            }
        }
        
        return new [] { head, tail };
    }
}