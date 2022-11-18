class student{
    // sid=89098;
    // sname;
    // age;
    //constructor is invoking while creating the object
    //constructor is used to initialize the class variables
    constructor() {
        this.sid=8987;
        this.sname='Shiva';
        this.age=12;
    }
}
let ob1=new student();
console.log(`ID:${ob1.sid} Name:${ob1.sname} Age:${ob1.age}`)
let obj=new student();
//obj.age=10;
obj.sid=1909;
obj.sname='Rahul';
console.log(`ID:${obj.sid} Name:${obj.sname} Age:${obj.age}`)