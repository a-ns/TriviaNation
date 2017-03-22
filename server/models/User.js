let mongoose = require('mongoose')
let Schema = mongoose.Schema
let userSchema = new Schema({
  username: {
    type: String,
    required: true
  },
  password: {
    type: String,
    required: true
  }
})

userSchema.methods.comparePassword = function (candidatePassword, cb) {
  //put bcrypt stuff in here later maybe
  return (candidatePassword === this.password)
}

let User = mongoose.model('User', userSchema)

module.exports = User
