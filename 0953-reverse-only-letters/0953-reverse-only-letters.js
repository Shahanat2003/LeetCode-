/**
 * @param {string} s
 * @return {string}
 */
 function reverseOnlyLetters(s){
            s1= s.replace(/[^a-zA-Z]/g, '').split("").reverse().join("")
            indx=0
            result=s.split("")
            for(i=0;i<s.length;i++){
                if(s[i].match(/[a-z]/i)){
                    result[i]=s1[indx]
                    indx++
                }     
            }
            a=result.join("")
           return a
             }
        console.log(reverseOnlyLetters("Test1ng-Leet=code-Q!"))