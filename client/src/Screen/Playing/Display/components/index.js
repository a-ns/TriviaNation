import React, { Fragment } from "react";
import styled from "styled-components";
import { connect } from "react-redux";
import Button from "../../../../Button/components";
const Display = styled.div`
  grid-area: display;
  text-align: center;
`;

class PlayingDisplay extends React.Component {
  handleAnswerClick(answer){
    //Do something, send to sever to see if it's right
  }
  render() {
    return (
      <Display>
        <h1>{this.props.question}</h1>
        <ul>
          {this.props.answers &&
            this.props.answers.map(answer => (
              <div key={answer}>
                <Button backgroundColor={"blue"} onClick={() => this.handleAnswerClick(answer)}>
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
  ...state.tiles[state.selectedItem]
});
export default connect(mapStateToProps)(PlayingDisplay);
