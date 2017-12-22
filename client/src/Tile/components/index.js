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
const Tile = styled.span`
  margin: 2px;
  border: 2px solid ${props => colors[props.owner]};
  background-color: ${colors.white};
  border-radius: 2px;
  &:hover {
    transform: translate(0px, -2px);
    box-shadow: 2px 2px 8px ${colors.black};
  }
  &:focus {
    transform: translate(0px, 0px);
    box-shadow: 1px 1px 2px ${colors.black};
  }
`;

export default Tile;
