// const app = require("express")();
// const http = require("http").Server(app);
// const io = require("socket.io")(http);
// const store = require('./redux/store')
// import * as express from 'express'
// import * as socketIO from 'socket.io'
import { Tile } from "../../shared/Tile";
import { State, Players } from "./redux/reducer";
import { ActionHandler } from './ActionHandler'
import { Store } from './redux/store'

function getMemberLengthOfTeams(teams: any) {
  return {
    [Players.ONE]: teams[Players.ONE].members.length,
    [Players.TWO]: teams[Players.TWO].members.length,
    [Players.THREE]: teams[Players.THREE].members.length,
    [Players.FOUR]: teams[Players.FOUR].members.length
  };
}
type foo = ReturnType<typeof getMemberLengthOfTeams>
export class Server {
  io: SocketIO.Server;
  http: any;
  app: Express.Application;
  actionHandler: ActionHandler;
  store: Store;
  constructor(store: Store, actionHandler: ActionHandler) {
    this.app = require("express")();
    this.http = require("http").Server(this.app);
    this.io = require("socket.io")(this.http);
    this.store = store;
    this.actionHandler = actionHandler
    this.listen();
  }
  private listen(): void {
    this.io.on("connection", (socket: SocketIO.Socket) => {
      this.io.emit("action", { type: "team/members", payload: getMemberLengthOfTeams(this.store.getState().teams) });
      socket.on("disconnect", () => {
        console.log(socket.id, "has disconnected");
        this.store.dispatch({type: 'player/left', payload: socket.id})
        this.io.emit('action', {type: 'team/members', payload: getMemberLengthOfTeams(this.store.getState().teams)})
      });
      socket.on("action", (action) => this.actionHandler({socket: socket, io: this.io, action, store: this.store}))
    });

    this.http.listen(process.env.SERVER_PORT || 8081, () => {
      console.log("listening on *:8081");
    });
  }

  public get() {
    return this;
  }
}
