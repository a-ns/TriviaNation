var scoreUpdate = function (data) {
  console.log(data)
  return {'status': 'ok'}
}

var answerClicked = function (data) {
  console.log(data)
  return
}

var message = function (data) {
  console.log(data)
  return data
}

var connection = function (client) {
  client.emit('message', {message: 'hello client'})
}

module.exports = {scoreUpdate, answerClicked, message, connection}
