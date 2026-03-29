public class Solution {
    public int Trap(int[] height) {
        int left=1;
        int right=height.Length-2;
        int leftmax=height[0];
        int rightmax=height[height.Length-1];
        int result=0;
        while(left<=right){
            if(leftmax<rightmax){
                if(height[left]>=leftmax){
                    leftmax=height[left];
                }else{
                    result+=leftmax-height[left];
                   

                }
                left++;
            }else{
                if(height[right]>=rightmax){
                    rightmax=height[right];
                }else{
                    result+=rightmax-height[right];
                }
                right--;

            }

        }
        return result;
    }
}
