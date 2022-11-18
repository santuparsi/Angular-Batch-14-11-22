var Employee = /** @class */ (function () {
    //constructor
    function Employee(eId, eName, jDate, salary, desig) {
        this.eId = eId;
        this.eName = eName;
        this.jDate = jDate;
        this.salary = salary;
        this.desig = desig;
    }
    //method
    Employee.prototype.show = function () {
        console.log("ID:".concat(this.eId, " Name:").concat(this.eName, " JoinDate:").concat(this.jDate, "\n         Salary:").concat(this.salary, " Designation:").concat(this.desig));
    };
    return Employee;
}());
var emp = new Employee(100, 'Rohan', new Date(2021, 2, 20), 23000, 'Programmer');
emp.show();
//array of objects
var employees = [
    new Employee(100, 'Rohan', new Date(2021, 2, 20), 23000, 'Programmer'),
    new Employee(101, 'Karan', new Date(2021, 2, 20), 23000, 'Programmer'),
    new Employee(102, 'Charan', new Date(2021, 2, 20), 23000, 'Programmer'),
    new Employee(103, 'Jeson', new Date(2021, 2, 20), 23000, 'Programmer'),
    new Employee(104, 'Monica', new Date(2018, 2, 20), 23000, 'TeamLead'),
    new Employee(105, 'Tim', new Date(2021, 2, 20), 23000, 'Programmer'),
];
for (var _i = 0, employees_1 = employees; _i < employees_1.length; _i++) {
    var item = employees_1[_i];
    item.show();
}
