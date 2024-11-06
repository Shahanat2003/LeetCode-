public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int x=0;
        for(int i=0;i<nums.Length-1;i++){
            if(nums[i]!=nums[i+1]){
                nums[x]=nums[i];
                x+=1;
            }
        }
        nums[x]=nums[nums.Length-1];
        x+=1;
        return x;
        
    }
}