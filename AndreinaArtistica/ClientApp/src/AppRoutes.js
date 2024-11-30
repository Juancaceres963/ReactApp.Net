import Home from "./components/Home";
import Galeria from "./components/Galeria";
import Comentarios from "./components/Comentarios";
import Contacto from "./components/Contacto";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/galeria',
    element: <Galeria />
  },
  {
      path: '/comentarios',
    element: <Comentarios />
  },
  {
      path: '/contacto',
      element: <Contacto />
  }
];

export default AppRoutes;
