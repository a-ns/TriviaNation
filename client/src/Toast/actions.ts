import { Toast } from './type';
import { ActionsUnion, createAction } from '../../../shared/helpers/action-helpers';
const defaultTimeout = 5000;
export enum ActionTypes {
  TOAST_ADD = 'toast/add',
  TOAST_REMOVE = 'toast/remove',
  TOAST_ADD_TIMEOUT = 'toast/addTimeout'
}
export const Actions = {
  addToast: (toast: Toast) => createAction(ActionTypes.TOAST_ADD, toast),
  removeToast: (id: string) => createAction(ActionTypes.TOAST_REMOVE, id),
};
export const AsyncActions = {
    addToastWithTimeout: (toast: Toast, timeout: number = defaultTimeout): Function =>
        (dispatch: Function): void => {
            dispatch(Actions.addToast(toast))
            setTimeout(() => dispatch(Actions.removeToast(toast.id)), timeout)
        }
}
export type Actions = ActionsUnion<typeof Actions>;
