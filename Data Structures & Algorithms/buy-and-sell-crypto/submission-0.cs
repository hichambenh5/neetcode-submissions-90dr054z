public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy=prices[0];
        int maxsell=0;
        int result=0;
        for(int i=0;i<prices.Length;i++){
           minBuy=Math.Min(minBuy,prices[i]);
           maxsell=prices[i]-minBuy;
           result=Math.Max(result,maxsell);


           
            
        }
        
       
        return result;
    }
}
