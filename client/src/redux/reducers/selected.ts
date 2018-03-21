export const selectedReducer = (
  state: number = 1,
  action: { type: string; payload: number }
) => {
  switch (action.type) {
    case 'selectedItemIndex': {
      return action.payload
    }
    default:
      return state;
  }
};
