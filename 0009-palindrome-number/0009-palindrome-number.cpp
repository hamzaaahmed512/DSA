class Solution {
public:
    bool isPalindrome(int x) {
        int orignal=x;
        long reversed=0;
        while(x>0)
        { 
        int digit=x%10;
        reversed = (reversed*10) + digit;
        x/=10;
        }
        if(orignal==reversed)
        {
            return true;
        }
        return false;
        
    }
};