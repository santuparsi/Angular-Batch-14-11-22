let date=new Date(); //create object to data class
console.log(date);
// let date1=new Date(2018,11,24);
// console.log(date1);
// let date2=new Date(2018,10,13,10,33,20);
// console.log(date2);
console.log('Year '+date.getFullYear());
console.log("Month: "+date.getMonth());
console.log('Date '+date.getDate());
console.log('Hours '+date.getHours());
console.log("Minutes: "+date.getMinutes());
console.log('Seconds '+date.getSeconds());
console.log('Day: '+date.getDay()); //returns the day of the week
console.log('Date&TIme: '+date.toLocaleString()); //return date in date and time format
console.log('FullDate: '+date.toLocaleDateString()); //return only date
let date2=new Date('2015-03-23');
console.log(date2.toLocaleDateString());