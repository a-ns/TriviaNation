import { GameSaver } from '../index';
import * as fs from 'fs';

export const LocalFileSystemSaver: GameSaver = {
  save(game) {
    const json = JSON.stringify(game);
    return new Promise((resolve, reject) => {
      fs.writeFile('game.json', json, err => {
        if (err) {
          reject();
        } else resolve();
      });
    });
  },
  load() {
    const data = fs.readFileSync('game.json');
    return data.toJSON();
  }
};
