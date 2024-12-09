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
            <h2 className="text-below-rigth archivo-black-regular">GALERIA VIRTUAL</h2>
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
      </main>
    </div>
  );
}

export default Home;
