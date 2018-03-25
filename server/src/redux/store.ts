import {createStore} from 'redux'
import {reducer, State} from './reducer'
export interface Store {
    dispatch(action: { type: string; payload: any; meta?: any }): any;
    getState(): State;
}
const store: Store = createStore(reducer as any)

export default store