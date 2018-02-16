/// <reference types="socket.io" />
/// <reference types="express-serve-static-core" />
export declare class Server {
    io: SocketIO.Server;
    http: any;
    app: Express.Application;
    store: {
        dispatch(action: {
            type: string;
            payload: any;
            meta?: any;
        }): any;
        getState(): any;
    };
    constructor(store: any);
    private listen();
    get(): this;
}
