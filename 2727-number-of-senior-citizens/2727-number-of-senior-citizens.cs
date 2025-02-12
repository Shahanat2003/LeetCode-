public class Solution {
    public int CountSeniors(string[] details) {
        int count=0;
        foreach(var item in details){
            int age =int.Parse(item.Substring(11,2));
            if(age>60)
                count++;
          
            
        }
         return count;
       
        
    }
}