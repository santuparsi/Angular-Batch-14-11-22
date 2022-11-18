//define the function
function Hello()
{
    console.log('Hello World..');
}
//calling function
Hello();
Hello();
function Greet(name)
{
   Hello();
    console.log(`Hello ${name}`)

}
Greet('Sachin');
Greet('Rahul');
function Add(a,b)
{
    let result=a+b; //result is the local variable
    console.log(`${a}+${b}=${result}`)
}
Add(3,5);
Add(4); //b is undefined
function Sum(a,b=10) //defaut value of b=10
{
    let result=a+b;
    console.log(`${a}+${b}=${result}`)
}
Sum(12); //b is 10
Sum(13,20);