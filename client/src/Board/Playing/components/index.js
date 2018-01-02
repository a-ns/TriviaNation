import React, {Fragment} from "react";
import {connect} from 'react-redux'
import Tile from '../../../Tile/components'
class PlayingBoard extends React.Component {
  render() {
    return (
      <Fragment>
        {Object.values(this.props.tiles).map((tile, index) => {
          let content = tile.title || index;
          return (
            <Tile
              key={index}
              tabIndex="0"
              owner="red"
              onClick={() => this.click(index)}
            >
              {content}
            </Tile>
          );
        })}
      </Fragment>
    );
  }
}

export default PlayingBoard;
