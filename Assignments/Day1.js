/*************** Q01. **************/
/*
const prompt = require('prompt-sync')();
const age = prompt("Enter your age : ") ;

if( age < 18){
    console.log("You will get a 20% discount");
}
else if( age >= 18 && age <= 65){
    console.log("Normal ticket price applies");
}
else{
    console.log("You will get a 30% senior discount");
}
*/

/************ Q02. *************/
/*
const prompt = require('prompt-sync')();


const len = prompt("Enter the length of the rectangle : ");
const breadth =  prompt("Enter the breadth of the rectangle : ");

const area = len * breadth ;

console.log(`Area of the rectangle is : ${area}`);

*/


/**************** Q03. ****************/

// const product01 = {
//     name : "Laptops",
//     price : 65000,
//     inStock : true
// };

// const product02 ={
//     name : "Two Wheeler",
//     price : 35000,
//     inStock : true
// };

// const product03 = {
//     name : "Suv(Sports Utility Vehicles)",
//     price : 1700000,
//     inStock : false
// }


// console.log(product01);
// console.log(product02);
// console.log(product03);


/***************Q04. ***************/
// const guestList = ["Gaurav Suman"];
// guestList.push("Ankit Raj") ;
// guestList.push("Rohan Sharma") ;
// guestList.push("Amit Kumar") ;
// guestList.push("Aman Kant") ;
// guestList.push("Ram Kumar") ;
// guestList.push("Lakshman") ;
// guestList.push("harsh Kumar") ;
// guestList.push("Ayush Suryawanshi") ;


// const prompt = require('prompt-sync')() ;

// let name  = prompt("Enter your name : ") ;

// if( guestList.includes(name)){
//     console.log(`Welcome to the party, ${name}!`);
// }
// else{
//     console.log(`Sorry you are not on the guest list`);
// }

// console.log(guestList);

/*******************Q05. *******************/
const JSONobject = {
    "date" : "16/05/2024",
    "temperatiure" : 39,
    "conditions" : "sunny" ,
    "humidity" : 75 
};

console.log(`Weather forecast for : ${JSONobject.date}` );
console.log(`Temperature is : ${JSONobject.temperatiure}`);
console.log(`Condition is : ${JSONobject.conditions}`);
console.log(`Humidity is : ${JSONobject.humidity}`);

