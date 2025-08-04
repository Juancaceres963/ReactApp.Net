import React from "react";
import "./AboutMe.css";
import Button from "../Button/Button";

const AboutMe = () => {
  return (
    <section className="sobre-mi">
      <div className="container presentacion">
        <div className="image-side">
          <img
            className="image-perfil"
            src="https://i.imgur.com/zfp9IQ5.png"
            alt="Foto de perfil Andreina O."
            id="sobremi"
          />
        </div>
        <div className="text-side">
          <h1 className="italianno-regular">Andreina Orellana</h1>
          <p>
            A través del uso magistral de colores puros e intensos, esta
            talentosa artista venezolana no solo pinta lienzos, sino que además
            teje historias visuales que capturan la esencia misma de los
            sentimientos humanos. Cada trazo y matiz busca resaltar en la
            belleza estética, las virtudes más profundas de la experiencia
            humana.
          </p>
        </div>
      </div>
      <div className="container promotion">
          <p>Retratos, composiciones personalizadas por ENCARGO... </p>
          <Button texto="Encarga tu obra" ruta="./galeria" />
        </div>
    </section>
  );
};

export default AboutMe;
