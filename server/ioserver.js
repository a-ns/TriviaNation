var ioCommandHandlers = require('./ioCommandHandlers.js')
var commands = require('./commands.js')()

var create = function (server) {
  var io = require('socket.io')(server)
  commands.map((command) => {
    io.on(command, ioCommandHandlers[command])
  })
  return io
}

module.exports = create
