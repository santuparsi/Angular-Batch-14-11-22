//enum 
var Week;
(function (Week) {
    Week[Week["Mon"] = 1] = "Mon";
    Week[Week["Tue"] = 2] = "Tue";
    Week[Week["Wed"] = 3] = "Wed";
    Week[Week["Thu"] = 4] = "Thu";
    Week[Week["Fri"] = 19] = "Fri";
    Week[Week["Sat"] = 20] = "Sat";
    Week[Week["Sun"] = 21] = "Sun";
})(Week || (Week = {}));
console.log(Week.Mon);
console.log(Week.Tue);
console.log(Week.Fri);
