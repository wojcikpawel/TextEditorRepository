const Hapi = require('hapi');

const server = new Hapi.Server();

server.connection({  
    host: 'localhost',
    port: 3000
});

server.start((err) => {  
    if (err) {
        throw err;
    }

    console.log(`Server running at ${server.info.uri}`);
});


server.listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);
});