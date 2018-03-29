import React, { Component } from 'react';
import './App.css';
import Tile from './Tile/components/';
import { connect } from 'react-redux';
import TeamSelect from './TeamSelect/components';
import Screen from './Screen'
import Button from './Button/components';
class App extends Component {
  submitBoard(board) {
    this.props.dispatch({
      meta: 'socket',
      type: 'board/submit',
      payload: { tiles: board }
    });
  }
  render() {
    // const gameCanStart = (function gameCanStart(teams) {
    //   return (
    //     teams && teams[0] > 0 && teams[1] > 0 && teams[2] > 0 && teams[3] > 0
    //   ); // there is at least one person on each team
    // })(this.props.teams);
    // if (!this.props.isOnTeam || !gameCanStart) {
    //   return (
    //     <React.Fragment>
    //       <TeamSelect />
    //     </React.Fragment>
    //   );
    // }
    return (
        <div id="container">
          <Screen />
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
