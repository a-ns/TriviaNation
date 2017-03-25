var commandHandlers = require('./commandHandlers.js')
var Promise = require('bluebird')
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
  console.log('got here')
  var theMessage = commandHandlers.message(data)
  console.log(theMessage)
  //data.emit({})
}

var login = function (data) {
  var that = this
  var theData = JSON.parse(data)
//  console.log('client', this)
  commandHandlers.login(theData).then(function (loginSuccess){
    console.log(loginSuccess, 'login Success')
    that.emit('login', loginSuccess)
  }).catch(function (){
    that.emit('login', null)
  })
}

var signup = function (data) {
  var theData = JSON.parse(data)
  //console.log('request for signup')
  var signUpSuccess = commandHandlers.signup(theData)

  //data.emit(signUpSuccess)
}

var connection = function (client) {
  var theData = commandHandlers.connection(client)
  client.emit('message', {message: client.id})
  //client.emit(/*clients.push(client) maybe?*/)
}

module.exports = {login, signup, scoreUpdate, answerClicked, message, connection, questionClicked}
