var PORT = process.env.PORT || 5000;
var express = require('express');
var app = express();

var http = require('http');
var server = http.Server(app);

const orderRoutes = require('./api/routes/EndpointsOrders');
//EndpointsOrders
//http://localhost:5000/EndpointsOrders/komunikatzamowienie
//EndpointsProducts
//http://localhost:5000/EndpointsProducts/komunikatprodukt
const productRoutes = require('./api/routes/EndpointsProducts');
app.use('/EndpointsOrders', orderRoutes);
app.use('/EndpointsProducts', productRoutes);

app.use(express.static('WebAppClient'));

module.exports = app;

server.listen(PORT, function() {
  console.log('Node.js Web Server running on: http://localhost:5000/');
});

/*
var io = require('socket.io')(server);


io.on('connection', function(socket) {
  socket.on('message', function(msg) {
    io.emit('message', msg);
  });
});
*/