import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./App";
import registerServiceWorker from "./registerServiceWorker";
import io from "socket.io-client";
import { SocketProvider } from "socket.io-react";

const socket = io.connect("http://localhost:8080");
ReactDOM.render(
  <SocketProvider socket={socket}>
    <App />
  </SocketProvider>,
  document.getElementById("root")
);
registerServiceWorker();
