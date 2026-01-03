public class Solution 
{
    public List<List<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0 ) break;
            if(i > 0 && nums[i] == nums[i - 1]) continue;
            int head = i+1;
            int tail = nums.Length-1;
            while (head < tail)
            {
                int sum = nums[i] + nums[head] + nums[tail];
                if(sum > 0)
                {
                    tail--;
                }
                else if (sum < 0)
                {
                    head++;
                }
                else
                {
                    result.Add(new List<int> { nums[i], nums[head], nums[tail] });
                    head++;
                    tail--;
                    while (head < tail && nums[head] == nums[head - 1])
                    {
                        head++;
                    }
                }
            }
        }
        
        
        return result;
    }
}