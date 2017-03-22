let mongoose = require('mongoose')
let Schema = mongoose.Schema

let teamSchema = new Schema({
  teamName: {
    type: String,
    required: true
  },
  teamColor: {
    type: String,
    required: true
  },
  Users: [ {type: Schema.ObjectId, ref: 'User'} ],
  Tiles: [ {type: Schema.ObjectId, ref: 'Tile'} ]
})

let Team = mongoose.model('Team', teamSchema)

module.exports = Team
