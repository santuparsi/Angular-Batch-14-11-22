class Employee
{
constructor(eid,ename,desig,sal)
{
    this.Eid=eid;
    this.Ename=ename;
    this.Desig=desig;
    this.Salary=sal;
}

}
class Manager extends Employee
{
    constructor(eid,ename,desig,sal,project)
    {
    super(eid,ename,desig,sal); //invokes Employee constructor
       this.Project=project;
      // super(1,'Ram','Programmer',12000);
      
    }
    details()
    {
        console.log("Eid "+this.Eid);
        console.log("Ename "+this.Ename);
        console.log("Designation "+this.Desig)
       console.log("Project "+this.Project);
        console.log("Salary "+this.Salary);
    }
    
   
}
var obj=new Manager(100,'Suren','TeamLeader',45000,'BFS');
obj.details();