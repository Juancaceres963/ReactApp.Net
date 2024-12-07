import Home from "./pages/Home/Home";
import Galery from "./pages/Galery/Galery";
import Comments from "./pages/Comments/Comments";
import Contact from "./pages/Contact/Contact";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/galeria',
    element: <Galery />
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
