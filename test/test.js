var should = require('chai').should()
var commandHandlers = require('../server/commandHandlers.js')
var Mongoose = require('mongoose').Mongoose
var mongoose = new Mongoose()

var Mockgoose = require('mockgoose').Mockgoose
var mockgoose = new Mockgoose(mongoose)

before(function(done) {
  mockgoose.prepareStorage().then(function () {
    mongoose.connect(process.env.MONGODB_URI, function (err) {
      done(err)
    })
  })
})

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

describe('Command Handlers', function () {
  it('SignUp should return true for new user success', function (done) {
    var testSignup = {'username': 'testUser', 'password': 'testPassword'}
    var sut = commandHandlers.signup(testSignup)
    done()
    sut.should.equal(true)
  })

  it('SignUp should return false when trying to create an existing user', function (done ) {
    var testSignup = {'username': 'testUser', 'password': 'testPassword'}
    var sut = commandHandlers.signup(testSignup)
    done()
    sut.should.equal(false)
  })

  it('SignUp should return false when trying to create a user with no password', function (done) {
    var testSignup = {'username': 'testUser', 'password': ''}
    var sut = commandHandlers.signup(testSignup)
    done()
    sut.should.equal(false)
  })
})
