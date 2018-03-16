import React from "react";
import { connect } from "react-redux";
import styled from "styled-components";
import PlayingBoard from "./Playing/components";
import EditingBoard from "./Editing/components";

const Board = styled.span`
  height: 100vh;
  margin-left: 25px;
  grid-area: board;
  display: grid;
  grid-template-columns: repeat(6, 1fr);
  grid-template-rows: repeat(6, 1fr);
`;

export default connect(state => ({ editingMode: state.editing.isEditing }))(
  class extends React.Component {
    render() {
      return (
        <Board>
          {this.props.editingMode ?  <EditingBoard /> : <PlayingBoard />}
        </Board>
      )
    }
  }
);