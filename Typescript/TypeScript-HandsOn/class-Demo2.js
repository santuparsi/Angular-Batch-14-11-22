var Customer = /** @class */ (function () {
    function Customer() {
        this.cId = 1000;
        this.cname = 'Jeson';
    }
    Customer.prototype.show = function () {
        console.log("ID:".concat(this.cId, " Name:").concat(this.cname));
    };
    return Customer;
}());
var customer = new Customer(); //customer object
customer.show();
