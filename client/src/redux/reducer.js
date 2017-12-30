const defaultPlayingTiles = () => {
  let tiles = {};
  for (let i = 0; i < 36; i++) {
    tiles[i] = {
      num: i,
      title: `Default ${i}`,
      question: `what is the answer to this question ${i}`
    };
  }
  return tiles;
};
const defaultEditingTiles = () => {
  let tiles = {};
  for (let i = 0; i < 36; i++) {
    tiles[i] = {
      num: i,
      title: `Click to edit title`,
      question: `click to edit question`,
      answers: ["click to edit answers"]
    };
  }
  tiles[0] = {
    title: "Team 1"
  };
  tiles[5] = {
    title: "Team 2"
  };
  tiles[30] = {
    title: "Team 3"
  };
  tiles[35] = {
    title: "Team 4"
  };
  return tiles;
};


const initialState = {
  tiles: defaultPlayingTiles(),
  selectedItem: 1,
  editingMode: true,
  editingTiles: defaultEditingTiles()
};

export default (state = initialState, action) => {
  const { payload, type } = action;
  switch (type) {
    case "tiles/titles/suc": {
      return { ...state, tiles: { ...state.tiles, ...payload } };
    }
    case "tile/info/suc": {
      return {
        ...state,
        tiles: {
          ...state.tiles,
          [payload.num]: {
            ...state.tiles[payload.num],
            ...payload
          }
        }
      };
    }
    case "selectedItemIndex": {
      return {
        ...state,
        selectedItem: payload
      }
    }
    case "editingTile/title/update": {
      return {
        ...state,
        editingTiles: {
          ...state.editingTiles,
          [payload.num]: {
            ...state.editingTiles[payload.num],
            title: payload.content
          }
        }
      }
    }
    default:
      return state;
  }
};
