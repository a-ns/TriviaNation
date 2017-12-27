const app = require("express")();
const http = require("http").Server(app);
const io = require("socket.io")(http);

io.on("connection", socket => {
  console.log(socket.id, "connected");
  socket.on("disconnect", () => {
    console.log(socket.id, "has disconnected");
  });
  socket.on("action", data => {
    switch (data.type) {
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
        let num = data.tileNum;
        const rv = {
          num,
          question: `What is the answer to this question ${num}?`,
          answers: ["A", "B", "C", "D"]
        };
        socket.emit('action', {type: 'tile/info/suc', payload: rv})
        break;
      }
    }
  });
});

http.listen(8080, () => {
  console.log("listening on *:8080");
});
module.exports = app;
