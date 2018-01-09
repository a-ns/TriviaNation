const app = require("express")();
const http = require("http").Server(app);
const io = require("socket.io")(http);

io.on("connection", socket => {
  console.log(socket.id, "connected");
  socket.on("disconnect", () => {
    console.log(socket.id, "has disconnected");
  });
  socket.on("action", action => {
    switch (action.type) {
      case "tiles/titles/req": {
        const rv = {
          0: { num: 0, title: "History 1" },
          1: { num: 1, title: "History 3" },
          2: { num: 2, title: "Math 4" },
          3: { num: 3, title: "Science 2" },
        };
        socket.emit("action", { type: "tiles/titles/suc", payload: rv });
        break;
      }
      case 'tile/info/req': {
        let num = action.tileNum;
        const rv = {
          num,
          question: `What is the answer to this question ${num}?`,
          answers: ["A", "B", "C", "D"]
        };
        socket.emit('action', {type: 'tile/info/suc', payload: rv})
        break;
      }
      case 'board/submit': {
        let errors = []
        console.log(action)
        Object.values(action.payload.tiles).map(tile => {
          if(tile.num === 0 || tile.num === 5 || tile.num === 30 || tile.num === 35) {
            //skip, it's a Team tile
          }
          else if(!tile.answers || tile.answers.length === 0 || tile.answers.length === 1) {
            errors.push({tile, error: 'A tile must have at least two answers'})
          }
        })
        if(errors.length > 0) {
          console.log('error have occured in board/submit')
          socket.emit('action', {type:'board/submit/err', payload: errors})
        }
        else {
          /* All tiles are ok */
          /* Save tiles and send back tiles*/
          socket.emit('action', {type: 'board/submit/suc', payload: action.payload})
        }
        break;
      }
    }
  });
});

http.listen(8080, () => {
  console.log("listening on *:8080");
});
module.exports = app;
