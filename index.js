var server = require('http').createServer()

var io = require('./server/ioserver.js')(server)

server.listen(3000)
