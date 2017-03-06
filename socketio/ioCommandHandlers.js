var scoreUpdate = function (data) {
  console.log(data)
}

var answerClicked = function (data) {
  console.log(data)
}

var message = function (data) {
  console.log(data)
}

var connection = function (client) {
  client.emit('message', {message: 'hello client'})
}

module.exports = {scoreUpdate, answerClicked, message, connection}
