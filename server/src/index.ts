import store from './redux/store'
import * as Server from './server'
import { actionHandler } from './ActionHandler'
const server: Server.Server = new Server.Server(store, actionHandler).get();

export default server
