// TWO ALGOS

// Algo 1
// Honorifics -> write a function that takes a string (something like "Mr", "Mrs", "Sir"),
// and an array of strings that make a full name, and returns the honorific version
// EXAMPLE: honorific("Mr", ["John", "Jacob", "Jingleheimer", "Schmidt"]) returns 
// "Mr John Jacob Jingleheimer Schmidt"
function honorific(honorofic, fullName) {
    return honorofic + ' ' + fullName.join(' ');
}

// console.log(honorific("Mr", ["John", "Jacob", "Jingleheimer", "Schmidt"]));

// Algo 2
// Compare Version Numbers -> Write a function that takes two strings, version1 and version2, and 
// determine which version number is later. 

// EXAMPLE: compareVersionNumbers("1.0.1", "1.1") should return "1.1" since v1.1 is greater than v1.0.1
function compareVersionNumbers(version1, version2) {
    let num1 = version1.split('.')
    let num2 = version2.split('.')

    // compare num1[i] with num2[i] which ever is bigger return that number.
    // if numbers are the same then continue to the next number
    let i = 0
    while (i <= version1.length - 1 && i <= version2.length - 1) {
        if (num1[i] > num2[i]) {
            return version1
        } else if (num2[i] > num1[i]) {
            return version2
        } else {
            i++
        }
    }
    // came out of the loop because they are equal and cannot proceed with comparing 
    // because the other one has less length
    if (version1.length > version2.length) {
        return version1;
    }
    else if (version2.length > version1.length) { return version2 }
    else return [];

}

// console.log(compareVersionNumbers("1.0.1", "1.1"));
console.log(compareVersionNumbers("1.1.1", "1.1"));
console.log(compareVersionNumbers("0.1.1", "1.1"));
console.log(compareVersionNumbers("1.1", "1.1.2"));
console.log(compareVersionNumbers("2", "1.1.2"));
console.log(compareVersionNumbers("2", "3"));
console.log(compareVersionNumbers("2.10.1", "2.1"));