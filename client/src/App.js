import React, { Component } from "react";
import "./App.css";
import Tile from "./Tile/components/";
import { connect } from "react-redux";
import Button from "./Button/components";
import Display from "./Display/components";
class App extends Component {
  click(num) {
    this.props.dispatch({
      meta: "socket",
      type: "tile/info/req",
      tileNum: num
    });
  }

  componentDidMount() {
    this.props.dispatch({ meta: "socket", type: "tiles/titles/req" });
  }
  render() {
    return (
      <div id="container">
        <span id="board">
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
        </span>

        <Display>
          <h1>{this.props.selectedItem.question}</h1>
          <ul>
            {this.props.selectedItem.answers &&
              this.props.selectedItem.answers.map(answer => (
                <div key={answer}>
                  <Button
                    backgroundColor={"blue"}
                    onClick={() => alert(answer)}
                  >
                    {answer}
                  </Button>
                </div>
              ))}
          </ul>
        </Display>
      </div>
    );
  }
}

const mapStateToProps = state => ({
  tiles: state.tiles,
  selectedItem: state.selectedItem
});
export default connect(mapStateToProps)(App);
