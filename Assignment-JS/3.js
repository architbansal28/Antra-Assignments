// Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’, otherwise false. Make sure
// '@' must come before '.' and there must be some characters between '@' and '.'
// The function must be case-insensitive

function checkEmailId(str) {
    str = str.toLowerCase();

    let atPosition = str.indexOf('@');
    let dotPosition = str.indexOf('.');

    if (atPosition > -1 && dotPosition > atPosition + 1) {
        return true;
    } else {
        return false;
    }
}

console.log(checkEmailId("example@example.com")); // true
console.log(checkEmailId("example.com@example")); // false
console.log(checkEmailId("example@examplecom"));  // false
console.log(checkEmailId("EXAMPLE@EXAMPLE.COM")); // true
console.log(checkEmailId("example@.com"));        // false
console.log(checkEmailId("example@com."));        // false