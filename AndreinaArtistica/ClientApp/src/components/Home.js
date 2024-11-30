import React from 'react';
import { Link } from 'react-router-dom';
import './styles/Home.css';

function Home() {

    return (
        <div>
            <main>
                <section className="imagen-principal">
                    <div className="image-wrapper">
                        <img
                            className="background-image"
                            src="https://i.imgur.com/q7Xep2y.png"
                            alt="Una sala llena de cuadros, como imagen de fondo"
                        />
                        <img
                            className="overlay-image"
                            src="https://i.imgur.com/STSCdXA.png"
                            alt="Logo y firma artística de la artista Andreina O."
                        />
                        <img
                            className="image-below-rigth"
                            src="https://i.imgur.com/S99eXq8.png"
                            alt="Logo y firma artística de la artista Andreina O."
                        />
                    </div>
                </section>
            </main>
        </div>
    );
}

export default Home;