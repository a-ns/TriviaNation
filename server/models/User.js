var mongoose = require('mongoose')
var Schema = mongoose.Schema
var userSchema = new Schema({
  username: {
    type: String,
    required: true
  },
  password: {
    type: String,
    required: true
  }
})

// userSchema.methods.comparePassword = function (candidatePassword, cb) {
//   //put bcrypt stuff in here later maybe
//   return (candidatePassword === this.password)
// }

module.exports = mongoose.model('User', userSchema)
