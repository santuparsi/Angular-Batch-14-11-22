function Square(n)
{
    let result=n*n;
    return result; //retun number
}
function Greet(name)
{
    let message='Hello '+name;
    return message; //return string
}
function IsEven(number)
{
   let isEven=number%2==0?true:false;
   return isEven;
//    if(number%2==0)
//    return true;
//    else
  // return false;
    
}
let result=Square(10);
console.log(result);
result=Greet('Dhoni');
console.log(result);
console.log(IsEven(110)?'Even':'Odd');
