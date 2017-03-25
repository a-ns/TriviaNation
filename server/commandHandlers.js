var User = require('./models/User.js')
var Promise = require('bluebird')
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
  return new Promise(function (resolve, reject) {
    User.findOne({username: data.username}, function (err, userfound) {
      if (err) {
        console.log(err)
        reject(err)
      }

    }).then(function (userfound) {
      if (userfound)
        resolve(userfound)
      else reject(null)
    })
  })
}

var signup = function (data) {
  return new Promise(function (resolve, reject) {
    if (data["password"].length === 0 || (data["username"].length === 0))
      reject(new Error('username or password is invalid'))

    var user = new User()
    user.password = data.password
    user.username = data.username
    //console.log(user)
    User.findOne({username: user.username}, function (err, userfound){
      if (err) {
        console.log(err)
        reject(err)
      }
    }).then(function (userfound) {
        user.save(function (err) {
          console.log('saving', user)
          resolve(true)
        })
    })
  })
}

var connection = function (client) {
  console.log(client.id, 'has connected')
}

module.exports = {login, signup, scoreUpdate, answerClicked, message, connection, questionClicked}
