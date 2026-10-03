class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int n=prices.size();
        int MP=0;//Maxprofit
        int bestbuy=prices[0];//Bestbuying day
        for (int i=1;i<n;i++)
        {
            if(prices[i]>bestbuy){
                MP=max(MP,prices[i]-bestbuy);

            }
        bestbuy=min(bestbuy,prices[i]);
        }
        return MP;
        
    }
};