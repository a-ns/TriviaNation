const socketMiddlware = (
  socket,
  { actionName = "action", metaName = "socket" } = {}
) => {
  const emitter = socket.emit.bind(socket);
  return ({dispatch}) => {
    socket.on(actionName, dispatch);
    return next => action => {
      if (action.meta === metaName) {
        emitter(actionName, action);
      }
      return next(action);
    };
  };
};
export default socketMiddlware
