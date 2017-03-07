var should = require('chai').should()
var ioCommandHandlers = require('../server/ioCommandHandlers.js')

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

  it('scoreUpdate should return status ok', function () {
    var data = ioCommandHandlers.scoreUpdate({'data': 'some data'})
    data.should.have.property('status').and.equal('ok')
  })
})
