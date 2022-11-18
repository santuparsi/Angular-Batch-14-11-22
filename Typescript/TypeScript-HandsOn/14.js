var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
//working with arrays using spread operator ...
var arr1 = [23, 34, 45];
var arr2 = [98, 76, 34];
//let copyArray=[...arr1]
//console.log('Copied Array: '+copyArray)
//create new array with existing array
//let newArray=[...arr2,89,90,13]
//merge array
var mergeArray = __spreadArray(__spreadArray([], arr1, true), arr2, true);
console.log('Merged Array: ' + mergeArray);
