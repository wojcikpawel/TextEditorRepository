const mongoose = require('mongoose');
const options = { day: 'numeric', month: 'long', year: 'numeric', hour: 'numeric', minute: 'numeric', second: 'numeric' };
var fs = require('fs');
const writePath = "/tmp/";
Docs = mongoose.model('dokumenty');

exports.list_all_docs = function(req, res) {
  res.header("Access-Control-Allow-Origin", "*");

  Docs.find({}, function(err, doc) {
    if (err) res.send(err);
    res.json(doc);
  });
};

exports.create_a_doc = function(req, res) {
  res.header("Access-Control-Allow-Origin", "*");

  var new_doc = new Docs(req.body);
  var docId = new_doc._id;

  new_doc.save(function(err, doc) {
    if (err) res.send(err);
    else fs.writeFile(writePath + docId, "");
    res.json(doc);
  });
};

exports.read_a_doc = function(req, res) {
  res.header("Access-Control-Allow-Origin", "*");

  Docs.findById(req.params.docId, function(err, doc) {
    if (err) res.send(err);
    else {
      fs.readFile(writePath + req.params.docId, function(err, data) {
        res.send(data);
        res.end();
      });
    }
  });
};

exports.update_a_doc = function(req, res) {
  res.header("Access-Control-Allow-Origin", "*");

  var docBody = req.body;
  var docContent = docBody.content;
  var currentTime = new Date();
  if (docContent) docBody.modification_date = currentTime.toLocaleDateString("pl-PL", options);

  Docs.findOneAndUpdate({_id: req.params.docId}, docBody, {new: true}, function(err, doc) {
    if (err) res.send(err);
    else {
      if (docContent) fs.writeFile(writePath + req.params.docId, docContent);
    }
    res.json(doc);
  });
};

exports.delete_a_doc = function(req, res) {
  res.header("Access-Control-Allow-Origin", "*");

  Docs.remove({
    _id: req.params.docId
  }, function(err, doc) {
    if (err) res.send(err);
    else fs.unlink(writePath + req.params.docId);
    res.json({ message: 'Document successfully deleted' });
  });
};
