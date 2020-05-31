const mongoose = require('mongoose');
var schemas = require('schemas');

mongoose.Promise = global.Promise;
mongoose.connect('mongodb://localhost/textdocumentsDB');

var db = mongoose.connection;
//adding collections to db
db.textdocuments = schemas.textdocuments;

db.on('error', console.error.bind(console, 'connection error:'));
db.once('open', function() {
    console.log("connected to database . . .");
});

module.exports = db;