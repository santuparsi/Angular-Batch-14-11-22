class Person {
    constructor(name) {
        this.Name = name;
    }
    f()
    {
        console.log("Person Info");
    }
    
}
class Employee extends Person {
    constructor(name, title) {
        super(name); //call Person constructor
        this.title = title;
    }
    details() {
       
        console.log("Name: "+this.Name); //member of Person
        console.log("Title: " + this.title); //member of Employee
    }
}
let obj = new Employee("Rohan", "TeamLeader");
obj.details(); //calls Employee Details()
obj.f(); //calls person f()
