public class Solution {
    public bool IsPalindrome(string s) {
       
        int j=s.Length-1;
        int i=0;
      
        while(i<j){
              while(i < j && !char.IsLetterOrDigit(s[i]))
    i++;

               while(i < j && !char.IsLetterOrDigit(s[j]))
    j--;
            if(i < j && char.ToLower(s[i]) != char.ToLower(s[j])){
                return false;
            }
            i++;
            j--;

 
        }
                

      
       return true;
    }
}
