var server = require('http').createServer()

var io = require('socket.io')(server)

io.on('connection', function (client) {
  console.log(client)
  client.emit('message', {'message': 'hello world'})
})

server.listen(3000)
