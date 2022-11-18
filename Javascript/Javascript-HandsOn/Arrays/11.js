//reduce() method executes a reducer function for each item of an array
//reduce() retruns a single value which is the function's accumulated value
//array.reduce((accumulator,currenvalue,currentIndex,arr),initail value)
//accumulatro-the value returned from the previous call of the reducer function
//currentvalue-the value of the array elment in the current iteration
//currentIdex=index value of the array element in the current iteration
let arr=[1,2,3,4,5];
let result=arr.reduce((sum,current)=>sum+current,0)
console.log(result);
let sum=arr.reduce((tot,current)=>tot+current)
console.log(sum);
//reduce iterations
// 0 1 1
// 1 2 3
// 3 3 6
// 6 4 10
// 10 5 15
let r=arr.reduce((tot,current)=>{
    
    console.log(`${tot} ${current}`)
    return tot+current
},0)