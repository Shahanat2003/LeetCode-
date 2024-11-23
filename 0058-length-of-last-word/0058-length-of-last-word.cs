public class Solution {
    public int LengthOfLastWord(string s) {
    string[] arr=s.Trim().Split(" ");
   int len=arr[arr.Length-1].Length;
return len;
    }
}