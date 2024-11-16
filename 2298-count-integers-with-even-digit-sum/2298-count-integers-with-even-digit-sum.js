var countEven = function(num) {
    let count = 0;
    for (let i = 1; i <= num; i++) {
        let sum = 0, current = i;
        while (current > 0) {
            sum += current % 10;      
            current = Math.floor(current / 10); 
        }
        if (sum % 2 === 0) {
            count++; 
        }
    }
    return count;
};