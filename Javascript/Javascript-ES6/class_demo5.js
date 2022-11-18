class Foo {
    static M() {
        return 'Hello';
    }
}
// class Bar extends Foo {

// }
// class Jar extends Foo {
//     static M() {
//         return super.M() + ' too';
//     }
// }
//let obj = new Bar();
console.log(Foo.M());
// console.log(Bar.M()); //static methods invoke using class_name
// console.log(Jar.M())