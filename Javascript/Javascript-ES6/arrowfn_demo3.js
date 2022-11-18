//setTimeout() delay the call-back function execution for the given time.
setTimeout(() => {
  console.log('Hello'); //34 //return local variable value
}, 3000);

setTimeout(function(){
  console.log('Hello'); //12 //return global variable value
}, 1000); 