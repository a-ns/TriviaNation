let mongoose = require('mongoose')
let Schema = mongoose.Schema

let teamSchema = new Schema({
  name: {
    type: String,
    required: true
  },
  color: {
    type: String,
    required: true
  },
  score: {
	type: Number,
	required: true
  }
  users: [ {type: Schema.ObjectId, ref: 'User'} ],
  tiles: [ {type: Schema.ObjectId, ref: 'Tile'} ]
})

let Team = mongoose.model('Team', teamSchema)

module.exports = Team