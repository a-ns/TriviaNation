// import { makeToast } from '../../Toast/actions';
// const toastTime = 5000;
// function checkForToastActionType(toastTypes: Array<string>, type: string): boolean {
//   for (let i = 0; i < toastTypes.length; i++) {
//     if (toastTypes[i] === type) {
//       return true;
//     }
//   }
//   return false;
// }
// const toastMiddleware = (...toasts: Array<string>) => (store: any) => (
//   next: any
// ) => (action: any) => {
//   if (action.type.includes('toast')) {
//     return next(action);
//   }
//   if (checkForToastActionType(toasts, action.type)) {
//     const type =
//       action.type.includes('error') || action.type.includes('err')
//         ? 'error'
//         : action.type.includes('success') || action.type.includes('succ')
//           ? 'success'
//           : 'info';
//     const toast = makeToast(type, action.payload);
//     store.dispatch((dispatch: any) => {
//       dispatch({ type: `toast/${type}`, payload: toast });
//       setTimeout(() => {
//         dispatch({ type: 'toast/remove', payload: toast.id });
//       }, toastTime);
//     });
//   }
//   return next(action);
// };

// export default toastMiddleware;
