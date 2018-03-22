import deepcopy from 'ts-deepcopy'
import { Tile } from '../../../shared/Tile';

export enum Players {
  ONE,
  TWO,
  THREE,
  FOUR
}
export interface ServerTile extends Tile {
  hasBeenAnswered: boolean;
}
export const initialState = {
  tiles: [] as ServerTile[],
  currentPlayer: Players.TWO,
  gameFinished: false,
  teams: {
    [Players.ONE]: { members: [] as Array<string>, ownedTiles: [] as ServerTile[] },
    [Players.TWO]: { members: [] as Array<string>, ownedTiles: [] as ServerTile[] },
    [Players.THREE]: { members: [] as Array<string>, ownedTiles: [] as ServerTile[] },
    [Players.FOUR]: { members: [] as Array<string>, ownedTiles: [] as ServerTile[] }
  }
};

export type State = typeof initialState;
export const reducer = (state: State = initialState, action: any) => {
  const { payload, type } = action;
  switch (type) {
    case 'board/submit': {
      return {
        ...state,
        tiles: payload
      };
    }
    case 'answer/submitted': {
      const allAnswered: Array<boolean> = []
      let gameFinished = false;
      let stateCopy = deepcopy(state)
      const tiles = stateCopy.tiles.map(tile => {
        if (tile.num === payload.tileNum) {
          tile.hasBeenAnswered = true;
        }
        allAnswered.push(tile.hasBeenAnswered)
        return tile
      });
      if(allAnswered.every(Boolean)){
        gameFinished = true
      }
      return {
        ...stateCopy,
        tiles,
        gameFinished,
        teams: {
          ...stateCopy.teams,
          [stateCopy.currentPlayer]: {
            ...stateCopy.teams[stateCopy.currentPlayer],
            ownedTiles: [
              ...state.teams[stateCopy.currentPlayer].ownedTiles,
              payload.tileNum
            ]
          }
        },
        currentPlayer: (stateCopy.currentPlayer + 1) % (Players.FOUR + 1)
      };
    }
    case 'team/select': {
      const selectedTeam: Players = action.payload.selectedTeam
      const stateCopy = deepcopy(state)
      const {  player } = action.payload;
      const nextState = {
        ...stateCopy,
        teams: {
          ...stateCopy.teams,
          [selectedTeam]: {
            ...stateCopy.teams[selectedTeam],
            members: [...stateCopy.teams[selectedTeam].members, player]
          }
        }
      }
      return nextState
    }
    case 'player/left': {
      const stateCopy = deepcopy(state)
      for(let i: Players = 0; i < 4; i++){
        stateCopy.teams[i].members = stateCopy.teams[i].members.filter(member => {
          return member !== action.payload
        })
      }
      let nextState = {
        ...stateCopy
      }
      return nextState
    }
    default:
      return state;
  }
};
