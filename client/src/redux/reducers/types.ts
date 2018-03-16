import { Tile } from '../../../../shared/Tile';
export interface TileReturner {
  (): Array<Tile>;
}
