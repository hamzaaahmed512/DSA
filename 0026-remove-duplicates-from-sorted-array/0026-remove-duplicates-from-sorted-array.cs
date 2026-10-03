public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i =0;
        int count =1;
        for (int j=1; j< nums.Length;j++)
        {
            if(nums[i]!=nums[j])
            {
                i++;
                nums[i]=nums[j];
                count++;
            }
        }
        return count;
    }
}