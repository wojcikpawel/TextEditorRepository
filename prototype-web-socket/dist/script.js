(function() {
  var url = 'wss://echo.websocket.org';
  var mySocket = new WebSocket(url);
  var container = document.getElementById('container');

  var key = document.onkeypress = function(event) {
    event = event || window.event;

    if (event.which == 13) {
      var message = document.getElementById('message');
      
      container.innerHTML += '<div class="server-message"><span class="label label-success">Me</span><span>' + message.value + '</span></div>';
      console.log('me: ' + message.value);
			mySocket.send(message.value);
      message.value = '';
    }

    return event.which;
  };

  mySocket.onopen = function() {
    console.log('opened !');
   // container.innerHTML += '<h2><span class="label label-default">Connection established : ' + url + '</span></h2>';
  };
  
  mySocket.onmessage = function(e) {
    console.log('server: ' + e.data);
    container.innerHTML += '<div class="server-message"><span class="label label-warning">Server</span><span>' + e.data + '</span></div>';
  };
  
  mySocket.onclose = function() {
    console.log('closed !');
    container.innerHTML += '<h2><span class="label label-default">Connection closed</span></h2>';
  };
}());