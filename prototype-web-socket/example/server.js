//importing http module
const http = require('http');
//importing ws module
const websocket = require('ws');

//źródło: https://bulldogjob.pl/news/751-prosto-o-websocket

//creating a http server
const server = http.createServer((req, res) => {
    res.end("I am connected");
});

//creating websocket server
const wss = new websocket.Server({ server });
//calling a method 'on' which is available on websocket object
wss.on('headers', (headers, req) => {
    //logging the header
   // console.log(headers);
});


//Event: 'connection'
wss.on('connection', (ws, req) => {
    ws.send('This is a message from server, connection is established');
    //receive the message from client on Event: 'message'
    ws.on('message', (msg) => {
        console.log(msg);
    });
});


//making it listen to port 8000
server.listen(8000);