import "./Home.css";
import Banner from "../../components/Banner/Banner";
import AboutMe from "../../components/AboutMe/AboutMe";
import Carousel from "../../components/Carousel/carousel"
import Footer from '../../components/Footer/Footer';

function Home() {

  return (
    <div>
      <main>
        < Banner />
        < AboutMe />
        < Carousel />
        < Footer />
      </main>
    </div>
  );
}

export default Home;
