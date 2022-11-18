//if-else-if
let m1=91,m2=78,m3=67;
let total=(m1+m2+m3);
let avg=total/3;
if(avg>=70)
console.log('Result:Distinction');
else if(avg>=60 && avg<70)
console.log('Result:FirstClass');
else if(avg>=50 && avg<60)
console.log('Result:SecondClass');
else if(avg>=35 && avg<50)
console.log('Result:ThirdClass');
else
console.log("Fail");
if(avg>=35)
console.log(`Total Marks:${total} Avg:${avg}%`)