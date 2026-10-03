

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
}

body {
    font-family: Arial, Helvetica, sans-serif;
    background: #05070c;
    color: white;
    overflow-x: hidden;
}


/* ================================
   LOADER
================================ */

#loader {
    position: fixed;
    inset: 0;
    background: #05070c;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    z-index: 9999;
    transition: opacity 0.6s ease;
}

#loader h2 {
    margin-top: 20px;
    letter-spacing: 4px;
}

#loader p {
    color: #7d8ba3;
    margin-top: 8px;
}

.loader-circle {
    width: 55px;
    height: 55px;
    border: 4px solid #182238;
    border-top-color: #168cff;
    border-right-color: #00d9ff;
    border-radius: 50%;
    animation: spin 1s linear infinite;
}

@keyframes spin {
    to {
        transform: rotate(360deg);
    }
}


/* ================================
   NAVBAR
================================ */

.navbar {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 75px;

    display: flex;
    align-items: center;
    justify-content: space-between;

    padding: 0 7%;

    background: rgba(5, 7, 12, 0.75);
    backdrop-filter: blur(15px);

    border-bottom: 1px solid rgba(255,255,255,0.07);

    z-index: 1000;
}

.logo {
    font-size: 21px;
    font-weight: 800;
    letter-spacing: 2px;
}

.logo span {
    color: #168cff;
}

.navbar nav {
    display: flex;
    gap: 35px;
}

.navbar nav a {
    color: #c9d4e6;
    text-decoration: none;
    font-weight: 600;
    transition: 0.3s;
}

.navbar nav a:hover {
    color: #168cff;
}

.menu-btn {
    display: none;
    background: none;
    border: none;
    color: white;
    font-size: 28px;
}


/* ================================
   HERO
================================ */

.hero {
    min-height: 100vh;

    display: flex;
    align-items: center;

    padding: 120px 8% 70px;

    background:
        radial-gradient(
            circle at 80% 30%,
            rgba(0, 140, 255, 0.18),
            transparent 30%
        ),
        radial-gradient(
            circle at 20% 80%,
            rgba(0, 220, 255, 0.08),
            transparent 30%
        ),
        #05070c;
}

.hero-content {
    width: 100%;
    max-width: 1250px;
    margin: auto;

    display: flex;
    align-items: center;
    justify-content: space-between;
    gap: 70px;
}

.hero-text {
    max-width: 700px;
    animation: slideLeft 1s ease;
}

.small-title {
    color: #168cff;
    font-weight: bold;
    letter-spacing: 4px;
    margin-bottom: 18px;
}

.hero h1 {
    font-size: clamp(45px, 7vw, 85px);
    line-height: 1.05;
}

.hero h1 span {
    display: block;

    background: linear-gradient(
        90deg,
        #168cff,
        #00d9ff
    );

    -webkit-background-clip: text;
    color: transparent;
}

.hero-description {
    margin-top: 25px;
    color: #9ba8bb;
    line-height: 1.8;
    max-width: 650px;
    font-size: 17px;
}

.hero-buttons {
    display: flex;
    gap: 15px;
    margin-top: 35px;
}

.primary-btn,
.secondary-btn {
    padding: 14px 25px;
    border-radius: 8px;
    text-decoration: none;
    font-weight: bold;
    transition: 0.3s;
}

.primary-btn {
    color: white;
    background: linear-gradient(
        90deg,
        #087cff,
        #00b9ff
    );
    box-shadow: 0 0 30px rgba(0, 150, 255, 0.25);
}

.primary-btn:hover {
    transform: translateY(-4px);
    box-shadow: 0 10px 35px rgba(0, 150, 255, 0.4);
}

.secondary-btn {
    color: white;
    border: 1px solid #24324a;
}

.secondary-btn:hover {
    border-color: #168cff;
    color: #168cff;
}


/* ================================
   PROFILE
================================ */

.profile-container {
    position: relative;
    width: 330px;
    height: 330px;
    flex-shrink: 0;

    animation: float 4s ease-in-out infinite;
}

.profile-glow {
    position: absolute;
    inset: -30px;

    background: linear-gradient(
        135deg,
        #168cff,
        #00d9ff,
        transparent 70%
    );

    filter: blur(55px);
    opacity: 0.35;
}

.profile-image {
    position: relative;

    width: 100%;
    height: 100%;

    object-fit: cover;

    border-radius: 50%;

    border: 4px solid #168cff;

    box-shadow:
        0 0 0 10px rgba(22, 140, 255, 0.08),
        0 0 60px rgba(22, 140, 255, 0.35);
}

@keyframes float {
    0%, 100% {
        transform: translateY(0);
    }

    50% {
        transform: translateY(-15px);
    }
}

@keyframes slideLeft {
    from {
        opacity: 0;
        transform: translateX(-50px);
    }

    to {
        opacity: 1;
        transform: translateX(0);
    }
}


/* ================================
   SECTIONS
================================ */

.section {
    padding: 110px 7%;
}

.section-title {
    text-align: center;
    margin-bottom: 55px;
}

.section-title p {
    color: #168cff;
    letter-spacing: 4px;
    font-weight: bold;
    font-size: 13px;
}

.section-title h2 {
    font-size: 45px;
    margin-top: 10px;
}

.section-title h2 span {
    color: #168cff;
}

.section-title small {
    display: block;
    margin-top: 15px;
    color: #78869c;
}


/* ================================
   ABOUT
================================ */

