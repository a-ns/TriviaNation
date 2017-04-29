var mongoose = require('mongoose')
var Schema = mongoose.Schema
var gameSchema = new Schema({
  gameName: {
    type: String,
    required: true
  },
  Nations: [ {type: Schema.Types.Mixed} ],
  Tiles: [ {type: Schema.Types.Mixed} ],
  Scores: [{type: Number}]
})

module.exports = mongoose.model('Game', gameSchema)