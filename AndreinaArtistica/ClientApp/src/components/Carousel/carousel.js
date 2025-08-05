import React, { useState } from "react";
import "./carousel.css";
import Button from "../Button/Button";
import Title from "../Title/Title";

const images = [
  "https://i.imgur.com/TstCfOp.png",
  "https://i.imgur.com/Xby40x9.png",
  "https://i.imgur.com/U5DlRB4.png",
  "https://i.imgur.com/u5eaXDR.png",
  "https://i.imgur.com/riRDxEE.png",
  "https://i.imgur.com/o10eSsj.png",
  "https://i.imgur.com/9FXbQIk.png",
  "https://i.imgur.com/TstCfOp.png",
  "https://i.imgur.com/Xby40x9.png",
  "https://i.imgur.com/U5DlRB4.png",
  "https://i.imgur.com/u5eaXDR.png",
  "https://i.imgur.com/riRDxEE.png",
  "https://i.imgur.com/o10eSsj.png",
  "https://i.imgur.com/9FXbQIk.png",
  "https://i.imgur.com/TstCfOp.png",
  "https://i.imgur.com/Xby40x9.png",
  "https://i.imgur.com/U5DlRB4.png",
  "https://i.imgur.com/u5eaXDR.png",
  "https://i.imgur.com/riRDxEE.png",
  "https://i.imgur.com/o10eSsj.png",
  "https://i.imgur.com/9FXbQIk.png",
];

const Carousel = () => {
  const [current, setCurrent] = useState(10);
  const total = images.length;

  const handleClick = (index) => {
    setCurrent(index);
  };

  const getTransformStyles = (index) => {
    const r = index - current;
    const abs = Math.abs(r);

    return {
      transform: `rotateY(${-10 * r}deg) translateX(${-300 * r}px)`,
      zIndex: total - abs,
      filter: abs === 0 ? "none" : "blur(3px)",
      width: abs === 0 ? "340px" : "270px",
      height: abs === 0 ? "460px" : "380px",
    };
  };

  return (
    <div className="main-section">
      < Title text="Galeria"/>
      <div className="carousel__content">
        <div className="cards__content">
          <main id="carousel">
            {images.map((src, index) => (
              <div
                key={index}
                className="item"
                style={getTransformStyles(index)}
                onClick={() => handleClick(index)}
              >
                <img className="img__card" src={src} alt={`Image ${index}`} />
              </div>
            ))}
          </main>
        </div>
      </div>
      <div className="container container-button-carousel">
        <Button texto="ir a galeria" ruta="./galeria" />
      </div>
    </div>
  );
};

export default Carousel;