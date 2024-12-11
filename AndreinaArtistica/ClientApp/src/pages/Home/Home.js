import React from "react";
import "./Home.css";
import Button from "../../components/Button/Button";

function Home() {
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
              alt="Logo y firma art�stica de la artista Andreina O."
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
              alt="Foto de perfeil Andreina O."
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
        <section class="gallery-home">
          <h2 class="italianno-regular gallery-home-title">Galería</h2>
          <div class="gallery-container">
            <div class="gallery-item" id="item-1">
              <img src="https://i.imgur.com/TstCfOp.png" alt="Categoría Retratos" />
            </div>
            <div class="gallery-item" id="item-2">
              <img src="https://i.imgur.com/Xby40x9.png" alt="Categoría Arte Religioso" />
            </div>
            <div class="gallery-item" id="item-3">
              <img src="https://i.imgur.com/U5DlRB4.png" alt="Categoría Retratos de Mascotas" />
            </div>
            <div class="gallery-item" id="item-4">
              <img src="https://i.imgur.com/u5eaXDR.png" alt="Categoría Rostros y figuras humanas" />
            </div>
            <div class="gallery-item" id="item-5">
              <img src="https://i.imgur.com/riRDxEE.png" alt="Categoría Animales" />
            </div>
            <div class="gallery-item" id="item-6">
              <img src="https://i.imgur.com/o10eSsj.png" alt="Categoría Paisajes" />
            </div>
            <div class="gallery-item" id="item-7">
              <img src="https://i.imgur.com/9FXbQIk.png" alt="Categoría Naturaleza" />
            </div>
          </div>
          <Button texto="Ir a galeria" ruta="./galeria" />
        </section>
      </main>
    </div>
  );
}

export default Home;
