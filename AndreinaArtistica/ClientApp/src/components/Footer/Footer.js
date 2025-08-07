import { Container, Row, Col } from "react-bootstrap";
import logo from "../../assets/img/LogoAndreinartistica.png"
import SocialMedia from "../SocialMedia/SocialMedia";
import "./Footer.css";

export const Footer = () => {
  const Icons = [
    {
      ImgUrl: "https://imgur.com/Eew4dBb.png",
      SocialMedia: "facebook",
      Link: "https://www.facebook.com/andreina.orellana.90"
    },
    {
      ImgUrl: "https://imgur.com/JXEZiLk.png",
      SocialMedia: "Instagram",
      Link: "https://www.instagram.com/andreinartistica03/"
    },
  ]

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
              <SocialMedia icons={Icons}/>
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
