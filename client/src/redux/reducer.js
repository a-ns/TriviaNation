const defaultTiles = () => {
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

const initialState = {
  tiles: defaultTiles(),
  selectedItem: {}
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
        },
        selectedItem: payload
      };
    }
    default:
      return state;
  }
};
