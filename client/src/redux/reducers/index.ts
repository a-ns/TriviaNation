import { combineReducers } from 'redux'
import { editingReducer } from './editing'
import { playingReducer } from './playing'
import { selectedReducer } from './selected'
export default combineReducers({
  playing: playingReducer,
  editing: editingReducer,
  selectedItem: selectedReducer
})