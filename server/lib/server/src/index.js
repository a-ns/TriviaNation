"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var store_1 = require("./redux/store");
var Server = require("./server");
var server = new Server.Server(store_1.default).get();
exports.default = server;
