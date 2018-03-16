export interface Answer {
    desc: string,
    id: number,
    isCorrect: boolean
}  
export interface Tile {
    num: number,
    question: string,
    answers: Array<Answer>,
    title: string
}

export interface Team {
    ownedTiles: object,
    players: [object]
}

export interface Game {
    teams: Array<Team>,
    tiles: Array<Tile>
}