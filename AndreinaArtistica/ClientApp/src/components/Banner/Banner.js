import React from "react";
import "./Banner.css";

const Banner = () => {
return (
    <section className="banner-section">
        <div className="banner-content">
          <div className="banner-part image-part">
            <img
              src="https://imgur.com/isVIbUW.png"
              alt="Logo artista"
              className="overlay-image"
            />
          </div>
          <div className="banner-part text-part">
            <h2 className="banner-text archivo-black-regular">GALERÍA VIRTUAL</h2>
          </div>
        </div>
    </section>
  );
};

export default Banner;