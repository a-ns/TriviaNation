import store from './redux/store'
import * as Server from './server'

const server: Server.Server = new Server.Server(store).get();

export default server
