import {Tile} from '../../../shared/Tile'

export enum Players {
    RED, BLUE, YELLOW, GREEN
}

export interface State {
    tiles: {[k: number]: Tile},
    currentPlayer: Players.RED | Players.BLUE | Players.YELLOW | Players.GREEN,
    teams: any,
}
export const initialState: State = {
    tiles: {},
    currentPlayer: Players.BLUE,
    teams: {
        'blue': {},
        'yellow': {},
        'red': {},
        'green': {},
    }
}

export const reducer = (state = initialState, action: any) => {
    const {payload, type} = action
    switch(type) {
        case 'board/submit': {
            return {
                ...state,
                tiles: payload
            }
        }
        default: return state
    }
}

