import * as React from 'react';
import { connect } from 'react-redux';
import Button from '../../Button/components';
import styled from 'styled-components'
const Container = styled.div`
  position: absolute;
  display: grid;
  grid-template-columns: 1fr 1fr;
  grid-template-rows: 1fr 1fr;
  top: 45%;
  left: 45%;
`
const TeamSelect = (props: any) => {
  if (!props.teams) {
    return <div>Loading</div>
  }
  return (
    <React.Fragment>
    <Container>
      <Button onClick={(_: any) => props.selectTeam(0)} backgroundColor="red">Team 1 {props.teams[0]}</Button>
      <Button onClick={(_: any) => props.selectTeam(1)} backgroundColor="purple">Team 2 {props.teams[1]}</Button>
      <Button onClick={(_: any) => props.selectTeam(2)} backgroundColor="blue">Team 3 {props.teams[2]}</Button>
      <Button onClick={(_: any) => props.selectTeam(3)} backgroundColor="green">Team 4 {props.teams[3]}</Button>
    </Container>
    <div style={{backgroundColor: 'rgba(0,0,0,.88)', width: window.outerWidth, height: window.outerHeight}} />
    </React.Fragment>
  );
};

const mapStateToProps = (state: {
  teamSelect: { selectedTeam: number; amountOnEachTeam: any };
}) => {
  return {
    selectedTeam: state.teamSelect.selectedTeam,
    teams: state.teamSelect.amountOnEachTeam
  };
};
const mapDispatchToProps = (dispatch: Function) => {
  return {
    selectTeam: (team: any) => {
      dispatch({
        type: 'team/select',
        meta: 'socket',
        payload: { selectedTeam: team }
      });
    }
  };
};
export default connect(mapStateToProps, mapDispatchToProps)(TeamSelect);
