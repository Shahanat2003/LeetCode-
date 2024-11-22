public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        List<int> ind=new List<int>();
        ind.Add(Array.IndexOf(nums,target));
        ind.Add(Array.LastIndexOf(nums,target));
        int[] index=ind.ToArray();
        return index;
        
    }
}