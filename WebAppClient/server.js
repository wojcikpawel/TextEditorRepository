const express = require('./node_modules/express');
const mongoose = require('./node_modules/mongoose');
const bodyParser = require('./node_modules/body-parser');

const http = require('http');
const hostname = '127.0.0.1';
const port = 3000;


const app = express();
//const port = process.env.PORT || 3000;
const models = require('./api/models/model');
const routes = require('./api/routes/route');

mongoose.Promise = global.Promise;
mongoose.connect('mongodb://localhost/dokumenty', { useNewUrlParser: true });


app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

routes(app);
app.listen(port);

//console.log('REST API server started on: ' + port);
app.listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);
});



/*
const server = http.createServer((req, res) => {
  res.statusCode = 200;
  res.setHeader('Content-Type', 'text/plain');
  res.end('Hello World\n');
});


*/