class Student
{
    //varialbe
    sId:number;
    sName:string;
    //method
    show():void
    {
        console.log(`Id:${this.sId} Name:${this.sName}`)
    }
}
//create object
let student=new Student(); //javascript style
//access class members using object
student.sId=1;
student.sName='Rohan';
student.show();
let stu:Student=new Student(); //typescript style
stu.sId=2;
stu.sName='Karan';
stu.show()