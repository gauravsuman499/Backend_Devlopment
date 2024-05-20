// Json Object

// const jsonObj = {
//     "name" : "Gaurav Suman" ,
//     "UID" : "20BCS4471" ,
//     "hobbies" : ["Cricket" , "Meditation" , "Games"] 
// };

// console.log(jsonObj);


/******************** JSON to OBJECT *******************/
// const jsonString = '{"name": "John Wick", "age": 30, "city": "New York"}';
// const jsonObject = JSON.parse(jsonString); // Convert JSON string to object
// console.log(jsonObject.name);

/******************** OBJECT to JSON ********************/

// const objectToConvert = { 
//     name: "Alice", 
//     age: 25 
// };
// const jsonStringified = JSON.stringify(objectToConvert); // Convert object
// console.log(jsonStringified); 

/*************************** USING EXPRESS TO BUILD AN API(Collection of Endpoints) ***************************/

// const express = require('express')
// const app = express()

// app.get('/', function (req, res) {
//   res.send('Hello World')
// })

// app.listen(3000)

const express = require('express');

// Hum express ka sara functions and properties app variable m copy and store kr rhae hain.

const app = express() ;// now instead of using express everytime , we will use app variable

app.get('/' , (req , res)=>{
    res.send(`Welcome to our restrauant, How we can help you ?`)
})
app.get('/dishes' , (req, res)=>{
    res.send(`Below are the various dishes available in our menu`)
})
app.get('/drinks', (req,res)=>{
    res.send('Here are various drinks options that we offer');
})

app.listen(4000, ()=>{
    console.log(`Listening on port 4000`);
}) ; // app is live on the port 4000
