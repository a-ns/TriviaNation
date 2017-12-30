import React, { Fragment } from "react";
import styled from "styled-components";
import { connect } from "react-redux";
import Button from "../../../Button/components/"
const Display = styled.div`
  grid-area: display;
  text-align: center;
`;
class Container extends React.Component {
  render() {
    return (
      <Display>
        <h1>{this.props.selectedItem.title}</h1>
        Question:
        <textarea placeholder={this.props.selectedItem.question} />
        <div>Answers:</div>
        <ul>
          {this.props.selectedItem.answers.map(answer => {
            return (
              <Fragment>
                <input type="radio" />
                <textarea />
              </Fragment>
            );
          })}
        </ul>
        <Button
          backgroundColor="blue"
          onClick={() =>
            this.props.dispatch({ type: "display/answers/append" })
          }
        >
          +
        </Button>
      </Display>
    );
  }
}

const mapStateToProps = state => ({
  selectedItem: state.editingTiles[state.selectedItem]
});
export default connect(mapStateToProps)(Container);
