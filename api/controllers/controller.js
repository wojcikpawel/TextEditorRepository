const mongoose = require('mongoose');
var db = require('database');
mojedokumenty = mongoose.model('mojedokumenty');

var util = require('util');
var fs = require('fs');
const writePath = "";


exports.getAllDocuments = function(req, res)
{
    db.textdocuments.find();

    
} 