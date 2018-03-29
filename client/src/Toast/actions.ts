import { Toast  } from './type'
import { ActionsUnion, createAction } from '../helpers/action-helpers'

export enum ActionTypes {
    TOAST_ADD = 'toast/add',
    TOAST_REMOVE = 'toast/remove'
}

export const actions = {
    addToast: (toast: Toast) => createAction(ActionTypes.TOAST_ADD, toast),
    removeToast: (id: string) => createAction(ActionTypes.TOAST_REMOVE, id)
}

export type Actions = ActionsUnion<typeof actions>