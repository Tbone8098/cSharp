// TWO ALGOS WOOOOOO

// Algo 1 - Drop It
// Write a function that takes 2 parameters: an array, and a callback function.
// The goal is to make it so this function will remove elements from the array (starting at index zero)
// for every element that the callback function returns true for.

function dropIt(arr, callback) {
    while (arr.length > 0 && callback(arr[0]) == false) {
        arr.splice(0, 1)
    }
    return arr
}
var arr = [3, 2, 5, 1, 4, 7, 3, 4]
var call = x => x == 7
// console.log(dropIt(arr, call));

// Algo 2 - Can it become a palindrome?

// Write a function that takes a string as a parameter, and determines whether
// or not the characters of the string could potentially be rearranged to create a
// palindrome.

// EXAMPLE:
// canPali("toccata") would return true, because the letters could be rearranged to
// make it "tacocat", but canPali("green") would return false because there can't be
// a palindrome from that.
function canPali(string) {
    let letterCount = {}
    for (i = 0; i < string.length; i++) {
        !(string[i] in letterCount) ? letterCount[string[i]] = 1 : letterCount[string[i]] += 1
    }
    return Object.keys(letterCount).filter(x => letterCount[x] % 2 == 1).length <= 1
}

console.log(canPali("tyler"));
console.log(canPali("toccata"));
console.log(canPali("aabbc"));