//array of objects
let students=[
    {Sid:1,Sname:'Rohan',age:10},
    {Sid:2,Sname:'Ram',age:11},
    {Sid:3,Sname:'Karan',age:10},
    {Sid:4,Sname:'John',age:11},
    {Sid:5,Sname:'Jeson',age:10},
    {Sid:6,Sname:'Tina',age:12},
    {Sid:7,Sname:'Meena',age:11},
    {Sid:8,Sname:'Monica',age:10},
]
let student=students[5]; //return 1st object from the aray
console.log(`ID:${student.Sid} Name:${student.Sname} Age:${student.age}`)
for(let student of students)
{
    console.log(`ID:${student.Sid} Name:${student.Sname} Age:${student.age}`)
}
// for(let i=0;i<students.length;i++)
// {
//     console.log(`ID:${students[i].Sid} Name:${students[i].Sname} Age:${students[i].age}`)
// }