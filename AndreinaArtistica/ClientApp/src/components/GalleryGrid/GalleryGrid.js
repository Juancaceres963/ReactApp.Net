import "./GalleryGrid.css";

const dummyImages = Array.from({ length: 30 }, (_, i) => ({
  id: i + 1,
  title: `Cuadro ${i + 1}`,
  url: `https://picsum.photos/id/${(i + 10) * 3}/600/600`,
}));

const GalleryGrid = () => {
  return (
    <main className="gallery-grid">
      {dummyImages.map((img, index) => {
        const modulo = index % 9;

        if (modulo < 6) {
          return (
            <div key={img.id} className="grid-item normal">
              <img src={img.url} alt={img.title} />
            </div>
          );
        }

        const blockNumber = Math.floor(index / 9);
        const isFirstInBlock = modulo === 6;
        const isReversed = blockNumber % 2 === 1;

        if (modulo >= 6 && modulo <= 8) {
          if ((isFirstInBlock && !isReversed) || (modulo === 8 && isReversed)) {
            return (
              <div key={img.id} className="grid-item big">
                <img src={img.url} alt={img.title} />
              </div>
            );
          } else {
            return (
              <div key={img.id} className="grid-item normal">
                <img src={img.url} alt={img.title} />
              </div>
            );
          }
        }

        return null;
      })}
    </main>
  );
};

export default GalleryGrid;
