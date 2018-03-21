// const app = require("express")();
// const http = require("http").Server(app);
// const io = require("socket.io")(http);
// const store = require('./redux/store')
// import * as express from 'express'
// import * as socketIO from 'socket.io'
import {Tile} from '../../shared/Tile'
import {State, Players} from './redux/reducer'
export class Server {
  io: SocketIO.Server;
  http: any;
  app: Express.Application;
  store: {
    dispatch(action: {type: string, payload: any, meta?: any}): any,
    getState(): State
  }
  constructor(store: any){
    this.app = require('express')()
    this.http = require('http').Server(this.app)
    this.io = require('socket.io')(this.http)
    this.store = store
    this.listen();
  }

  private listen(): void {
    this.io.on("connection", (socket: SocketIO.Socket) => {
      console.log(socket.id, "connected");
      socket.on("disconnect", () => {
        console.log(socket.id, "has disconnected");
      });
      socket.on("action", (action: any) => {
        switch (action.type) {
          case "tiles/titles/req": {
            const rv = this.store.getState().tiles
            socket.emit("action", { type: "tiles/titles/suc", payload: rv });
            break;
          }
          case 'tile/info/req': {
            let num = action.tileNum;
            let tiles = this.store.getState().tiles
            let rv;
            tiles.forEach((tile) => {
              if(tile.num === num){
                rv = tile
                return;
              }
            })
            socket.emit('action', {type: 'tile/info/suc', payload: rv})
            break;
          }
          case 'board/submit': {
            let errors: Array<{tile: Tile, error: string}> = []
            action.payload.tiles.map((tile: Tile) => {
              if((!tile.answers || tile.answers.length === 0 || tile.answers.length === 1) && !(tile.num === 0 || tile.num === 5 || tile.num === 30 || tile.num === 35)) {
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
              this.store.dispatch({type: 'board/submit', payload: action.payload.tiles});
              socket.emit('action', {type: 'board/submit/suc', payload: action.payload})
            }
            break;
          }
          case 'answer/submit': {
            //check to see if it is that person's turn
            if(this.store.getState().currentPlayer !== action.payload.player) {
              // do nothing
              break;
            }
            else { // it is that person's turn
              this.store.dispatch(action)
              //signal new players turn
              if(this.store.getState().gameFinished){ //signal game over, send the scores
                let { teams } = this.store.getState()
                let scores = {
                  [Players.ONE]: teams[Players.ONE].ownedTiles.length,
                  [Players.TWO]: teams[Players.TWO].ownedTiles.length,
                  [Players.THREE]: teams[Players.THREE].ownedTiles.length,
                  [Players.FOUR]: teams[Players.FOUR].ownedTiles.length
                }
                socket.emit('action', {type: 'done', payload: scores })
              }
              else {
                socket.emit('action', {type: 'nextTurn', payload: this.store.getState().currentPlayer }) 
              }
              break;
            }
          }
          case 'team/select': { // person has selected a team to be on
            this.store.dispatch({type: 'team/select', payload: action}) // client might be the payload instead of action
            const payload = {
              [Players.ONE]: this.store.getState().teams[Players.ONE].members.length,
              [Players.TWO]: this.store.getState().teams[Players.TWO].members.length,
              [Players.THREE]: this.store.getState().teams[Players.THREE].members.length,
              [Players.FOUR]: this.store.getState().teams[Players.FOUR].members.length
            }
            socket.emit('action', {type: 'team/members', payload}) // send info about how many people are on each team
            break;
          }
        }
      });
    });
    
    this.http.listen(process.env.SERVER_PORT || 8081, () => {
      console.log("listening on *:8081");
    });
  }

  public get(){
    return this
  }
}

