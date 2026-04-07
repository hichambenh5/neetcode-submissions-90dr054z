public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
       int res=0;
        int max=0;
        int start=0;
        
       
        for(int i=0;i<s.Length;i++){
            if(dict.ContainsKey(s[i])){
           dict[s[i]]++;
            }else{
                dict[s[i]]=1;
            }
            max=Math.Max(max,dict[s[i]]);
            while((i-start+1)-max>k){
                dict[s[start]]--;
                start++;
            }
            res=Math.Max(res,i-start+1);
            

            

            

        }


     return res;
    }
}
