import React, { Fragment } from "react";
import styled from "styled-components";
import { connect } from "react-redux";
import Button from "../../../Button/components/";
const Display = styled.div`
  grid-area: display;
  text-align: center;
`;
class EditingDisplay extends React.Component {
  constructor(props){
    super(props)
    let optionCount
    if(props.selectedItem.answers && props.selectedItem.answers.length > 1)
      optionCount = props.selectedItem.answers.length
      else {
        optionCount = 2
      }
    this.state = {
      optionCount
    }
    this.optionRefs = {}
  }
  componentWillReceiveProps(nextProps){
    console.log('updating component', this.props.selectedItem.num, nextProps.selectedItem.num)
    if(this.props.selectedItem.num !== nextProps.selectedItem.num){
      
    }
  }
  render() {
    return (
      <Display>
        <h1>{this.props.selectedItem.title}</h1>
        Question:
        <textarea placeholder={this.props.selectedItem.question}/>
        <div>Answers:</div>
        <ul>
           {/* {this.props.selectedItem.answers.map(answer => {
            return (
              <li key={Math.random()} ref={(ref) => this.refs.push(ref)}>
                <input type="checkbox" />
                <textarea >
                  {answer}
                </textarea>
              </li>
            );
          })}  */}
          {this.renderOptions()}
    

        </ul>
      </Display>
    );
  }

  renderOptions(){
    let optionCount = this.state.optionCount
    let options = []

    for(let i = 0 ; i < optionCount; i++){
      let index = i + 1
      let addOption
      let removeOption

      if(index === optionCount){
        addOption = this.addOption.bind(this)
      }
      if(index === optionCount - 1){
        removeOption = this.removeOption.bind(this)
      }
      const optionInput = (
        <li key = {index} >
          <input type="checkbox" />
          <input
            type="text"
            ref={(ref) => this.optionRefs[`option${index}`] = ref}
            placeholder="Enter an answer"
            onFocus={addOption}
            onBlur={removeOption}
          />
        </li>
      )
      options.push(optionInput)
    }
    return options
  }

  addOption(){
    this.setState({optionCount: this.state.optionCount + 1})
  }

  removeOption(){
    const optionCount = this.state.optionCount
    const option = this.optionRefs[`option${optionCount - 1}`].value
    if(optionCount > 2 && !option)
      this.setState({optionCount: this.state.optionCount - 1})
  }
}

const mapStateToProps = state => ({
  selectedItem: state.editingTiles[state.selectedItem]
});
export default connect(mapStateToProps)(EditingDisplay);
