module.exports = function () {
  var commands = []
  commands.push('connection')
  commands.push('message')
  commands.push('answerClicked')
  commands.push('questionClicked')
  commands.push('scoreUpdate')
  commands.push('login')
  commands.push('signup')
  commands.push('saveGame')
  commands.push('loadGame')
  commands.push('joinTeam')
  commands.push('startGame')
  commands.push('yourTurn')
  return commands
}
