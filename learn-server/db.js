const mongoose = require("mongoose");
require("dotenv").config();
var schemas = require('./schemas');//scieżka do pliku schemas.js nie wiem czemu nie podaje sie rozszerzenia pliku .js w require
mongoose.Promise = global.Promise;
//mongoose.connect('mongodb://localhost/bazapawel', { useNewUrlParser: true });
mongoose.connect(process.env.MONGOURI);

console.log(process.env.MONGOURI);
console.log(process.env.NAME);

//adding collections to Mongo Database - kolekcja nie istnieje dopóki nie wypełnisz jej danymi wartościami
var db =  mongoose.connection;
db.pocztowki =  schemas.posts;

//db.uzytkownicy - to jest wykorzystane do tego ...
db.uzytkownicy = schemas.users;

module.exports = db;

//Źródło: https://www.youtube.com/watch?v=PQzU9a5_Njs
//Źródło: https://github.com/shoaibcode/NodeJS-RESTAPI