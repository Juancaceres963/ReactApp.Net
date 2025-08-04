import React, { useEffect } from "react";
import "./Home.css";
import Banner from "../../components/Banner/Banner";
// import Button from "../../components/Button/Button";
// import Carousel2 from "../../components/Carousel/carousel";

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
        < Banner />
        {/* <section className="container presentacion">
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
            <Carousel2 />
          <Button texto="Ir a galeria" ruta="./galeria" />
        </section> */}
      </main>
    </div>
  );
}

export default Home;
