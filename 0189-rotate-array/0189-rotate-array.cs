public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        for(int i=0,j=nums.Length-1;i<j;i++,j--)
        {
            int temp=nums[i];
            nums[i]=nums[j];
            nums[j]=temp;
        }
        for(int i=0,j=k-1;i<j;i++,j--)
        {
            int temp=nums[i];
            nums[i]=nums[j];
            nums[j]=temp;
        }
        for(int i=k,j=nums.Length-1;i<j;i++,j--)
        {
            int temp=nums[i];
            nums[i]=nums[j];
            nums[j]=temp;
        }
    }
}