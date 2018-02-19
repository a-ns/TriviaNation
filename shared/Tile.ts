export interface Answer {
    desc: string,
    isCorrect: boolean
}  
export interface Tile {
    num: number,
    question: string,
    answers: Array<Answer>,
    title: string
}