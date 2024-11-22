public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==target){
                return i;
            }
            else{
                List<int> list=nums.ToList();
                list.Add(target);
                nums=list.ToArray();
                Array.Sort(nums);
                return Array.IndexOf(nums,target);

            }
            
          
        }
        return 1;
       
        
    }
}