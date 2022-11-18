let txt='Javascript is easy to learn'
console.log(txt[3]);
console.log(txt.length);
console.log(txt.toUpperCase());
console.log(txt.toLowerCase());
console.log(txt.charAt(6));
console.log(txt.slice(1,2)); //index,no of char
console.log(txt.substring(1,3)); //(index,count)
console.log(txt.substr(7,10));
txt=txt.replace('Javascript','React');
console.log(txt);
console.log(txt.indexOf('i'));
console.log(txt.lastIndexOf('i'));