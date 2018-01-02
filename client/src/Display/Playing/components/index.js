import React, { Fragment } from "react";
import styled from "styled-components";
import { connect } from "react-redux";
import Button from "../../../Button/components/";
const Display = styled.div`
  grid-area: display;
  text-align: center;
`;

class PlayingDisplay extends React.Component {
  render() {
    return (
      <Display>
        <h1>{this.props.selectedItem.question}</h1>
        <ul>
          {this.props.selectedItem.answers &&
            this.props.selectedItem.answers.map(answer => (
              <div key={answer}>
                <Button backgroundColor={"blue"} onClick={() => alert(answer)}>
                  {answer}
                </Button>
              </div>
            ))}
        </ul>
      </Display>
    );
  }
}
const mapStateToProps = state => ({
  selectedItem: state.playingTiles[state.selectedItem]
});
export default connect(mapStateToProps)(PlayingDisplay);
