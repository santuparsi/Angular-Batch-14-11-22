class student {

    constructor(name, age) //parameterized constructor
    {
        this.name = name;
        this.age = age;

    }
    display() //method
    {
        console.log(this.name);
        console.log(this.age);
    }
}
var obj = new student('sachin', 12)
obj.display()
var obj1 = new student('Ram');
obj1.display();
var obj2 = new student('sachin', 13)
obj2.display()
let ob3 = new student();
ob3.name = 'Shiva';
ob3.age = 12;
ob3.display();