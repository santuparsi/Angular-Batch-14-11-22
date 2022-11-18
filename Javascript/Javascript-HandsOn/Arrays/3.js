//In Javascript arrays can hold mixed type of values.
let items=[
    12,
    23.34,
    true,
    'Ram',
    {Sid:1,Sname:'Cherri'},
    ()=>5
];
console.log(items[0]); //12
console.log(items[2]); //true
console.log(items[5]()); //5
console.log(`ID:${items[4].Sid} 
Name:${items[4].Sname}`)