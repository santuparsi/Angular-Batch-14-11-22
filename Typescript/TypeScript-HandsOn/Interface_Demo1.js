var Employee = /** @class */ (function () {
    function Employee(fname, lname) {
        this.firstName = fname;
        this.lastName = lname;
    }
    Employee.prototype.FullName = function () {
        console.log("FullName:".concat(this.firstName, " ").concat(this.lastName));
    };
    return Employee;
}());
var employee = new Employee('Rahul', 'Dravid');
employee.FullName();
