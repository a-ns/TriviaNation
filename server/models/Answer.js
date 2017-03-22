let mongoose = require('mongoose')
let Schema = mongoose.Schema

let answerSchema = new Schema ({
  text: {
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
