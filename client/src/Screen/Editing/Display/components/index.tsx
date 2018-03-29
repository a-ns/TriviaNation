import * as React from 'react';
import styled from 'styled-components';
import { connect } from 'react-redux';
import { actions } from '../../actions';

const Li = styled.li`
  padding: 10px;
  margin: 5px;
  list-style-type: none;
`;
const Input = styled.input`
  border: 1px solid black;
  padding: 5px;
  margin: 5px;
  width: 90%;
`;
const Display = styled.div`
  grid-area: display;
  text-align: center;
  margin: 10px;
`;

const Ul = styled.ul`
  border: 2px solid #005cb2;
  height: 100%;
  background-color: #1e88e5;
`;

const Textarea = styled.textarea`
  width: 100%;
  margin: 0 auto;
` as any;
class EditingDisplay extends React.Component<any, any> {
  constructor(props: any) {
    super(props);
  }
  render() {
    return (
      <Display>
        Title:
        <input
          type="text"
          value={this.props.title}
          onChange={e => {
            e.preventDefault();
            this.props.dispatch(
              actions.updateTitle(e.target.value, this.props.num)
            );
          }}
        />
        <br />
        Question:
        <Textarea
          value={this.props.question}
          placeholder={this.props.question}
          onChange={(e: any) => {
            e.preventDefault();
            this.props.dispatch(
              actions.updateQuestion(this.props.num, e.target.value)
            );
            this.forceUpdate();
          }}
        />
        <div>Answers:</div>
        <Ul id="answers">{this.renderOptions()}</Ul>
      </Display>
    );
  }
  renderOptions() {
    return this.props.answers.map((answer: any) => {
      return (
        <Li key={`${this.props.num}${answer.id}`}>
          <Input
            type="checkbox"
            defaultChecked={answer.isCorrect}
            onChange={e =>
              this.props.dispatch(
                actions.updateTileCorrectAnswer(this.props.num, answer.id)
              )
            }
          />
          <Textarea
            type="text"
            value={answer.desc}
            onChange={(e: any) => {
              e.preventDefault();
              this.props.dispatch(
                actions.updateTextForAnswer(
                  this.props.num,
                  answer.id,
                  e.target.value
                )
              );
              this.forceUpdate();
            }}
          />
        </Li>
      );
    });
  }
}

const mapStateToProps = (state: any) => ({
  ...state.editing.tiles[state.selectedItem]
});
export default connect(mapStateToProps)(EditingDisplay as any);
