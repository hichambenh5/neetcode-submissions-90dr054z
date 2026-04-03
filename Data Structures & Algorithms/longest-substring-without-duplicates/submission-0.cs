public class Solution {
    public int LengthOfLongestSubstring(string s) {
Dictionary<char, int> dict = new Dictionary<char, int>();
int maxlength=0;
int start=0;
for(int i=0;i<s.Length;i++){
   if(dict.ContainsKey(s[i])){
    start=Math.Max(start,dict[s[i]]+1);
   }
   dict[s[i]]=i;
   maxlength=Math.Max(maxlength,i-start+1);
}
return maxlength;
    }
}
