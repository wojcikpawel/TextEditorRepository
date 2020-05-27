const http = require('http');
const express = require('express');

const port = process.env.PORT || 5000;
const app = express();
const server = http.createServer(app);

const orderRoutes = require('./api/routes/EndpointsOrders');
const productRoutes = require('./api/routes/EndpointsProducts');

app.use('/EndpointsOrders', orderRoutes);
app.use('/EndpointsProducts', productRoutes);

module.exports = app;

server.listen(port);
console.log('Node.js web server at port 5000 is running..')