var Student = /** @class */ (function () {
    function Student() {
    }
    //method
    Student.prototype.show = function () {
        console.log("Id:".concat(this.sId, " Name:").concat(this.sName));
    };
    return Student;
}());
//create object
var student = new Student(); //javascript style
//access class members using object
student.sId = 1;
student.sName = 'Rohan';
student.show();
var stu = new Student(); //typescript style
stu.sId = 2;
stu.sName = 'Karan';
stu.show();
