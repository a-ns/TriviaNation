import * as React from 'react';
import styled from 'styled-components';
import { connect } from 'react-redux';
import { Toast as ToastModel } from '../type'
const Toast = styled.div`
  width: 400px;
  margin: 5px;
  padding: 5px;
  height: 50px;
  position: fixed;
  background-color: ${(props: ToastModel) =>
    props.type === 'error'
      ? '#B71C1C'
      : props.type === 'success'
        ? '#4CAF50'
        : props.type === 'info' ? '#01579B' : '#616161'};
  bottom: ${(props: any) => (props.where === 'bottom' ? `${100 * props.offset + 100}px` : '')};
  top: ${(props: any) => (props.where === 'top' ? `${100 * props.offset + 100}px` : '')};
  visibility: ${(props: any) => (props.visible ? 'visible' : 'hidden')};
  z-index: 2000;
  left: ${window.innerWidth - 450}px;
  
`;

class Toasts extends React.Component<{ toasts: Array<ToastModel> }, any> {
  render() {
    console.log('toasts', this.props.toasts)
    return (
      <React.Fragment>
        {this.props.toasts.map((toast, index) => {
          return (
            <Toast
              key={toast.id}
              type={toast.type}
              visible={toast.visible}
              where={toast.where}
              offset={index}
            >
              {toast.content}
            </Toast>
          );
        })}
      </React.Fragment>
    );
  }
}
const mapStateToProps = (state: any) => ({ toasts: state.toasts });
export default connect(mapStateToProps)(Toasts);
