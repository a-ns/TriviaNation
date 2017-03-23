var db = require('mongoose')
console.log('connecting to database')
try {
  db.connect(process.env.MONGODB_URI)
} catch (err) {
  db.createConnection(process.env.MONGODB_URI)
}

module.exports = db
