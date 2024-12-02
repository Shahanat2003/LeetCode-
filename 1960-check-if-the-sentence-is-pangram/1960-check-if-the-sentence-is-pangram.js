/**
 * @param {string} sentence
 * @return {boolean}
 */
var checkIfPangram = function(sentence) {
    sentc=new Set();
    for(i=0;i<sentence.length;i++){
        sentc.add(sentence[i])
    }
    if(sentc.size===26){
        return true
    }
    else{
        return false
    }
};