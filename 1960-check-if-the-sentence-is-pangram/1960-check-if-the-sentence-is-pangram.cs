public class Solution {
    public bool CheckIfPangram(string sentence) {
        HashSet<char> hashh=new HashSet<char>();
        for(int i=0;i<sentence.Length;i++){
            hashh.Add(sentence[i]);
        }
        if(hashh.Count==26){
            return true;
        }
        else{
            return false;
        }

    }
}