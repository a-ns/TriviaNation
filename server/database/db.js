var db = require('mongoose')
db.Promise = require('bluebird')
console.log('connecting to database')
try {
  db.connect(process.env.MONGODB_URI)
  console.log('connected to database')
} catch (err) {
  db.createConnection(process.env.MONGODB_URI)
}

module.exports = db
