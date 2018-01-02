import React, { Fragment } from "react";
import styled from "styled-components";
import { connect } from "react-redux";
import Button from "../../../Button/components/";
const Display = styled.div`
  grid-area: display;
  text-align: center;
`;
class EditingDisplay extends React.Component {
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
              <Fragment key={Math.random()}>
                <input type="radio" />
                <textarea />
              </Fragment>
            );
          })}
        </ul>
        <Button backgroundColor="blue" onClick={() => {}}>
          +
        </Button>
      </Display>
    );
  }
}

const mapStateToProps = state => ({
  selectedItem: state.editingTiles[state.selectedItem]
});
export default connect(mapStateToProps)(EditingDisplay);
