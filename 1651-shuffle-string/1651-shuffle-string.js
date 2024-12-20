/**
 * @param {string} s
 * @param {number[]} indices
 * @return {string}
 */
var restoreString = function(s, indices) {
    var str=[];
    for(i=0;i<=s.length;i++){
        str[indices[i]]=s[i]
    }
    return(str.join(""))
};