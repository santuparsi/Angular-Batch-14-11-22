var Calculate = /** @class */ (function () {
    function Calculate() {
    }
    Calculate.prototype.Add = function (a, b) {
        return a + b;
    };
    Calculate.prototype.Greet = function (name) {
        return 'Hello ' + name;
    };
    Calculate.prototype.GetFlowers = function () {
        return ["Rose", "Lilly", "Tulips"];
    };
    return Calculate;
}());
var calc = new Calculate();
console.log(calc.Add(12, 23));
console.log(calc.GetFlowers());
console.log(calc.Greet('Sachin'));
