var chai = require('chai')
var chaiAsPromised = require('chai-as-promised')
chai.use(chaiAsPromised)
var should = chai.should()
var commandHandlers = require('../server/commandHandlers.js')
var db = require('../server/database/db.js')
var User = require('../server/models/User.js')



describe('Example Tests', function () {
  it('1 should equal 1', function () {
    var thing = 1
    thing.should.be.a('number')
    thing.should.equal(1)
  })

  it('2 should not equal 1', function () {
    var thing = 2
    thing.should.be.a('number')
    thing.should.not.equal(1)
  })
})

describe('SignUp', function () {
  it('SignUp should return true for new user success', function () {
    var testSignup = {'username': 'testUser', 'password': 'testPassword'}
    return commandHandlers.signup(testSignup).should.eventually.equal(true)
  })

  it('SignUp should return false when trying to create an existing user', function () {
    var testSignup = {'username': 'testUser', 'password': 'testPassword'}
    return commandHandlers.signup(testSignup).should.be.rejectedWith(false)
  })

  it('SignUp should return false when trying to create a user with no password', function () {
    var testSignup = {'username': 'testUser', 'password': ''}
    return commandHandlers.signup(testSignup).should.be.rejectedWith(false)
  })
})

describe('SignIn', function () {

  it('SignIn should return object if user was found', function () {
    var testSignIn = {'username': 'testUser', 'password': 'testPassword'}
    return commandHandlers.login(testSignIn).should.eventually.be.a('object')
  })

  it('SignIn should return null if user was not found', function () {
    var testSignIn = {'username': 'notFoundUser', 'password': 'test'}
    return commandHandlers.login(testSignIn).should.be.rejectedWith(null)
  })
})

after(function () {
  User.remove({'username': 'testUser'}).exec()
})
