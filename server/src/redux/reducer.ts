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
    [Players.ONE]: { members: [] as Array<any>, ownedTiles: [] as ServerTile[] },
    [Players.TWO]: { members: [] as Array<any>, ownedTiles: [] as ServerTile[] },
    [Players.THREE]: { members: [] as Array<any>, ownedTiles: [] as ServerTile[] },
    [Players.FOUR]: { members: [] as Array<any>, ownedTiles: [] as ServerTile[] }
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
      const tiles = state.tiles.map(tile => {
        if (tile.num === payload.tileNum) {
          tile.hasBeenAnswered = true;
        }
        allAnswered.push(tile.hasBeenAnswered)
        return tile
      });
      if(allAnswered.every(Boolean)){
        state.gameFinished = true
      }
      return {
        ...state,
        tiles,
        teams: {
          ...state.teams,
          [state.currentPlayer]: {
            ...state.teams[state.currentPlayer],
            ownedTiles: [
              ...state.teams[state.currentPlayer].ownedTiles,
              payload.tileNum
            ]
          }
        },
        currentPlayer: (state.currentPlayer + 1) % (Players.FOUR + 1)
      };
    }
    case 'team/select': {
      const { selectedTeam } = action.payload;
    }
    default:
      return state;
  }
};
