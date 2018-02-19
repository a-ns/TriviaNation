import React, { Component } from "react";
import "./App.css";
import Tile from "./Tile/components/";
import { connect } from "react-redux";
import Display from "./Display";
import Board from "./Board/";
import Button from './Button/components'
class App extends Component {
  submitBoard(board){
    this.props.dispatch({
      meta: 'socket',
      type: 'board/submit',
      payload: {tiles: board}
    })
  }
  render() {
    return (
      <div id="container">
        <Board />
        <Display/>
        <Button onClick={() => this.submitBoard(this.props.editingTiles)}>
          Save Board
          </Button>
      </div>
    );
  }
}

const mapStateToProps = state => ({
  editingTiles: state.editingTiles
});
export default connect(mapStateToProps)(App);
