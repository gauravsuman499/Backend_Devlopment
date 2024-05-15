// console.log("Gaurav Suman");
// console.log("DAY: 2 , Date : 15/05/2024" );

const fs = require('fs');
const os = require('os');



//This is day 2 of my backend learning journey.

// function add(a , b){
//     return (a+b) ;
// }

// const add = function( a, b) {
//     return (a+b) ;
// }

// const add = (a , b) =>{
//     return (a+b) ;
// }
// let sum = add(7, 7) ;
// console.log(sum);

/****** SELF CALLED FUNCTION ********/

// (function(){
//     console.log("This is a self called function:");
// })();

/******** Callback Function **********/

// function Callback(){
//     console.log("This is a CallBack Function:");
//     console.log("Sum of a & b is successfully calculated");
// }


// const add = (a,b, Callback) =>{
//     console.log(`The sum of a & b is : ${a+b}`);
//     Callback() ;
// }


// console.log(add(5,1,Callback = () =>{
//     console.log("This is a CallBack Function:");
//     console.log("Sum of a & b is successfully calculated");
// }));


/******* Learning about BUILT IN - OS & FS Functionalities ************/


//OS
// const user = os.userInfo() ;

// console.log(user.username);

// //FS
// fs.appendFile('greeting.txt' , `hello ${user.username} ${'!'}` ,()=>{
//     console.log("This is callback Function used inf appendfile functionalities of fs");
// });


/************ IMPORT FILES & their data **********/

// const data = require('./test');

// // const cll = data.fun() ;

// console.log(data.age);
// console.log(data.fun());


/******* Learning LODASH *********/
// const _ = require('lodash');

// const arr = ["Gaurav" , "Gaurav" , 1, 1, 5, 5, true , true , false ] ;

// const filterData = _.uniq(arr) ;
// console.log(filterData) ;


// console.log(_.isString(5));
// console.log(_.isString("Gaurav Suman"));
// console.log(_.isString(true));
// console.log(_.isString(false));