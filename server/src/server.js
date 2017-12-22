const app = require("express")();
const http = require("http").Server(app);
const io = require("socket.io")(http);

io.on("connection", socket => {
  console.log(socket.id, "connected");
  socket.on("disconnect", () => {
    console.log(socket.id, "has disconnected");
  });
  socket.on("tile/info/req", (data, fn) => {
    let num = data.num;
    const rv = {
      num,
      title: `History Question ${num}`,
      question: `What is the answer to this question ${num}?`,
      answers: ["A", "B", "C", "D"]
    };
    console.log("emitting", rv, "to", socket.id);
    fn(rv);
  });
  socket.on("tiles/titles/req", (data, fn) => {
    console.log("hi");
    const rv = {
      0: { num: 0, title: "History 1" },
      1: { num: 1, title: "History 3" },
      2: { num: 2, title: "Math 4" },
      3: { num: 3, title: "Science 2" }
    };
    fn(rv);
  });
});

http.listen(8080, () => {
  console.log("listening on *:8080");
});
module.exports = app;
