var mongoose = require('mongoose')
var Schema = mongoose.Schema

var tileSchema = new Schema({
  questionNum: {
    type: Number,
    required: true
  },
  question: {
    type: String,
    required: true
  },
  answers: [ {type: Schema.ObjectId, ref: 'Answer'} ]
})

let Tile = mongoose.model('Tile', tileSchema)

module.exports = Tile
