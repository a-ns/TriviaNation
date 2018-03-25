import React, { Component } from "react";
import "./App.css";
import Tile from "./Tile/components/";
import { connect } from "react-redux";
import Display from "./Display";
import Board from "./Board/";
import TeamSelect from "./TeamSelect/components";
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
    const gameCanStart = (function gameCanStart(teams) {
      console.log(teams)
      return (
        teams &&
        teams[0] > 0 &&
        teams[1] > 0 &&
        teams[2] > 0 &&
        teams[3] > 0
      ); // there is at least one person on each team
    })(this.props.teams);
    console.log('gamecanstart?', gameCanStart)
    if (!this.props.isOnTeam || !gameCanStart) {
      return <TeamSelect />;
    }
    return (
      <div>
        <Button
          onClick={e => {
            e.preventDefault();
            this.submitBoard(this.props.editingTiles);
          }}
        >
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

const mapStateToProps = state => {
  const isOnTeam = !(state.teamSelect.selectedTeam == -1);

  return {
    teams: state.teamSelect.amountOnEachTeam,
    isOnTeam,
    playingTiles: state.playing.tiles,
    editingTiles: state.editing.tiles
  };
};
export default connect(mapStateToProps)(App);
