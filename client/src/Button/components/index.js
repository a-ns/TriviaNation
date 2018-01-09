import React from "react";
import styled from "styled-components";
const colors = {
  red: "#D50000",
  purple: "#AA00FF",
  blue: "#1565C0",
  green: "#388E3C",
  black: "#212121",
  white: "#ECEFF1"
};
const Button = styled.button`
  background-color: ${props => colors[props.backgroundColor] || colors.blue};
  font-size: 3em;
  border-radius: 2px;
  border: none;
  color: ${colors.white};
  text-align: center;
  text-decoration: none;
  min-width: 50px;
  margin: 5px;
  &:hover {
    transform: translate(0px, -2px);
    box-shadow: 2px 2px 8px ${colors.black};
  }
`;

export default Button;
