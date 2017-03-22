let mongoose = require('mongoose')
let Schema = mongoose.Schema

let tileSchema = new Schema({
  x: {
    type: Number,
    required: true
  },
  y: {
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
