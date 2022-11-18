class Person
{
    Age=20;
    constructor() //default constructor
    {
        //define class varialbes
        this.Pid=1;
        this.Pname='Ram';
        this.City='Bangalore'
    }
}
//Initiate Person object
let person=new Person();
console.log(person.Pid+" "+person.Pname+" "+person.City+" "+person.Age);
let p1=new Person();
p1.Pid=2;
p1.Pname="Naveen";
p1.City='Hyderabad';
console.log(p1.Pid+" "+p1.Pname+" "+p1.City);
