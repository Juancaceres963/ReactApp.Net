import "./Gallery.css";
import Footer from "../../components/Footer/Footer";
import Title from "../../components/Title/Title";
import GalleryFilter from "../../components/GalletyFilter/GalleryFilter";
import GalleryGrid from "../../components/GalleryGrid/GalleryGrid";

const Gallery = () => {
  return (
    <div>
      <div className="gallery-section">
        <GalleryFilter />
        <div className="gallery-container">
          <Title text="Galeria" />
          <GalleryGrid />
        </div>
      </div>
      <Footer />
    </div>
  );
};

export default Gallery;
