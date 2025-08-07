import Home from "./pages/Home/Home";
import Gallery from "./pages/Gallery/Gallery";
import Comments from "./pages/Comments/Comments";
import Contact from "./pages/Contact/Contact";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/galeria',
    element: <Gallery />
  },
  {
    path: '/comentarios',
    element: <Comments />
  },
  {
    path: '/contacto',
    element: <Contact />
  }
];

export default AppRoutes;
