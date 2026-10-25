public class Solution
{
    public void SortColors(int[] nums)
    {
        int count0 = 0;
        int count1 = 0;
        int count2 = 0;

        foreach (int i in nums)
        {
            if (i == 0) count0++;
            else if (i == 1) count1++;
            else count2++;
        }
        int index = 0;
        while (count0 > 0)
        {
            nums[index] = 0;
            index++;
            count0--;
        }
        while (count1 > 0)
        {
            nums[index] = 1;
            index++;
            count1--;
        }
        while (count2 > 0)
        {
            nums[index] = 2;
            index++;
            count2--;
        }
    }
}