import React from "react";
import "./Home.css";

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
            <h2 className="text-below-rigth type-AB">GALERIA VIRTUAL</h2>
            {/* <img
              className="image-below-rigth"
              src="https://i.imgur.com/S99eXq8.png"
              alt="Logo y firma art�stica de la artista Andreina O."
            /> */}
          </div>
        </section>
        <section>
          <div>
            <img
              className="image-perfil"
              src="https://i.imgur.com/zfp9IQ5.png"
              alt="Foto de perfeil Andreina O."
            />
          </div>
          <div>

          </div>
        </section>
      </main>
    </div>
  );
}

export default Home;
