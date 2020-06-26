var util = require('util');

//Mongo DataBase Connection
var db = require("../db");

//GDZIE TĘ METODE Z KONTROLERA WYEKRSPOTOWAĆ??????
exports.get_all_posts = function(req, res){
    //@GET - http://localhost:3001/posts
    db.pocztowki.find({post_id: 7}, function(err,result){
        console.log(util.inspect(result));

        res.send("Poprawnie pobrales wszyskie pocztowki z serwera!");
        res.json(result);
        res.json({ message: 'Document successfully created' });
    });
};

/*
WebStorm
const mongoose = require('mongoose');
docs = mongoose.model('documentsssss');

exports.list_all_documents = function(req, res){
    docs.find({}, function(err,doc) {
        if(err)
        res.send(err);
        res.json(doc);
    });
};





*/
/*
db.pocztowki.create({post_id: 7, post_name: 'mojamalapocztoweczka'}, function(err, result){
    console.log(util.inspect(result));
});

module.exports = app;
*/
/*
exports.list_all_docs = function(req, res) {
    res.header("Access-Control-Allow-Origin", "*");
  
    Docs.find({}, function(err, doc) {
      if (err) res.send(err);
      res.json(doc);
    });
  };



  exports.getStudentById = function(studentId, callback){
    console.log("query data = "+util.inspect(studentId));
    //id=false, id =true
    db.students.find({"id" : studentId},{"id" : false, "type": true, "name" : true, "lastName" : true, "password" : true, "email": true}, function(err, result)
    {
        if(err) return callback(err);
        callback(null, result[0]);
    });
};

*/