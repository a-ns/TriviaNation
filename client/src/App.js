import React, { Component } from "react";
import { socketConnect } from "socket.io-react";
import "./App.css";
import Tile from "./Tile/components/";

import Button from "./Button/components";
import Display from "./Display/components";
class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      tiles: {},
      selectedItem: {}
    };
    for (let i = 0; i < 36; i++) {
      this.state.tiles[i] = {
        num: i,
        title: "",
        question: "",
        answers: [],

        correctAnswer: null
      };
    }
    this.click = this.click.bind(this);
  }

  click(num) {
    this.props.socket.emit("tile/info/req", { num }, data => {
      this.setState(prevState => {
        return {
          ...prevState,
          tiles: {
            ...prevState.tiles,
            [data.num]: data
          },
          selectedItem: data
        };
      });
    });
  }

  componentDidMount() {
    this.props.socket.emit("tiles/titles/req", {}, data => {
      this.setState(prevState => {
        return {
          ...prevState,
          tiles: {
            ...prevState.tiles,
            ...data
          }
        };
      });
    });
  }
  render() {
    return (
      <div id="container">
        <span id="board">
          {Object.values(this.state.tiles).map((tile, index) => {
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
          <h1>{this.state.selectedItem.question}</h1>
          <ul>
            {this.state.selectedItem.answers &&
              this.state.selectedItem.answers.map(answer => (
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

export default socketConnect(App);
