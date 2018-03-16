import React from "react";

import PlayingDisplay from "./Playing/components";
import EditingDisplay from "./Editing/components";
import { connect } from "react-redux";

export default connect(state => ({ editingMode: state.editing.isEditing }))(
  class extends React.Component {
    render() {
        if(this.props.editingMode) return <EditingDisplay />
        else {
            return <PlayingDisplay />
        }
    }
  }
);