.about-container {
    max-width: 1100px;
    margin: auto;

    display: grid;
    grid-template-columns: 1.4fr 1fr;
    gap: 25px;
}

.about-card,
.info-card {
    background: linear-gradient(
        145deg,
        #0c111b,
        #080b12
    );

    border: 1px solid #182438;
    border-radius: 18px;
    padding: 35px;

    transition: 0.4s;
}

.about-card:hover,
.info-card:hover {
    transform: translateY(-8px);
    border-color: #168cff;
    box-shadow: 0 20px 60px rgba(0, 100, 255, 0.1);
}

.about-card h3 {
    font-size: 28px;
    margin-bottom: 20px;
}

.about-card p {
    color: #9aa8bc;
    line-height: 1.8;
    margin-bottom: 15px;
}

.info-item {
    padding: 18px 0;
    border-bottom: 1px solid #1a2435;
}

.info-item:last-child {
    border-bottom: none;
}

.info-item span {
    display: block;
    color: #168cff;
    font-size: 11px;
    letter-spacing: 2px;
    margin-bottom: 7px;
}

.info-item strong {
    color: #e9f0fa;
}


/* ================================
   WORK CATEGORIES
================================ */

.works-section {
    background:
        linear-gradient(
            rgba(5,7,12,0.94),
            rgba(5,7,12,0.98)
        ),
        radial-gradient(
            circle at center,
            #102d50,
            transparent 60%
        );
}

.category-grid {
    max-width: 1300px;
    margin: auto;

    display: grid;
    grid-template-columns:
        repeat(2, 1fr);

    gap: 25px;
}

.category-card {
    background: rgba(10, 15, 24, 0.9);

    border: 1px solid #19263a;
    border-radius: 18px;

    padding: 30px;

    transition: 0.4s;

    position: relative;
    overflow: hidden;
}

.category-card::before {
    content: "";

    position: absolute;

    width: 150px;
    height: 150px;

    background: #168cff;

    filter: blur(100px);

    opacity: 0;

    right: -60px;
    top: -60px;

    transition: 0.4s;
}

.category-card:hover {
    transform: translateY(-10px);
    border-color: #168cff;

    box-shadow:
        0 20px 70px rgba(0, 100, 255, 0.13);
}

.category-card:hover::before {
    opacity: 0.25;
}

.category-icon {
    width: 55px;
    height: 55px;

    display: flex;
    align-items: center;
    justify-content: center;

    font-size: 25px;

    background: rgba(22, 140, 255, 0.1);

    border: 1px solid rgba(22, 140, 255, 0.25);

    border-radius: 12px;

    margin-bottom: 20px;
}

.category-card h3 {
    font-size: 27px;
}

.category-card > p {
    color: #7f8da2;
    margin-top: 8px;
    margin-bottom: 25px;
}


/* ================================
   FILE ITEMS
================================ */

.file-list {
    display: flex;
    flex-direction: column;
    gap: 12px;
}

.file-item {
    display: flex;
    align-items: center;
    justify-content: space-between;

    gap: 15px;

    padding: 15px;

    border-radius: 10px;

    background: #080c14;

    border: 1px solid #172235;
}

.file-item strong {
    display: block;
    font-size: 14px;
}

.file-item small {
    display: block;
    margin-top: 5px;
    color: #6f7d91;
}

.file-btn {
    white-space: nowrap;

    padding: 9px 13px;

    border-radius: 7px;

    background: #168cff;

    color: white;

    text-decoration: none;

    font-size: 12px;
    font-weight: bold;

    transition: 0.3s;
}

.file-btn:hover {
    background: #00b9ff;
    transform: scale(1.05);
}


/* ================================
   FOOTER
================================ */

footer {
    text-align: center;

    padding: 60px 20px;

    background: #03050a;

    border-top: 1px solid #141e2e;
}

.footer-logo {
    color: #168cff;
    font-weight: 800;
    letter-spacing: 3px;
    margin-bottom: 12px;
}

footer p {
    color: #718096;
}

.copyright {
    margin-top: 15px;
    font-size: 12px;
}


/* ================================
   RESPONSIVE
================================ */

@media (max-width: 850px) {

    .navbar {
        padding: 0 5%;
    }

    .menu-btn {
        display: block;
    }

    .navbar nav {
        position: absolute;

        top: 75px;
        left: 0;

        width: 100%;

        background: #080c14;

        display: none;

        flex-direction: column;

        padding: 25px;

        text-align: center;
    }

    .navbar nav.active {
        display: flex;
    }

    .hero {
        padding-left: 6%;
        padding-right: 6%;
    }

    .hero-content {
        flex-direction: column-reverse;
        text-align: center;
    }

    .hero-description {
        margin-left: auto;
        margin-right: auto;
    }

    .hero-buttons {
        justify-content: center;
    }

    .profile-container {
        width: 250px;
        height: 250px;
    }

    .about-container {
        grid-template-columns: 1fr;
    }

    .category-grid {
        grid-template-columns: 1fr;
    }
}


@media (max-width: 500px) {

    .section {
        padding: 80px 5%;
    }

    .hero h1 {
        font-size: 43px;
    }

    .section-title h2 {
        font-size: 35px;
    }

    .hero-buttons {
        flex-direction: column;
    }

    .file-item {
        align-items: flex-start;
        flex-direction: column;
    }

    .file-btn {
        width: 100%;
        text-align: center;
    }
}
```
