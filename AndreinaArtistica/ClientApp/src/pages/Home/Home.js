import React, { useEffect } from "react";
import "./Home.css";
import Button from "../../components/Button/Button";
import Carousel2 from "../../components/Carousel/carousel";

function Home() {
  useEffect(() => {
    const carousel = document.getElementById("carousel");
    const items = document.querySelectorAll(".carousel-item");
    const totalItems = items.length;
    const angle = 360 / totalItems;
    let currentAngle = 0;

    // Posicionar cada elemento en un círculo
    items.forEach((item, index) => {
      item.style.transform = `rotateY(${index * angle}deg) translateZ(300px)`;
    });

    // Funciones para girar el carrusel
    const nextBtn = document.getElementById("nextBtn");
    const prevBtn = document.getElementById("prevBtn");

    if (nextBtn && prevBtn && carousel) {
      nextBtn.addEventListener("click", () => {
        currentAngle -= angle;
        carousel.style.transform = `rotateY(${currentAngle}deg)`;
      });

      prevBtn.addEventListener("click", () => {
        currentAngle += angle;
        carousel.style.transform = `rotateY(${currentAngle}deg)`;
      });
    }

    // Limpieza para evitar fugas de memoria
    return () => {
      if (nextBtn && prevBtn) {
        nextBtn.removeEventListener("click", () => {});
        prevBtn.removeEventListener("click", () => {});
      }
    };
  }, []); // Se ejecuta una sola vez al montar el componente

  return (
    <div>
      <main>
        <section className="imagen-principal">
          <div className="image-wrapper">
            <img
              className="background-image"
              src="https://i.imgur.com/q7Xep2y.png"
              alt="Una sala llena de cuadros, como imagen de fondo"
            />
            <img
              className="overlay-image"
              src="https://i.imgur.com/STSCdXA.png"
              alt="Logo y firma artística de la artista Andreina O."
            />
            <h2 className="text-below-rigth archivo-black-regular">
              GALERIA VIRTUAL
            </h2>
          </div>
        </section>
        <section className="container presentacion">
          <div className="image-side">
            <img
              className="image-perfil"
              src="https://i.imgur.com/zfp9IQ5.png"
              alt="Foto de perfil Andreina O."
            />
          </div>
          <div className="text-side">
            <h1 className="italianno-regular">Andreina Orellana</h1>
            <p>
              A través del uso magistral de colores puros e intensos, esta
              talentosa artista venezolana no solo pinta lienzos, sino que
              además teje historias visuales que capturan la esencia misma de
              los sentimientos humanos. Cada trazo y matiz busca resaltar en la
              belleza estética, las virtudes más profundas de la experiencia
              humana.
            </p>
            <div className="promotion">
              <p>Retratos, composiciones personalizadas por ENCARGO... </p>
              <Button texto="Encarga tu obra" ruta="./galeria" />
            </div>
          </div>
        </section>
        <section className="gallery-home">
          <h2 className="italianno-regular gallery-home-title">Galería</h2>
          <div className="carousel-container">
            <div className="carousel" id="carousel">
              {/* <div className="carousel-item">
                <img src="https://i.imgur.com/TstCfOp.png" alt="Categoría 1" />
              </div>
              <div className="carousel-item">
                <img src="https://i.imgur.com/Xby40x9.png" alt="Categoría 2" />
              </div> */}
              <div className="carousel-item" id="item-2">
                <img
                  src="https://i.imgur.com/Xby40x9.png"
                  alt="Categoría Arte Religioso"
                />
              </div>
              <div className="carousel-item" id="item-3">
                <img
                  src="https://i.imgur.com/U5DlRB4.png"
                  alt="Categoría Retratos de Mascotas"
                />
              </div>
              <div className="carousel-item" id="item-4">
                <img
                  src="https://i.imgur.com/u5eaXDR.png"
                  alt="Categoría Rostros y figuras humanas"
                />
              </div>
              <div className="carousel-item" id="item-5">
                <img
                  src="https://i.imgur.com/riRDxEE.png"
                  alt="Categoría Animales"
                />
              </div>
              <div className="carousel-item" id="item-6">
                <img
                  src="https://i.imgur.com/o10eSsj.png"
                  alt="Categoría Paisajes"
                />
              </div>
              <div className="carousel-item" id="item-7">
                <img
                  src="https://i.imgur.com/9FXbQIk.png"
                  alt="Categoría Naturaleza"
                />
              </div>
              <div className="carousel-item" id="item-2">
                <img
                  src="https://i.imgur.com/Xby40x9.png"
                  alt="Categoría Arte Religioso"
                />
              </div>
              <div className="carousel-item" id="item-3">
                <img
                  src="https://i.imgur.com/U5DlRB4.png"
                  alt="Categoría Retratos de Mascotas"
                />
              </div>
              <div className="carousel-item" id="item-4">
                <img
                  src="https://i.imgur.com/u5eaXDR.png"
                  alt="Categoría Rostros y figuras humanas"
                />
              </div>
              <div className="carousel-item" id="item-5">
                <img
                  src="https://i.imgur.com/riRDxEE.png"
                  alt="Categoría Animales"
                />
              </div>
              <div className="carousel-item" id="item-6">
                <img
                  src="https://i.imgur.com/o10eSsj.png"
                  alt="Categoría Paisajes"
                />
              </div>
              <div className="carousel-item" id="item-7">
                <img
                  src="https://i.imgur.com/9FXbQIk.png"
                  alt="Categoría Naturaleza"
                />
              </div>
              <div className="carousel-item" id="item-2">
                <img
                  src="https://i.imgur.com/Xby40x9.png"
                  alt="Categoría Arte Religioso"
                />
              </div>
              <div className="carousel-item" id="item-3">
                <img
                  src="https://i.imgur.com/U5DlRB4.png"
                  alt="Categoría Retratos de Mascotas"
                />
              </div>
              <div className="carousel-item" id="item-4">
                <img
                  src="https://i.imgur.com/u5eaXDR.png"
                  alt="Categoría Rostros y figuras humanas"
                />
              </div>
              <div className="carousel-item" id="item-5">
                <img
                  src="https://i.imgur.com/riRDxEE.png"
                  alt="Categoría Animales"
                />
              </div>
              <div className="carousel-item" id="item-6">
                <img
                  src="https://i.imgur.com/o10eSsj.png"
                  alt="Categoría Paisajes"
                />
              </div>
              <div className="carousel-item" id="item-7">
                <img
                  src="https://i.imgur.com/9FXbQIk.png"
                  alt="Categoría Naturaleza"
                />
              </div>
              {/* Otros elementos del carrusel */}
            </div>
            <button id="prevBtn">←</button>
            <button id="nextBtn">→</button>
          </div>
          <Button texto="Ir a galeria" ruta="./galeria" />
        </section>
        <div className="carousel-bgd">
          <Carousel2 />
        </div>
      </main>
    </div>
  );
}

export default Home;
