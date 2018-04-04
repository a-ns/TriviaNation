import { Tile } from "../../shared/Tile";
import { State, Players } from "./redux/reducer";
import { Store } from './redux/store'
import * as ActionHelpers from './helpers/action-helpers'
import { LocalFileSystemSaver } from "./GameSaver/LocalFileSystemSaver";
export const TILES_TITLES_REQ = 'tiles/titles/req'
export const BOARD_SUBMIT_REQ = 'board/submit'
export const ANSWER_SUBMITTED = 'answer/submit'
export const TEAM_SELECTED = 'team/select'
export const TILE_INFO_REQ = 'tile/info/req'

export const Actions = {
  sendTilesInfo: () => ActionHelpers.createAction(TILES_TITLES_REQ),
  boardSubmit: (tiles: Array<Tile>) => ActionHelpers.createAction(BOARD_SUBMIT_REQ, {tiles}),
  answerSubmit: (player: number, tileId: number, answerId: number) => ActionHelpers.createAction(ANSWER_SUBMITTED, {player, tileId, answerId}),
  teamSelect: (selectedTeam: number, player: string) => ActionHelpers.createAction(TEAM_SELECTED, {selectedTeam, player}),
  sendTileInfo: (tileId: number) => ActionHelpers.createAction(TILE_INFO_REQ, {tileId})
}
export type Actions = ActionHelpers.ActionsUnion<typeof Actions>

export interface ActionHandler {
  (
    {
      socket,
      io,
      action,
      store
    }: { socket: SocketIO.Socket; io: SocketIO.Server; action: Actions; store: Store }
  ): void;
}

export const actionHandler: ActionHandler = ({ socket, io, action, store }) => {
  switch (action.type) {
    case TILES_TITLES_REQ: {
      const rv = store.getState().tiles;
      socket.emit("action", { type: "tiles/titles/suc", payload: rv });
      break;
    }
    case TILE_INFO_REQ: {
      let num = action.payload.tileId;
      let tiles = store.getState().tiles;
      let rv;
      tiles.forEach((tile: Tile) => {
        if (tile.num === num) {
          rv = tile;
          return;
        }
      });
      socket.emit("action", { type: "tile/info/suc", payload: rv });
      break;
    }
    case "board/submit": {
      let errors: Array<{ tile: Tile; error: string }> = [];
      action.payload.tiles.forEach((tile: Tile) => console.log(tile));
      action.payload.tiles.forEach((tile: Tile) => {
        // if((!tile.answers || tile.answers.length === 0 || tile.answers.length === 1) && !(tile.num === 0 || tile.num === 5 || tile.num === 30 || tile.num === 35)) {
        //   errors.push({tile, error: 'A tile must have at least two answers'})
        // }
        if (
          !tileHasAtLeast1Answer(tile) &&
          !(
            tile.num === 0 ||
            tile.num === 5 ||
            tile.num === 30 ||
            tile.num === 35
          )
        ) {
          errors.push({
            tile,
            error: "A tile must have at least one correct answer"
          });
        }
      });
      if (errors.length > 0) {
        console.log("error have occured in board/submit");
        console.log("Number of errors: ", errors.length);
        socket.emit("action", {
          type: "board/submit/err",
          payload: errors
        });
      } else {
        /* All tiles are ok */
        /* Save tiles and send back tiles*/
        store.dispatch({
          type: "board/submit",
          payload: action.payload.tiles
        });

        LocalFileSystemSaver.save(store.getState());
        socket.emit("action", {
          type: "board/submit/suc",
          payload: action.payload
        });
      }
      break;
    }
    case ANSWER_SUBMITTED: {
      //check to see if it is that person's turn
      if (store.getState().currentPlayer !== action.payload.player) {
        // do nothing
        break;
      } else {
        // it is that person's turn
        store.dispatch(action);
        //signal new players turn
        if (store.getState().gameFinished) {
          //signal game over, send the scores
          let { teams } = store.getState();
          let scores = {
            [Players.ONE]: teams[Players.ONE].ownedTiles.length,
            [Players.TWO]: teams[Players.TWO].ownedTiles.length,
            [Players.THREE]: teams[Players.THREE].ownedTiles.length,
            [Players.FOUR]: teams[Players.FOUR].ownedTiles.length
          };
          socket.emit("action", { type: "done", payload: scores });
        } else {
          socket.emit("action", {
            type: "nextTurn",
            payload: store.getState().currentPlayer
          });
        }
        break;
      }
    }
    case TEAM_SELECTED: {
      // person has selected a team to be on
      store.dispatch({
        type: "team/select",
        payload: {
          selectedTeam: action.payload.selectedTeam,
          player: socket.id
        }
      });
      
      // send info about how many people are on each team and the team they joined
      io.emit("action", {
        type: "team/members",
        payload: getMemberLengthOfTeams(store.getState().teams)
      });
      socket.emit("action", {
        type: "team/join/success",
        payload: { ...action }
      });

      break;
    }
  }
}

function tileHasAtLeast1Answer(tile: Tile): boolean {
  return tile.answers.some(answer => {
    return answer.isCorrect;
  });
}
function getMemberLengthOfTeams(teams: any) {
  return {
    [Players.ONE]: teams[Players.ONE].members.length,
    [Players.TWO]: teams[Players.TWO].members.length,
    [Players.THREE]: teams[Players.THREE].members.length,
    [Players.FOUR]: teams[Players.FOUR].members.length
  };
}
