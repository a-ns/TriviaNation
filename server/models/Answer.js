var mongoose = require('mongoose')
var Schema = mongoose.Schema

var answerSchema = new Schema ({
  answer: {
    type: String,
    required: true
  },
  correct: {
    type: Boolean,
    required: true
  }
})

let Answer = mongoose.model('Answer', answerSchema)

module.exports = Answer
