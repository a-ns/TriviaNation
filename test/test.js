var should = require('chai').should()
var commandHandlers = require('../server/commandHandlers.js')


describe('Example Tests', function (){

  it('1 should equal 1', function() {
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

  it('SignUp should return true for new user success', function(done){
    var testSignup = {'username': 'testUser', 'password': 'testPassword'}
    var sut = commandHandlers.signup(testSignup)
    sut.should.equal(true)
    done()
  })

  it('SignUp should return false when trying to create an existing user', function(done){
    var testSignup = {'username': 'testUser', 'password': 'testPassword'}
    var sut = commandHandlers.signup(testSignup)
    sut.should.equal(false)
    done()
  })

  it('SignUp should return false when trying to create a user with no password', function(done){
    var testSignup = {'username': 'testUser', 'password': ''}
    var sut = commandHandlers.signup(testSignup)
    sut.should.equal(false)
    done()
  })


})
