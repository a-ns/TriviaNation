import { Tile } from '../../../../shared/Tile';
const defaultPlayingTiles = () => {
  let tiles: Array<Tile> = [];
  for (let i = 0; i < 36; i++) {
    tiles.push({
      num: i,
      title: `Default ${i}`,
      question: `what is the answer to this question ${i}`,
      answers: []
    });
  }
  tiles[0] = {
    num: 0,
    title: 'Team 1',
    question: '',
    answers: []
  };
  tiles[5] = {
    num: 5,
    title: 'Team 2',
    question: '',
    answers: []
  };
  tiles[30] = {
    num: 30,
    title: 'Team 3',
    question: '',
    answers: []
  };
  tiles[35] = {
    num: 35,
    title: 'Team 4',
    question: '',
    answers: []
  };
  return tiles;
};

const initialState = {
  tiles: defaultPlayingTiles()
};
export type InitialState = typeof initialState;
export const playingReducer = (
  state: InitialState = initialState,
  action: any
) => {
  const { payload, type } = action;
  switch (type) {
    case 'tiles/titles/suc': {
      return { tiles: { ...state.tiles, ...payload } };
    }
    case 'tile/info/suc': {
      return {
        tiles: {
          ...state.tiles,
          [payload.num]: {
            ...state.tiles[payload.num],
            ...payload
          }
        }
      };
    }
    default:
      return state;
  }
};
