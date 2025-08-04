import React from "react";
import { Link } from "react-router-dom";
import "./Button.css";

const Button = ({ texto, ruta }) => {
  return (
    <Link to={ruta} className="custom-button">
      {texto}
    </Link>
  );
};

export default Button;