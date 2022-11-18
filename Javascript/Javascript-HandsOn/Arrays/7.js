let no=[12,3,4,5,67,78,89];
let a=no.find(i=>i>50); //retuns single(first) value from the result expression
console.log(a);
//get no's >50
let n=no.filter(i=>i>50); //returns all the values from the result expression
console.log(n);
let users=[
    {id:1,name:'Tim',salary:1200},
    {id:2,name:'John',salary:15000},
    {id:3,name:'Suren',salary:20000},
    {id:4,name:'Tony',salary:13000},
]
// //Find
//It returs allway first result value in the result expression
let user=users.find(i=>i.id>2)
if(user!=null)
console.log(user.name);
else
console.log('Invalid Id')
let user1=users.find(u=>u.name=='Tony');
console.log(user1.id+' '+user1.name);

// // //Filter
// //return multiple values
let arr=users.filter(i=>i.salary>13000)
console.log(arr);
arr=users.filter(i=>i.name.startsWith('T'));
console.log(arr);


