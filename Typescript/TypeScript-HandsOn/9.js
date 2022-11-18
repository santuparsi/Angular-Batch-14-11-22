//arrays
var names = ['Rohan', 'Charan', 'Sunil', 'Dev'];
//assing value to array
names[4] = 'Karan';
//access a value
console.log(names[0]);
console.log(names[8]); //undefined
//fetch array values using for loop
for (var k = 0; k < names.length; k++) {
    console.log(names[k]);
}
//fetch array values using for of
for (var _i = 0, names_1 = names; _i < names_1.length; _i++) {
    var k = names_1[_i];
    console.log(k.toUpperCase());
}
