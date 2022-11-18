//functions
function Add(a, b) {
    var result = a + b; //local variable
    console.log("Addition of ".concat(a, " and ").concat(b, " :").concat(result));
}
//calling function
Add(12, 23);
//function with return value
function Greet(name) {
    var msg = 'Hello ' + name;
    return msg;
}
var result = Greet('Sourab');
console.log(result);
function Sqaure(no) {
    var result = no * no;
    return result;
}
console.log("Square of 5 is ".concat(Sqaure(5)));
