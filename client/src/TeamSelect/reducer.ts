const initialState = {
    selectedTeam: -1,
    amountOnEachTeam: [] as Array<number>
}
type InitialState = typeof initialState
export const teamSelectReducer = (state: InitialState = initialState, action: any) => {
    switch (action.type) {
        case 'team/members': {
            return {
                ...state,
                amountOnEachTeam: action.payload
            }
        }
        case 'team/join/success': {
            return {
                ...state,
                selectedTeam: action.payload.selectedTeam
            }
        }
        default: return state
    }
}