interface Person
{
    firstName:string;
    lastName:string;
    age:number;
    FullName();
    GetAge();
}
class Employee implements Person
{
    firstName: string;
    lastName:string;
    age:number;
    constructor(fname:string,lname:string)
    {
        this.firstName=fname;
        this.lastName=lname;
    }
    FullName()
    {
        console.log(`FullName:${this.firstName} ${this.lastName}`)
    }
    GetAge() {
        this.age=34;
    }
}
let employee:Employee=new Employee('Rahul','Dravid');
employee.FullName();
employee.GetAge();