public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] nums3=nums1.Concat(nums2).ToArray();
Array.Sort(nums3);
int len = nums3.Length;
double median;
if (len % 2 == 1)
{
    median = nums3[len / 2];

}
else
{
    median = (nums3[len / 2] + nums3[(len/2)-1])/2.00;

}
return median;
    }
}