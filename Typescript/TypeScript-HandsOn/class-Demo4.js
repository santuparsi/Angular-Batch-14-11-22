var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Car = /** @class */ (function () {
    function Car(color) {
        this.color = color;
    }
    return Car;
}());
var Benz = /** @class */ (function (_super) {
    __extends(Benz, _super);
    function Benz(color, cost) {
        var _this = _super.call(this, color) || this;
        _this.cost = cost;
        return _this;
    }
    Benz.prototype.show = function () {
        console.log("Color of the Benz Car " + this.color);
        console.log("Price of the Car " + this.cost);
    };
    return Benz;
}(Car));
var obj = new Benz('Black', 78000000);
obj.show();
var obj1 = new Benz('Red', 45044544);
obj1.show();
