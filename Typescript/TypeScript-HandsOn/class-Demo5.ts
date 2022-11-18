class Calculate
{
    public Add(a:number,b:number):number
    {
        return a+b;
    }
    public Greet(name:string):string
    {
        return 'Hello '+name
    }
    public GetFlowers():string[]
    {
        return ["Rose","Lilly","Tulips"]
    }
    
}
let calc=new Calculate();
console.log(calc.Add(12,23))
console.log(calc.GetFlowers())
console.log(calc.Greet('Sachin'))