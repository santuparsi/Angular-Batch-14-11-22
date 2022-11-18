class Student {
    //constructor of the class
    constructor(name, age) {
        //"this" points to the current object
        this.name = name;

        this._age = age;
    }

    //member function
    getName() {
        return this.name;
    }

    setName(name) {
        this.name = name;
    }

    //getters and setters make a function accessible like a variable. They are used as wrappers around other variables.
    set age(value) {
        this._age = value;
    }

    get age() {
        return this._age;
    }
}
//instance of student class
var stud = new Student("Narayan", 21);
stud.age = 12; //executes setter
console.log(stud.age); //executes getter
//class person inherits student class
class Person extends Student {
    constructor(name, age, citizen) {


        //call constructor of super class. "super" is an pointer to the super class object
        super(name, age);
        //this points to the person class
        this.citizen = citizen;
    }

    getCitizen() {
        return this.citizen;
    }

    //overriding
    getName() {
        //we are calling the super class getName function
        return super.getName();
    }
}

//instance of person class
//var p = new Person("Narayan Prusty", 21, "India");