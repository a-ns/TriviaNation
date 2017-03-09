var scoreUpdate = function (data) {
  console.log(data)
  return {'status': 'ok'}
}

var answerClicked = function (data) {
  /*data will have
  data.// SOCKET INFO:
  data.question.// ID: // INT
  data.question.answerClicked // INT
  data.nation // INT
  */
  //check if they clicked the right answerClicked
  /*if nation requesting the tile answers incorrectly,
  the other nation's answer doesn't matter, so kick everybody out
  and don't update anything
  */
  //everybody.emit({the data})
}

var questionClicked = function (data) {
  //data will have the question ID
  //send back the question associated with the tile they clicked

  //everybody.emit({question data + nations_competing})
  //client side, they'll go "am i one of the nation's competing?"
  //if yes, they can click on the questions
  //if no, they can't click on the questions
}

var message = function (data) {
  console.log(data)
  return data
}

var login = function (data) {
  //data.username
  //data.password

  //find in database, that user
  //data.emit({login successful})
}

var signup = function (data) {
  //data.username
  //data.password

  //check if that username is already existing
  //if so , spit out an error
  //else, create that account

  //data.emit({signup successful})
}

var connection = function (client) {
  client.emit(/*clients.push(client) maybe?*/)
}

module.exports = {login, signup, scoreUpdate, answerClicked, message, connection, questionClicked}
