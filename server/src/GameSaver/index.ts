export interface GameSaver {
    save(game: any): Promise<boolean>,
    load(): any
}


