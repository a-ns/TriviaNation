import { combineReducers } from 'redux'
import { editingReducer, } from '../../Screen/Editing/reducer'
import { playingReducer, } from './playing'
import { selectedReducer, } from './selected'
import { teamSelectReducer } from '../../TeamSelect/reducer'

const rootReducer = combineReducers({
  playing: playingReducer,
  editing: editingReducer,
  selectedItem: selectedReducer,
  teamSelect: teamSelectReducer,
})
export default rootReducer