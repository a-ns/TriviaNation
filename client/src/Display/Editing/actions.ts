
export const saveCurrentAnswersAction = (id: number, answers: any) => {
    return { type: 'editingTile/answers/update', payload: {id, answers}}
}
export const toggleCorrectForTileAndAnswer = (tileId: number, answerId: any) => {
    return { type: 'editingTile/tile/answer/toggle', payload: {tileId, answerId}}
}

export const updateAnswerDesc = (tileId: number, answerId: number, content: any) => {
    return { type: 'editingTile/tile/answer/desc/update', payload: {tileId, answerId, content}}
}