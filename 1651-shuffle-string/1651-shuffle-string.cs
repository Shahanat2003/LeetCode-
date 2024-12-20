public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] str=new char[s.Length];
        for(int i=0;i<s.Length;i++){
            str[indices[i]]=s[i];
        }
        return new string(str);
    }
}