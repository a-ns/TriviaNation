import { Tile } from '../../../shared/Tile';
export declare enum Players {
    RED = 0,
    BLUE = 1,
    YELLOW = 2,
    GREEN = 3,
}
export interface State {
    tiles: {
        [k: number]: Tile;
    };
    currentPlayer: Players.RED | Players.BLUE | Players.YELLOW | Players.GREEN;
    teams: any;
}
export declare const initialState: State;
export declare const reducer: (state: State | undefined, action: any) => {
    tiles: any;
    currentPlayer: Players;
    teams: any;
};
