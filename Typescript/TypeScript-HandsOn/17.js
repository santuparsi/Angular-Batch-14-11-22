//enum demo2
var AppStatus;
(function (AppStatus) {
    AppStatus[AppStatus["ACTIVE"] = 0] = "ACTIVE";
    AppStatus[AppStatus["INACTIVE"] = 1] = "INACTIVE";
    AppStatus[AppStatus["ONSTOP"] = 1.2] = "ONSTOP";
    AppStatus[AppStatus["ONHOLD"] = 2.2] = "ONHOLD";
})(AppStatus || (AppStatus = {}));
console.log(AppStatus.ACTIVE);
console.log(AppStatus.INACTIVE);
console.log(AppStatus.ONHOLD);
console.log(AppStatus.ONSTOP);
