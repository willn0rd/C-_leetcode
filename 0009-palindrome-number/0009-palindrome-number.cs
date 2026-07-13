public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;

        char[] n = x.ToString().ToCharArray();
        
        int i = 0, j = n.Length - 1;

        while(i < j){
            if(n[i] != n[j]) 
                return false;
            i++;
            j--;
        }

        return true;
    }
}