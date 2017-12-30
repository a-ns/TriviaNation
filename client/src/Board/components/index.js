import React from "react";
import Tile from "../../Tile/components";
import styled from "styled-components";
import { connect } from "react-redux";
const Board = styled.span`
  height: 100vh;
  margin-left: 25px;
  grid-area: board;
  display: grid;
  grid-template-columns: repeat(6, 1fr);
  grid-template-rows: repeat(6, 1fr);
`;

class CreateGame extends React.Component {
  editTileTitle(e, index) {
    e.preventDefault();
    // let editingTiles = this.state.editingTiles;
    // editingTiles[index].title = e.target.value;
    // this.setState({ editingTiles });
    this.props.dispatch({type: 'editingTile/title/update', payload: {num: index, content: e.target.value}})
  }
  submitBoard(board) {}
  selectTile(index) {
    this.props.dispatch({
      type: "selectedItemIndex",
      payload: index
    });
  }
  render() {
    if (this.props.editingMode) {
      return (
        <Board>
          {Object.values(this.props.editingTiles).map((tile, index) => {
            if (index == 0 || index == 5 || index == 30 || index == 35)
              return <Tile>{tile.title}</Tile>;
            return (
              <Tile
                onClick={() => this.selectTile(tile.num)}
              >
                <textarea
                  style={{
                    minWidth: "90%",
                    minHeight: "90%",
                    maxHeight: "90%",
                    maxWidth: "90%"
                  }}
                  name="title"
                  type="text"
                  value={tile.title}
                  onChange={e => this.editTileTitle(e, tile.num)}
                
                />
              </Tile>
            );
          })}
        </Board>
      );
    } else {
      return (
        <Board>
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
        </Board>
      );
    }
  }
}
const mapStateToProps = state => ({
  editingMode: state.editingMode,
  editingTiles: state.editingTiles
});
export default connect(mapStateToProps)(CreateGame);
