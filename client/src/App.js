import React, { Component } from "react";
import "./App.css";
import Tile from "./Tile/components/";
import { connect } from "react-redux";
import Display from "./Display";
import Board from "./Board/";

class App extends Component {
  click(num) {
    this.props.dispatch({
      meta: "socket",
      type: "tile/info/req",
      tileNum: num
    });
    this.props.dispatch({
      type: "selectedItemIndex",
      payload: num
    });
  }

  componentDidMount() {
    this.props.dispatch({ meta: "socket", type: "tiles/titles/req" });
  }
  render() {
    return (
      <div id="container">
        <Board />

        <Display/>
      </div>
    );
  }
}

const mapStateToProps = state => ({
  tiles: state.tiles,
  selectedItem: state.selectedItem
});
export default connect(mapStateToProps)(App);
