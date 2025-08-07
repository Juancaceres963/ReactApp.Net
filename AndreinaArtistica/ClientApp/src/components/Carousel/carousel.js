import React, { useEffect, useState } from "react";
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
  const [isSmallScreen, setIsSmallScreen] = useState(window.innerWidth < 576);
  const [current, setCurrent] = useState(10);
  const total = images.length;

  const handleClick = (index) => {
    setCurrent(index);
  };

  useEffect(() => {
    const handleResize = () => {
      setIsSmallScreen(window.innerWidth < 576);
    };

    // Escucha el resize
    window.addEventListener("resize", handleResize);

    // Llamada inicial por si acaso cambia antes de montar
    handleResize();

    // Limpieza
    return () => window.removeEventListener("resize", handleResize);
  }, []);

  const getTransformStyles = (index) => {
  const r = index - current;
  const abs = Math.abs(r);

  const translateX = isSmallScreen ? -240 * r : -280 * r;
  const width = abs === 0 ? (isSmallScreen ? "260px" : "320px") : (isSmallScreen ? "220px" : "240px");
  const height = abs === 0 ? (isSmallScreen ? "370px" : "400px") : (isSmallScreen ? "320px" : "360px");

  return {
    transform: `rotateY(${-10 * r}deg) translateX(${translateX}px)`,
    zIndex: total - abs,
    filter: abs === 0 ? "none" : "blur(4px)",
    width,
    height,
  };
};

  return (
    <div className="main-section">
      <Title text="Galeria" />
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
