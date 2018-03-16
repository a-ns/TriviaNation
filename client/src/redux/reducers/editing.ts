import { Tile } from '../../../../shared/Tile';
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
          isCorrect: false
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

type InitialState = typeof initialState
export const editingReducer = (state: InitialState = initialState, action: {type: string, payload: any }) => {
  const { type, payload } = action;
  switch (type) {
    case 'editingTiles/answers/update': {
      return {
        ...state,
        tiles: {
          ...state.tiles,
          [payload.num]: {
            ...state.tiles[payload.num],
            answers: payload.answers,
            correctAnswers: payload.correctAnswers
          }
        }
      };
    }
    case 'editingTile/tile/answer/toggle': {
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
    case 'editingTile/tile/answer/desc/update': {
      const tiles = [...state.tiles];
      tiles.forEach(tile => {
        if (tile.num === payload.tileId) {
          tile.answers.forEach(answer => {
            if (answer.id === payload.answerId) {
              answer.desc = payload.content;
            }
          });
        }
      });
      return {
        ...state,
        tiles: tiles
      };
    }
    case 'editingTile/title/update': {
      let tiles = [...state.tiles];
      tiles[payload.num].title = payload.content;
      return {
        ...state,
        tiles: tiles
      };
    }
    case 'editingTile/answers/update': {
      let tiles = [...state.tiles];
      tiles[payload.id].answers = payload.answers;
      return {
        ...state,
        tiles: [...tiles]
      };
    }
    default:
      return state;
  }
};
