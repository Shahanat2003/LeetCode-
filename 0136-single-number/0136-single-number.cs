public class Solution {
    public int SingleNumber(int[] nums) {
      return nums.Where((val)=>Array.IndexOf(nums,val)==Array.LastIndexOf(nums,val)).First();
        
    }
}