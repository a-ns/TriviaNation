import React, { Component } from "react";
import "./App.css";
import Tile from "./Tile/components/";
import { connect } from "react-redux";
import Display from "./Display";
import Board from "./Board/";
import TeamSelect from './TeamSelect/components'
import Button from "./Button/components";
class App extends Component {
  submitBoard(board) {
    this.props.dispatch({
      meta: "socket",
      type: "board/submit",
      payload: { tiles: board }
    });
  }
  render() {
    if(this.props.isOnTeam == -1) {
      return <TeamSelect />
    }
    return (
      <div>
        <Button onClick={(e) => {
          e.preventDefault()
          this.submitBoard(this.props.editingTiles)
        }}>
          Submit
          </Button>
        <div id="container">
          <Board />
          <Display />
        </div>
      </div>
    );
  }
}

const mapStateToProps = state => ({
  isOnTeam: state.teamSelect.selectedTeam,
  playingTiles: state.playing.tiles,
  editingTiles: state.editing.tiles
});
export default connect(mapStateToProps)(App);
