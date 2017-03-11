var server = require('http').createServer()

var io = require('./server/ioserver.js')(server)
console.log(io)


server.listen(3000)
