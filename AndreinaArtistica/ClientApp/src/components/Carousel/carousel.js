import React from "react";
import "./carousel.css";
import { useState } from "react";

const Carousel = () => {
  const [currentButton, setCurrentButton] = useState();

  const selectCurrentButton = (currentIndex) => {
    setCurrentButton(currentIndex);
  };
  const Buttons = () => {
    let arrayButtons = [];
    for (let i = 7; i < 14; i++) {
      arrayButtons.push(
        <input
          key={i}
          type="button"
          position={i}
          className={`${i !== currentButton ? "navinput" : "active"}`}
          onClick={() => selectCurrentButton(i)}
        />
      );
    }
    return arrayButtons;
  };

  return (
    <>
      <div className="main-section">
        <div className="carousel__content">
          <div className="cards__content">
            <main id="carousel">
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/TstCfOp.png"
                  alt="Categoría Retratos"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/Xby40x9.png"
                  alt="Categoría Arte Religioso"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/U5DlRB4.png"
                  alt="Categoría Retratos de Mascotas"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/u5eaXDR.png"
                  alt="Categoría Rostros y figuras humanas"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/riRDxEE.png"
                  alt="Categoría Animales"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/o10eSsj.png"
                  alt="Categoría Paisajes"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/9FXbQIk.png"
                  alt="Categoría Naturaleza"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/TstCfOp.png"
                  alt="Categoría Retratos"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/Xby40x9.png"
                  alt="Categoría Arte Religioso"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/U5DlRB4.png"
                  alt="Categoría Retratos de Mascotas"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/u5eaXDR.png"
                  alt="Categoría Rostros y figuras humanas"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/riRDxEE.png"
                  alt="Categoría Animales"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/o10eSsj.png"
                  alt="Categoría Paisajes"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/9FXbQIk.png"
                  alt="Categoría Naturaleza"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/TstCfOp.png"
                  alt="Categoría Retratos"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/Xby40x9.png"
                  alt="Categoría Arte Religioso"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/U5DlRB4.png"
                  alt="Categoría Retratos de Mascotas"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/u5eaXDR.png"
                  alt="Categoría Rostros y figuras humanas"
                />
              </div>
              <div className={"item post" + currentButton + ""}>
                <img
                  className="img__card"
                  src="https://i.imgur.com/riRDxEE.png"
                  alt="Categoría Animales"
                />
              </div>
            </main>
            <div className="buttons__groups">
              <Buttons />
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default Carousel;
