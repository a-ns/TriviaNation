import React, { Fragment } from "react";
import styled from "styled-components";
import { connect } from "react-redux";
import Tile from "../../../../Tile/components";
class EditingBoard extends React.Component {
  editTileTitle(e, index) {
    e.preventDefault();
    this.props.dispatch({
      type: "editingTile/title/update",
      payload: { num: index, title: e.target.value }
    });
  }
  selectTile(index) {
    this.props.dispatch({
      type: "selectedItemIndex",
      payload: index
    });
  }
  render() {
    return (
      <Fragment>
        {Object.values(this.props.editingTiles).map((tile, index) => {
          if (index == 0 || index == 5 || index == 30 || index == 35)
            return <Tile key={index}>{tile.title}</Tile>;
          return (
            <Tile onClick={() => this.selectTile(tile.num)} key={index}>
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
                onFocus={e => this.selectTile(tile.num)}
              />
            </Tile>
          );
        })}
      </Fragment>
    );
  }
}
const mapStateToProps = state => ({
  editingTiles: state.editing.tiles
});
export default connect(mapStateToProps)(EditingBoard);
