// const app = require("express")();
// const http = require("http").Server(app);
// const io = require("socket.io")(http);
// const store = require('./redux/store')
// import * as express from 'express'
// import * as socketIO from 'socket.io'
import {Tile} from '../../shared/Tile'

export class Server {
  io: SocketIO.Server;
  http: any;
  app: Express.Application;
  store: {
    dispatch(action: {type: string, payload: any, meta?: any}): any,
    getState(): any
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
            let tiles: Array<Tile> = this.store.getState().tiles
            let rv;
            Object.keys(tiles).map((key: any) => tiles[key]).forEach((tile: Tile) => {
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
            Object.keys(action.payload.tiles).map(key => action.payload.tiles[key]).map((tile: Tile) => {
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
        }
      });
    });
    
    this.http.listen(8081, () => {
      console.log("listening on *:8081");
    });
  }

  public get(){
    return this
  }
}

