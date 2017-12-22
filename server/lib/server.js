const app = require("express")();
const http = require("http").Server(app);
const io = require("socket.io")(http);

io.on("connection", socket => {
  console.log(socket.id, "connected");
  socket.on("disconnect", () => {
    console.log(socket.id, "has disconnected");
  });
  socket.on("click", (data, fn) => {
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
});

http.listen(8080, () => {
  console.log("listening on *:8080");
});
module.exports = app;
