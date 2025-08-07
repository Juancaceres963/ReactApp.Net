// src/components/SocialMedia/SocialMedia.jsx

import React from "react";
import PropTypes from "prop-types";
import "./SocialMedia.css"; // Si tenés estilos separados

const SocialMedia = ({ icons }) => {
  return (
    <div className="social-icon d-flex gap-3">
      {icons.map((icon, index) => (
        <a
          key={index}
          href={icon.Link}
          target="_blank"
          rel="noopener noreferrer"
          title={icon.SocialMedia}
        >
          <img src={icon.ImgUrl} alt={`${icon.SocialMedia} icon`} />
        </a>
      ))}
    </div>
  );
};

SocialMedia.propTypes = {
  icons: PropTypes.arrayOf(
    PropTypes.shape({
      ImgUrl: PropTypes.string.isRequired,
      SocialMedia: PropTypes.string.isRequired,
      Link: PropTypes.string.isRequired
    })
  ).isRequired
};

export default SocialMedia;
