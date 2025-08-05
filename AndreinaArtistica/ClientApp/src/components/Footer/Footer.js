import { Container, Row, Col } from "react-bootstrap";
import navIcon1 from "../../assets/img/nav-icon1.svg";
import navIcon2 from "../../assets/img/nav-icon2.png";
import navIcon3 from "../../assets/img/nav-icon3.svg";
import logo from "../../assets/img/LogoAndreinartistica.png"
// import Form from "../Form/Form";
import "./Footer.css";

export const Footer = () => {
  return (
    <footer className="footer">
      <Container className="footer-container">
        <Col>
          <div className="info-left">
            <p>ARTISTA PLASTICO </p>
            <p>OBRAS POR ENCARGO Y LIBRES</p>
          </div>
        </Col>
        <Row className="align-items-center footer-redes">
          <Col className="logo-redes d-flex flex-column align-items-center">
            <img
              className="logo-footer"
              src={logo}
              alt="logo"
            />
            <div
              style={{ paddingTop: 20 }}
              className="social-icon d-flex gap-3"
            >
              <a
                href="https://www.linkedin.com/in/juan-caceres-orellana/"
                target="_blank"
              >
                <img src={navIcon1} alt="Icon" />
              </a>
              <a href="https://www.instagram.com/andreinartistica03/" target="_blank">
                <img src={navIcon3} alt="Icon" />
              </a>
            </div>
          </Col>
        </Row>
        <Col>
          <div className="info-right">
            <p>Estudio Taller:</p>
            <p>Cabudare Venezuela</p>
            <p>+58 414 5126736</p>
            <p>andreinaartistica@gmail.com</p>
          </div>
        </Col>
      </Container>
      <p className="copy">Coppyright Andreina Orellana - Artista Plástico</p>
    </footer>
  );
};

export default Footer;
