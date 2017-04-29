var mongoose = require('mongoose')
var Schema = mongoose.Schema
var gameSchema = new Schema({
  gameName: {
    type: String,
    required: true
  },
  Nations: [ {type: Schema.ObjectId, ref: 'Team'} ],
  Tiles: [ {type: Schema.ObjectId, ref: 'Tile'} ],
  Scores: [{type: Number}]
})

module.exports = mongoose.model('Game', gameSchema)