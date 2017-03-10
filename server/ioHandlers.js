var commandHandlers = require('./commandHandlers.js')

var scoreUpdate = function (data) {
  var theData = commandHandlers.scoreUpdate(data)
  //emit theData
}

var answerClicked = function (data) {
  var returnData = commandHandlers.answerClick(data)
  //everybody.emit(returnData)
}

var questionClicked = function (data) {
  var returnData = commandHandlers.questionClicked(data)

  //everybody.emit(returnData)
}

var message = function (data) {
  //console.log(data)
  //data.emit({})
}

var login = function (data) {
  var loginSuccess = commandHandlers.login(data)
  //data.emit(loginSuccess)
}

var signup = function (data) {
  var signUpSuccess = commandHandlers.signup(data)

  //data.emit(signUpSuccess)
}

var connection = function (client) {
  //client.emit(/*clients.push(client) maybe?*/)
}

module.exports = {login, signup, scoreUpdate, answerClicked, message, connection, questionClicked}
