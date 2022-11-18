//map
//it calls the function for each element in the array and returns the array of results.
let flowers=["rose","lilly","tulips"];
let result=flowers.map(item=>item.length);
console.log(result);
result=flowers.map(item=>item.toUpperCase());
console.log(result);
result=flowers.map(item=>item.length>5);
console.log(result);
result=flowers.map(item=>{
   let v=item;
    item=item.slice(1,item.length)
    item=v[0].toUpperCase()+item;
    return item;
});
console.log(result);
let r=flowers.forEach(item=>console.log(item.toUpperCase()))
console.log(r);