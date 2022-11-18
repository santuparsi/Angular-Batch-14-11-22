class Car
{
    public color:string;
    constructor(color:string)
    {
        this.color=color
    }
}
class Benz extends Car
{
    public cost:number;
   
    constructor(color:string,cost:number)
    {
        super(color); //invoke Car Construcotr
        this.cost=cost;
    }
    public show():void
    {
        console.log("Color of the Benz Car is "+this.color);
        console.log("Price of the Car "+this.cost);
    }
}
let obj=new Benz('Black',78000000);
obj.show();
let obj1=new Benz('Red',45044544);
obj1.show();