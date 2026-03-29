public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new List<List<int>>();

        // 1. حماية أولية: إذا كانت المصفوفة أقل من 3 عناصر لا يمكن تكوين ثلاثية
        if (nums == null || nums.Length < 3) return result;

        // 2. الترتيب: أساس خوارزمية المؤشرين ومنع التكرار
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++) {
            
            // 3. تحسين أداء (Optimization): إذا كان أصغر رقم أكبر من صفر، فالمجموع لن يكون صفراً أبداً
            if (nums[i] > 0) break;

            // 4. منع تكرار المجموعة بناءً على الرقم الأول (المثبت)
            // نتحقق من (i > 0) لنتجنب خطأ الـ IndexOutOfBounds عند مقارنة i-1
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0) {
                    // وجدنا ثلاثية صحيحة
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // 5. منع تكرار المجموعة بناءً على الرقم الثاني والثالث
                    // نقفز فوق الأرقام المتشابهة لـ left و right
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    // تحريك المؤشرات للرقم الجديد المختلف
                    left++;
                    right--;
                } 
                else if (sum > 0) {
                    // المجموع كبير، نحتاج لتقليله بتحريك المؤشر الأيمن للخلف
                    right--;
                } 
                else {
                    // المجموع صغير، نحتاج لزيادته بتحريك المؤشر الأيسر للأمام
                    left++;
                }
            }
        }

        return result;
    }
}