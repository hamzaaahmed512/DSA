class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        int maxsum=INT_MIN;
        int currentsum=0;
        for (int val : nums)
        {
            currentsum+=val;
            maxsum=max(maxsum,currentsum);
            if(currentsum<0)
            {
                currentsum=0;
            }
        }
        return maxsum;
    }
    
};