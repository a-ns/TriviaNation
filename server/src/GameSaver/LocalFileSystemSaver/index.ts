import { GameSaver } from '../index';
import * as fs from 'fs';

export const LocalFileSystemSaver: GameSaver = {
  save(game) {
    const json = JSON.stringify(game);
    return new Promise<boolean>((resolve, reject) => {
      fs.writeFile('game.json', json, err => {
        if (err) {
          reject(err);
        } else resolve(true);
      });
    });
  },
  load() {
    const data = fs.readFileSync('game.json');
    return data.toJSON();
  }
};
