import { Toast } from './type';
import { ActionTypes, Actions } from './actions'
const initialState = [] as Array<Toast>;
type State = typeof initialState;
const Toasts = (state: State = initialState, action: Actions): State => {
  switch (action.type) {
    case ActionTypes.TOAST_ADD: {
      const { payload } = action
      const nextState = [...state]
      nextState.push(payload)
      return nextState
    }
    case ActionTypes.TOAST_REMOVE: {
      const { payload } = action
      return state.filter(toast => toast.id !== payload);
    }
    default:
      return state;
  }
};

export const toastsReducer = Toasts;
