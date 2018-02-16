"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Server = (function () {
    function Server(store) {
        this.app = require('express')();
        this.http = require('http').Server(this.app);
        this.io = require('socket.io')(this.http);
        this.store = store;
        this.listen();
    }
    Server.prototype.listen = function () {
        var _this = this;
        this.io.on("connection", function (socket) {
            console.log(socket.id, "connected");
            socket.on("disconnect", function () {
                console.log(socket.id, "has disconnected");
            });
            socket.on("action", function (action) {
                switch (action.type) {
                    case "tiles/titles/req": {
                        var rv = _this.store.getState().tiles;
                        socket.emit("action", { type: "tiles/titles/suc", payload: rv });
                        break;
                    }
                    case 'tile/info/req': {
                        var num_1 = action.tileNum;
                        var tiles_1 = _this.store.getState().tiles;
                        var rv_1;
                        Object.keys(tiles_1).map(function (key) { return tiles_1[key]; }).forEach(function (tile) {
                            if (tile.num === num_1) {
                                rv_1 = tile;
                                return;
                            }
                        });
                        socket.emit('action', { type: 'tile/info/suc', payload: rv_1 });
                        break;
                    }
                    case 'board/submit': {
                        var errors_1 = [];
                        Object.keys(action.payload.tiles).map(function (key) { return action.payload.tiles[key]; }).map(function (tile) {
                            if ((!tile.answers || tile.answers.length === 0 || tile.answers.length === 1) && !(tile.num === 0 || tile.num === 5 || tile.num === 30 || tile.num === 35)) {
                                errors_1.push({ tile: tile, error: 'A tile must have at least two answers' });
                            }
                        });
                        if (errors_1.length > 0) {
                            console.log('error have occured in board/submit');
                            socket.emit('action', { type: 'board/submit/err', payload: errors_1 });
                        }
                        else {
                            /* All tiles are ok */
                            /* Save tiles and send back tiles*/
                            _this.store.dispatch({ type: 'board/submit', payload: action.payload.tiles });
                            socket.emit('action', { type: 'board/submit/suc', payload: action.payload });
                        }
                        break;
                    }
                }
            });
        });
        this.http.listen(8081, function () {
            console.log("listening on *:8081");
        });
    };
    Server.prototype.get = function () {
        return this;
    };
    return Server;
}());
exports.Server = Server;
