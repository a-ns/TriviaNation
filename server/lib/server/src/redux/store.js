"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var redux_1 = require("redux");
var reducer_1 = require("./reducer");
var store = redux_1.createStore(reducer_1.reducer);
exports.default = store;
