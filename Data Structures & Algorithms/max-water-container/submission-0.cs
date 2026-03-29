public class Solution {
    public int MaxArea(int[] heights) {
        int max=0;
        int left=0;
        int right=heights.Length-1;
        int minheights=0;
         int dictance=0;
        int currentArea=0;
        while(left<right){
            minheights=Math.Min(heights[left],heights[right]);
            dictance=right-left;
            currentArea=minheights*dictance;
            max=Math.Max(max,currentArea);
            if(heights[left]>heights[right]){
                right--;
            }else{
                left++;
            }
            
        }
        return max; 
    }
}
