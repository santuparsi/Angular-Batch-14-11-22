// let func=(arg1,arg2,....)=>expression
//const func=(arg1,arg2,...)=>expreession
//arrow functions
// function Hello()
// {
//   return "Hello World";
// }
let Hello=()=>'Hello World'
let result=Hello();
console.log(result);
let Greet=(n)=>{
    let message='Hello '+n;
    return message;
}
console.log(Greet('Sachin'));
console.log(Greet('Dhoni'));
let sum=(a,b)=>a+b;
console.log(sum(2,5));
let age=18;
let message=age>=18?()=>'you can vote':()=>'try next time'
console.log(message());
function f(f1,f2)
{
  //  console.log( f1()+' '+f2());
  return f1()+" "+f2();
}
result=f(()=>'Hello ',()=>'Tina')
console.log(result);
const Sum=(a,b)=>a+b;
console.log(Sum(2,4));
