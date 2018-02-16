"use strict";
var __assign = (this && this.__assign) || Object.assign || function(t) {
    for (var s, i = 1, n = arguments.length; i < n; i++) {
        s = arguments[i];
        for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
            t[p] = s[p];
    }
    return t;
};
Object.defineProperty(exports, "__esModule", { value: true });
var Players;
(function (Players) {
    Players[Players["RED"] = 0] = "RED";
    Players[Players["BLUE"] = 1] = "BLUE";
    Players[Players["YELLOW"] = 2] = "YELLOW";
    Players[Players["GREEN"] = 3] = "GREEN";
})(Players = exports.Players || (exports.Players = {}));
exports.initialState = {
    tiles: {},
    currentPlayer: Players.BLUE,
    teams: {
        'blue': {},
        'yellow': {},
        'red': {},
        'green': {},
    }
};
exports.reducer = function (state, action) {
    if (state === void 0) { state = exports.initialState; }
    var payload = action.payload, type = action.type;
    switch (type) {
        case 'board/submit': {
            return __assign({}, state, { tiles: payload });
        }
        default: return state;
    }
};
