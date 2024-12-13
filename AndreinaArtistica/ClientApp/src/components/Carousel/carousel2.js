import React, { useState } from "react";
import "./carousel.css";

import React, { useState } from "react";
import "./carousel.css";

// Datos de las imágenes en formato JSON
const imageData = [
  { src: "https://i.imgur.com/TstCfOp.png", alt: "Categoría Retratos" },
  { src: "https://i.imgur.com/Xby40x9.png", alt: "Categoría Arte Religioso" },
  { src: "https://i.imgur.com/U5DlRB4.png", alt: "Categoría Retratos de Mascotas" },
  { src: "https://i.imgur.com/u5eaXDR.png", alt: "Categoría Rostros y figuras humanas" },
  { src: "https://i.imgur.com/riRDxEE.png", alt: "Categoría Animales" },
  { src: "https://i.imgur.com/o10eSsj.png", alt: "Categoría Paisajes" },
  { src: "https://i.imgur.com/9FXbQIk.png", alt: "Categoría Naturaleza" },
  { src: "https://i.imgur.com/TstCfOp.png", alt: "Categoría Retratos" },
  { src: "https://i.imgur.com/Xby40x9.png", alt: "Categoría Arte Religioso" },
  { src: "https://i.imgur.com/U5DlRB4.png", alt: "Categoría Retratos de Mascotas" }, // Imagen 10
  { src: "https://i.imgur.com/u5eaXDR.png", alt: "Categoría Rostros y figuras humanas" },
  { src: "https://i.imgur.com/riRDxEE.png", alt: "Categoría Animales" },
  { src: "https://i.imgur.com/o10eSsj.png", alt: "Categoría Paisajes" },
  { src: "https://i.imgur.com/9FXbQIk.png", alt: "Categoría Naturaleza" },
];

// Componente CarouselItem
const CarouselItem = ({ src, alt, currentButton, index }) => {
  // Determina si esta imagen debe estar sin filtro
  const isActive = currentButton === index;

  return (
    <div className={`item post${currentButton}`}>
      <img className={`img__card ${isActive ? "no-filter" : ""}`} src={src} alt={alt} />
    </div>
  );
};

// Componente principal Carousel
const Carousel = () => {
  const [currentButton, setCurrentButton] = useState(9); // Índice 9 para que la imagen 10 esté seleccionada desde el inicio

  const selectCurrentButton = (index) => {
    setCurrentButton(index);
  };

  const Buttons = () => {
    return imageData.map((_, index) => (
      <input
        key={index}
        type="button"
        className={`navinput ${index === currentButton ? "active" : ""}`}
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
                currentButton={currentButton}
                index={index}
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