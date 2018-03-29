import { Tile } from '../../../../shared/Tile';
import { ActionTypes, Actions } from './actions'
const defaultEditingTiles = () => {
  let tiles: Array<Tile> = [];
  for (let i = 0; i < 36; i++) {
    tiles.push({
      num: i,
      title: `Click to edit title`,
      question: `click to edit question`,
      answers: [
        {
          id: 0,
          desc: 'click to edit answers',
          isCorrect: true
        },
        {
          id: 1,
          isCorrect: false,
          desc: 'click to edit answers'
        },
        {
          id: 2,
          desc: 'click to edit answers',
          isCorrect: false
        },
        {
          id: 3,
          desc: 'click to edit answers',
          isCorrect: false
        }
      ]
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
  isEditing: true,
  tiles: defaultEditingTiles()
};

export type InitialState = typeof initialState;
export const editingReducer = (
  state: InitialState = initialState,
  action: Actions
) => {

  switch (action.type) {
    case ActionTypes.EDITING_TILE_ANSWER_TOGGLE: {
      const { payload } = action
      let tiles = [...state.tiles];
      tiles.forEach(tile => {
        if (tile.num === payload.tileId) {
          tile.answers.forEach(answer => {
            if (answer.id === payload.answerId) {
              answer.isCorrect = !answer.isCorrect;
            }
          });
        }
      });
      return {
        ...state,
        tiles
      };
    }
    case ActionTypes.EDITING_TILE_ANSWER_DESC_UPDATE: {
      const { payload } = action
      const tiles = [...state.tiles];
      tiles.forEach(tile => {
        if (tile.num === payload.tileId) {
          tile.answers.forEach(answer => {
            if (answer.id === payload.answerId) {
              answer.desc = payload.value;
            }
          });
        }
      });
      return {
        ...state,
        tiles
      };
    }
    case ActionTypes.EDITING_TILE_TITLE_UPDATE: {
      
      const { payload } = action
      let tiles = [...state.tiles];
      tiles[payload.num].title = payload.title;
      return {
        ...state,
        tiles
      };
    }
    case ActionTypes.EDITING_TILE_ANSWERS_UPDATE: {
      
      const { payload } = action
      let tiles = [...state.tiles];
      tiles[payload.tileId].answers = payload.answers;
      return {
        ...state,
        tiles
      };
    }
    case ActionTypes.EDITING_TILE_QUESTION_UPDATE: {
      const { payload } = action
      let tiles = [...state.tiles];
      tiles[payload.tileId].question = payload.value
      return {
        ...state,
        tiles
      }
    }
    default:
      return state;
  }
};
