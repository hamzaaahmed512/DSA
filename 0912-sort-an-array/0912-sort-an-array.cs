using System.Collections.Generic;

public class Solution
{
    void merge(int[] nums, int st, int end, int mid)
    {
        int i = st;
        int j = mid + 1;
        List<int> temp = new List<int>();
        while (i <= mid && j <= end)
        {
            if (nums[i] <= nums[j])
            {
                temp.Add(nums[i]);
                i++;
            }
            else
            {
                temp.Add(nums[j]);
                j++;
            }
        }
        while (i <= mid)
        {
            temp.Add(nums[i]);
            i++;
        }
        while (j <= end)
        {
            temp.Add(nums[j]);
            j++;
        }
        for (int k = 0; k < temp.Count; k++)
        {
            nums[st + k] = temp[k];
        }
    }
    void Sort(int[] nums, int st, int end)
    {
        if (st >= end)
        {
            return;
        }
        int mid = st + (end - st) / 2;
        Sort(nums, st, mid);
        Sort(nums, mid + 1, end);
        merge(nums, st, end, mid);
    }
    public int[] SortArray(int[] nums)
    {
        Sort(nums, 0, nums.Length - 1);
        return nums;
    }

}