import React, { Fragment } from 'react';
import { connect } from 'react-redux';
import EditingBoard from './Editing/Board/components';
import EditingDisplay from './Editing/Display/components';
import Button from '../Button/components'
import PlayingBoard from './Playing/Board/components';
import PlayingDisplay from './Playing/Display/components';
const Screen = props => {
  if (props.isEditing)
    return (
      <Fragment>
        <div
          style={{
            height: '100vh',
            marginLeft: '25px',
            gridArea: 'board',
            display: 'grid',
            gridTemplateColumns: 'repeat(6, 1fr)',
            gridTemplateRows: 'repeat(6, 1fr)'
          }}
        >
          <EditingBoard />
        </div>
        <div style={{ gridArea: 'display' }}>
          <EditingDisplay />
        </div>
      </Fragment>
    );
  else
    return (
      <Fragment>
        <div
          style={{
            height: '100vh',
            marginLeft: '25px',
            gridArea: 'board',
            display: 'grid',
            gridTemplateColumns: 'repeat(6, 1fr)',
            gridTemplateRows: 'repeat(6, 1fr)'
          }}
        >
          <PlayingBoard />
        </div>
        <div style={{ gridArea: 'display' }}>
          <PlayingDisplay />
        </div>
      </Fragment>
    );
};

export default connect(state => ({
  isEditing: state.editing.isEditing
}))(Screen);
