import { useState, useEffect } from "react";
import { Navbar, Container, Nav } from "react-bootstrap";
import { useNavigate, useLocation } from "react-router-dom";
import "./NavMenu.css";

export const NavMenu = () => {
  const [activeLink, setActiveLink] = useState("home");
  const [scrolled, setScrolled] = useState(false);
  const [expanded, setExpanded] = useState(false);
  const navigate = useNavigate();
  const location = useLocation();

  useEffect(() => {
    const onScroll = () => setScrolled(window.scrollY > 50);
    window.addEventListener("scroll", onScroll);
    return () => window.removeEventListener("scroll", onScroll);
  }, []);

  const handleNavigation = (section, path) => {
    setActiveLink(section);
    const isHome = location.pathname === "/";
    const hasHash = location.hash;

    if (!isHome) {
      navigate("/");
    } else if (hasHash) {
      // Usamos la API nativa para limpiar el hash sin recargar
      setTimeout(() => {
        window.history.replaceState(null, "", "/Andreinartistica");
        window.scrollTo({ top: 0, behavior: "smooth" });
      }, 0);
    } else {
      window.scrollTo({ top: 0, behavior: "smooth" });
    }

    const scrollToSection = () => {
      const el = document.getElementById(section);
      if (el) {
        el.scrollIntoView({ behavior: "smooth" });
        window.history.pushState(null, "", `#${section}`);
      }
    };

    if (location.pathname !== path) {
      navigate(path + (section ? `#${section}` : ""));
    } else {
      scrollToSection();
    }

    setTimeout(() => setExpanded(false), 300);
  };

  return (
    <Navbar
      expand="lg"
      expanded={expanded}
      onToggle={(isExpanded) => setExpanded(isExpanded)}
      className={`navbar ${scrolled || expanded ? "scrolled" : ""}`}
      fixed="top"
    >
      <Container>
        <Navbar.Brand
          onClick={() => {
            setExpanded(false);
            if (location.pathname !== "/") {
              navigate("/");
            } else {
              window.scrollTo({ top: 0, behavior: "smooth" });
              window.history.replaceState(null, "", "/");
            }
          }}
        >
          <img
            src="https://i.imgur.com/0nCLxdQ.png"
            alt="logo"
            className="nav-logo-img"
          />
        </Navbar.Brand>

        <Navbar.Toggle aria-controls="basic-navbar-nav">
          <span className="navbar-toggler-icon"></span>
        </Navbar.Toggle>

        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="ms-auto">
            <Nav.Link
              className={
                activeLink === "sobremi" ? "active navbar-link" : "navbar-link"
              }
              onClick={() => handleNavigation("sobremi", "/")}
            >
              SOBRE MÍ
            </Nav.Link>
            <Nav.Link
              className={
                activeLink === "galeria" ? "active navbar-link" : "navbar-link"
              }
              onClick={() => handleNavigation("galeria", "/galeria")}
            >
              GALERÍA
            </Nav.Link>
            <Nav.Link
              className={
                activeLink === "comentarios"
                  ? "active navbar-link"
                  : "navbar-link"
              }
              onClick={() => handleNavigation("comentarios", "/comentarios")}
            >
              COMENTARIOS
            </Nav.Link>
            <Nav.Link
              className={
                activeLink === "contacto" ? "active navbar-link" : "navbar-link"
              }
              onClick={() => handleNavigation("contacto", "/contacto")}
            >
              CONTACTO
            </Nav.Link>
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
};
