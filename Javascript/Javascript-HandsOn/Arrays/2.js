let numbers=[12,23,34,45,56,67,78];
//access all array elements
for(let i=0;i<numbers.length;i++)
{
    console.log(numbers[i]);
}
//console.clear();
for(let i in numbers) //heare i is return as index of the element
{
    console.log(i); //index
    console.log(numbers[i]); //value
}
//console.clear();
for(let i of numbers) //ES6 feature // here i is return as value of the array element
{
    console.log(i);
}
console.clear();
let students=[
{'id':1,name:'Rohan'},
{'id':2,name:'Ram'},
{'id':3,name:'Karan'},
];
for(let ob of students)
{
    console.log(`Id:${ob.id} Name:${ob.name}`)
}