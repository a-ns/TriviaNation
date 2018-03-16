import React, { Fragment } from "react";
import styled from "styled-components";
import { connect } from "react-redux";
import Button from "../../../Button/components/";
import {saveCurrentAnswersAction, toggleCorrectForTileAndAnswer, updateAnswerDesc} from '../actions'

const Li = styled.li`
  padding: 10px;
  margin: 5px;
  list-style-type: none;
`
const Input = styled.input`
  border: 1px solid black;
  padding: 5px;
  margin: 5px;
  width: 90%;
`
const Display = styled.div`
  grid-area: display;
  text-align: center;
  margin: 10px;
`;

const Ul = styled.ul`
  border: 2px solid #005cb2;
  height: 100%;
  background-color: #1e88e5
`

const Textarea = styled.textarea`
  width: 100%;
  margin: 0 auto;

`
class EditingDisplay extends React.Component {

  render() {
    return (
      <Display>
        Title:
        <input type='text' value={this.props.title} 
          onChange={(e) => {
            e.preventDefault()
            this.props.dispatch({type: 'editingTile/title/update', payload: {num: this.props.num, content: e.target.value}});
          }}
        />
        <br />
        Question:
        <Textarea placeholder={this.props.question}/>
        <div>Answers:</div>
        <Ul id='answers'>
          {this.renderOptions()}
        </Ul>
      </Display>
    );
  }
  renderOptions() {
    return this.props.answers.map(answer => {
      return ( 
        <Li key={`${this.props.num}${answer.id}`}>
          <Input type='checkbox' defaultChecked={answer.isCorrect} onChange={(e) => this.props.dispatch(toggleCorrectForTileAndAnswer(this.props.num, answer.id))}/>
          <Textarea type='text' value={answer.desc} 
            onChange={(e) => {
              e.preventDefault()
              this.props.dispatch(updateAnswerDesc(this.props.num, answer.id, e.target.value)); 
              this.forceUpdate()
            }}
            onFocus={(e) => {
              e.preventDefault()
            }}
          />
        </Li>
      )
    })
  }
}

const mapStateToProps = state => ({
  ...state.editing.tiles[state.default.selectedItem]
});
export default connect(mapStateToProps)(EditingDisplay);
