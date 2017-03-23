let db = require('../database/db.js')
let User = require('./models/')

var scoreUpdate = function (data) {
  console.log(data)
  return {'status': 'ok'}
}

var answerClicked = function (data) {
  /*data will have
  data.// SOCKET INFO:
  data.question.// ID: // INT
  data.question.answerClicked // String
  data.nation // String
  */
  //check if they clicked the right answerClicked
  /*if nation requesting the tile answers incorrectly,
  the other nation's answer doesn't matter, so kick everybody out
  and don't update anything
  */

  //return theData
}

var questionClicked = function (data) {
  //data will have the question ID
  //send back the question associated with the tile they clicked



  //client side, they'll go "am i one of the nation's competing?"
  //if yes, they can click on the questions
  //if no, they can't click on the questions

  //return {question data + nations competing}
}

var message = function (data) {
  console.log(data)
  return data
}

var login = function (data) {
  //data.username
  //data.password

  //find in database, that user
  //return {loginSuccessful}
}

var signup = function (data) {
  //data.username
  //data.password

  //check if that username is already existing
  //if so , spit out an error
  //else, create that account
  if (data.password.length === 0) {
    return false;
  }
  User.findOne({'username': data.username}, function(err, user){
    if (err) { // user not found which is good
      let user = new User()
      user.username = data.username
      user.password = data.password
      user.save(function (err) {
        if (err) {
          return err
        }
        else {
          return true;
        }
      })
    }
    else {

    }
  })

  //return {signUpSuccessful}
}

var connection = function (client) {
  console.log(client.id, 'has connected')
}

module.exports = {login, signup, scoreUpdate, answerClicked, message, connection, questionClicked}
