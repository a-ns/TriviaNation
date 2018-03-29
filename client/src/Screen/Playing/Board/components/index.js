import React, {Fragment} from "react";
import {connect} from 'react-redux'
import Tile from '../../../../Tile/components'
class PlayingBoard extends React.Component {
  click(index){
    //display this tile's info
  }
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
const mapStateToProps = state => ({
  tiles: state.tiles
})
export default connect(mapStateToProps)(PlayingBoard);
