import {Tile} from '../../../shared/Tile'

export enum Players {
    ONE, TWO, THREE, FOUR
}

export interface State {
    tiles: Array<Tile>,
    currentPlayer: Players.ONE | Players.TWO | Players.THREE | Players.FOUR,
    teams: any,
}

export const initialState: State = {
    tiles: [],
    currentPlayer: Players.TWO,
    teams: {
        [Players.ONE]: {},
        [Players.TWO]: {},
        [Players.THREE]: {},
        [Players.FOUR]: {},
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

