var server = require('http').createServer()

var io = require('./socketio/ioserver.js')(server)

server.listen(3000)
