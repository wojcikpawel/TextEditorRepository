const express = require("express");
const app = express();
const mongoose = require("mongoose");
const bodyParser = require("body-parser")
const morgan = require("morgan")
var util = require('util');
//!!!!!!!!!!!!!!!!!!
//var db = require("./db")

//Mongo DataBase Connection
var db = require("./db")

//Models - Schema
require("./schemas");

//Middleware
app.use(bodyParser.json())
    .use(morgan());  
    
//WebStorm
//var studentsEndpoints = require('./routes/studentsEndpoints');
//app.use('/students', studentsEndpoints);

//Routes-REST API Endpoints URLs
var postsEndpoints = require('./routes/postsEndpoints');
app.use("/posts", postsEndpoints);

var usersEndpoints = require('./routes/usersEndpoints');
app.use("/users", usersEndpoints);

app.listen(3001, function () {
    console.log("Server is running on port 3001");
})


//===========================================================pocztówki==================================================================
//filling the collection with data - POWINIEN BYC CHYBA JESZCZE ODCZYT CRUD!
//TO CO ROBI PRZY STARCIE SERWERA POWINIEN ROBIĆ W CONTROLLERS <3 A TAK NAPRAWDE POWINIEN TO ROBIC PRZY ŻĄDANIU GET
//A JA TO ROBIĘ W KONSOLI wpisujac db.blabla.find()


//@POST
db.pocztowki.create({post_id: 7, post_name: 'mojamalapocztoweczka'}, function(err, result){
    console.log(util.inspect(result));
});
/*
//@GET - http://localhost:3001/posts
db.pocztowki.find({post_id: 7}, function(err,result){
    console.log(util.inspect(result));
});
*/
/*
db.pocztowki.create({id: 11, name: 'ciekawaWiadomosc'}, function(err, result){
    console.log(util.inspect(result));
});

db.pocztowki.remove({id: 7}, function(err, result){
    console.log(util.inspect(result));
});

db.pocztowki.update({id:7},{id:15}, function(err,result){
    console.log(util.inspect(result));
});
*/
/*

  db.students.update({name: 'pawel'}, {name: 'darek'}, function(err, result){
    console.log(util.inspect(result));
  });

    db.students.remove({id: 20401096910}, function(err, result){
    console.log(util.inspect(result));
  });


    db.studentsaaaa.create({id: 1011010, name: 'QQQQQQQQ'},function(err, result){
    console.log(util.inspect(result));
  });
*/
/*
//============================================================Użytkownicy==============================================================
db.uzytkownicy.create({user_id: 2, user_login: 'wojcikpawel',user_password: 'haselko'}, function(err, result){
    console.log(util.inspect(result));
});

module.exports = app;
*/

//Brakuje Controllerow i Endpointów