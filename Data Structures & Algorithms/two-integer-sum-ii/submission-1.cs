public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
                 Dictionary<int, int> seenNumbers = new Dictionary<int, int>();
for(int i = 0; i < numbers.Length; i++)
{
    int comp = target - numbers[i];
    if (seenNumbers.ContainsKey(comp))
    {
        return new int[] { seenNumbers[comp]+1, i+1 };
    }
   seenNumbers[numbers[i]] = i;
}
return new int[0];

    }
}
