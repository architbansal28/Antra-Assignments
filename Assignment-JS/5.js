// Let’s try 5 array operations.
// Create an array styles with items “James” and “Brennie”.
// Append “Robert” to the end.
// Replace the value in the middle by “Calvin”. Your code for finding the middle value should work for any
// arrays with odd length.
// Remove the first value of the array and show it.
// Prepend Rose and Regal to the array.
// James, Brennie
// James, Brennie, Robert
// James, Calvin, Robert
// Calvin, Robert
// Rose, Regal, Calvin, Robert

let styles = ["James", "Brennie"];
console.log(styles); // ["James", "Brennie"]

styles.push("Robert");
console.log(styles); // ["James", "Brennie", "Robert"]

let middleIndex = Math.floor(styles.length / 2);
styles[middleIndex] = "Calvin";
console.log(styles); // ["James", "Calvin", "Robert"]

let firstValue = styles.shift();
console.log(firstValue); // "James"
console.log(styles); // ["Calvin", "Robert"]

styles.unshift("Rose", "Regal");
console.log(styles); // ["Rose", "Regal", "Calvin", "Robert"]