import React, { useState, useEffect } from "react";
import "./carousel.css";

const imageData = [
  { src: "https://i.imgur.com/TstCfOp.png", alt: "Categoría Retratos" },
  { src: "https://i.imgur.com/Xby40x9.png", alt: "Categoría Arte Religioso" },
  { src: "https://i.imgur.com/U5DlRB4.png", alt: "Categoría Retratos de Mascotas" },
  { src: "https://i.imgur.com/u5eaXDR.png", alt: "Categoría Rostros y figuras humanas" },
  { src: "https://i.imgur.com/riRDxEE.png", alt: "Categoría Animales" },
  { src: "https://i.imgur.com/o10eSsj.png", alt: "Categoría Paisajes" },
  { src: "https://i.imgur.com/9FXbQIk.png", alt: "Categoría Naturaleza" },
];

const CarouselItem = ({ src, alt, isActive }) => {
  return (
    <div className={`item ${isActive ? "active" : ""}`}>
      <img className="img__card" src={src} alt={alt} />
    </div>
  );
};

const Carousel2 = () => {
  const [currentButton, setCurrentButton] = useState(3); // Índice inicial

  useEffect(() => {
    // Establecer la posición inicial en el CSS
    document.documentElement.style.setProperty("--position", currentButton);
  }, [currentButton]);

  // Cambio automático cada 10 segundos
  useEffect(() => {
    const interval = setInterval(() => {
      setCurrentButton((prev) => (prev + 1) % imageData.length);
    }, 10000);
    return () => clearInterval(interval);
  }, []);

  // Actualiza el índice actual al seleccionar un botón
  const selectCurrentButton = (index) => {
    setCurrentButton(index);
    console.log("currentButton:", currentButton);
  };

  const Buttons = () => {
    return imageData.map((_, index) => (
      <input
        key={index}
        type="button"
        className={`navinput ${currentButton === index ? "active" : ""}`}
        onClick={() => selectCurrentButton(index)}
      />
    ));
  };

  return (
    <div className="main-section">
      <div className="carousel__content">
        <div className="cards__content">
          <main id="carousel">
            {imageData.map((image, index) => (
              <CarouselItem
                key={index}
                src={image.src}
                alt={image.alt}
                isActive={currentButton === index}
              />
            ))}
          </main>
          <div className="buttons__groups">
            <Buttons />
          </div>
        </div>
      </div>
    </div>
  );
};

export default Carousel2;