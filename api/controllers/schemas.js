const mongoose = require('mongoose');
var ObjectId = mongoose.Schema.Types.ObjectID;

var docsSchema = new mongoose.Schema({
    id: Number,
    name: String
   
});

exports.textdocuments = mongoose.model('docs', docsSchema);