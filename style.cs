```css
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
}

body {
    font-family: "Inter", sans-serif;
    background: #030712;
    color: white;
    overflow-x: hidden;
}


/* =========================
   ANIMATED BACKGROUND
========================= */

.bg-animation {
    position: fixed;
    inset: 0;
    overflow: hidden;
    pointer-events: none;
    z-index: -1;
}

.bg-animation span {
    position: absolute;
    width: 300px;
    height: 300px;
    border-radius: 50%;
    background: rgba(0, 119, 255, .12);
    filter: blur(80px);
    animation: float 12s infinite alternate ease-in-out;
}

.bg-animation span:nth-child(1) {
    left: 5%;
    top: 10%;
}

.bg-animation span:nth-child(2) {
    right: 5%;
    top: 30%;
    animation-delay: 2s;
}

.bg-animation span:nth-child(3) {
    left: 35%;
    bottom: 5%;
    animation-delay: 4s;
}

.bg-animation span:nth-child(4) {
    right: 30%;
    bottom: 30%;
    animation-delay: 6s;
}

@keyframes float {

    from {
        transform: translate(0,0) scale(1);
    }

    to {
        transform: translate(100px,-80px) scale(1.4);
    }

}


/* =========================
   NAVBAR
========================= */

.navbar {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    padding: 20px 7%;
    display: flex;
    align-items: center;
    justify-content: space-between;
    background: rgba(3,7,18,.78);
    backdrop-filter: blur(20px);
    border-bottom: 1px solid rgba(0,140,255,.15);
    z-index: 1000;
}

.logo {
    font-size: 25px;
    font-weight: 900;
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
    color: #cbd5e1;
    text-decoration: none;
    font-size: 14px;
    transition: .3s;
}

.navbar nav a:hover {
    color: #168cff;
}

.menu-button {
    display: none;
    background: none;
    border: 0;
    color: white;
    font-size: 25px;
}


/* =========================
   HERO
========================= */

.hero {
    min-height: 100vh;
    padding: 130px 7% 70px;
    display: flex;
    align-items: center;
}

.hero-content {
    width: 100%;
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 90px;
}

.profile-wrapper {
    position: relative;
    width: 280px;
    height: 280px;
}

.profile-wrapper img {
    width: 100%;
    height: 100%;
    object-fit: cover;
    border-radius: 50%;
    border: 8px solid #050a14;
    position: relative;
    z-index: 2;
    box-shadow: 0 0 60px rgba(0,132,255,.3);
}

.profile-ring {
    position: absolute;
    inset: -12px;
    border-radius: 50%;
    border: 2px solid #168cff;
    border-top-color: transparent;
    animation: spin 5s linear infinite;
}

@keyframes spin {
    to {
        transform: rotate(360deg);
    }
}

.hero-text {
    max-width: 700px;
}

.welcome {
    color: #168cff;
    font-size: 13px;
    letter-spacing: 4px;
    font-weight: 800;
    margin-bottom: 15px;
}

.hero h1 {
    font-size: clamp(45px, 7vw, 80px);
    line-height: .95;
}

.hero h1 span {
    display: block;
    color: transparent;
    -webkit-text-stroke: 1px #168cff;
}

.hero h2 {
    margin-top: 25px;
    font-size: 24px;
    color: #dbeafe;
    min-height: 35px;
}

.description {
    color: #94a3b8;
    line-height: 1.8;
    max-width: 650px;
    margin: 20px 0 30px;
}

.primary-button {
    display: inline-flex;
    gap: 15px;
    align-items: center;
    padding: 15px 25px;
    border-radius: 8px;
    background: linear-gradient(135deg,#168cff,#005bc4);
    color: white;
    text-decoration: none;
    font-weight: 700;
    box-shadow: 0 10px 30px rgba(0,120,255,.2);
    transition: .3s;
}

.primary-button:hover {
    transform: translateY(-5px);
    box-shadow: 0 15px 40px rgba(0,120,255,.35);
}


/* =========================
   SECTION
========================= */

.section {
    padding: 110px 7%;
}

.section-heading {
    text-align: center;
    margin-bottom: 50px;
}

.section-heading p {
    color: #168cff;
    font-size: 12px;
    font-weight: 800;
    letter-spacing: 4px;
}

.section-heading h2 {
    margin-top: 10px;
    font-size: 45px;
}

.section-heading h2 span {
    color: #168cff;
}


/* =========================
   ABOUT
========================= */

.about-container {
    max-width: 1000px;
    margin: auto;
    padding: 40px;
    display: flex;
    gap: 30px;
    background: rgba(10,18,32,.8);
    border: 1px solid rgba(0,140,255,.18);
    border-radius: 20px;
    transition: .4s;
}

.about-container:hover {
    transform: translateY(-8px);
    border-color: #168cff;
    box-shadow: 0 20px 60px rgba(0,100,255,.12);
}

.about-symbol {
    width: 70px;
    height: 70px;
    flex-shrink: 0;
    border-radius: 15px;
    display: flex;
    justify-content: center;
    align-items: center;
    background: #168cff;
    font-weight: 900;
}

.about-container h3 {
    font-size: 25px;
    margin-bottom: 15px;
}

.about-container p {
    color: #94a3b8;
    line-height: 1.8;
    margin-bottom: 15px;
}

.skills {
    display: flex;
    flex-wrap: wrap;
    gap: 10px;
}

.skills span {
    padding: 8px 14px;
    border-radius: 50px;
    color: #72b9ff;
    background: rgba(22,140,255,.08);
    border: 1px solid rgba(22,140,255,.3);
    font-size: 12px;
}


/* =========================
   CATEGORY
========================= */

.categories {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
    gap: 10px;
    margin-bottom: 35px;
}

.category {
    padding: 12px 20px;
    background: #09111e;
    border: 1px solid #193552;
    border-radius: 50px;
    color: #94a3b8;
    cursor: pointer;
    transition: .3s;
}

.category:hover {
    border-color: #168cff;
    color: white;
}

.category.active {
    background: #168cff;
    border-color: #168cff;
    color: white;
}


/* =========================
   PORTFOLIO HEADER
========================= */

.portfolio-header {
    max-width: 1000px;
    margin: auto;
    padding: 25px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    background: rgba(10,18,32,.8);
    border: 1px solid #193552;
    border-radius: 15px;
}

.label {
    color: #64748b;
    font-size: 11px;
    letter-spacing: 2px;
}

.portfolio-header h3 {
    margin-top: 5px;
    font-size: 25px;
}

.file-stat {
    text-align: center;
}

.file-stat strong {
    display: block;
    color: #168cff;
    font-size: 28px;
}

.file-stat span {
    color: #64748b;
    font-size: 12px;
}


/* =========================
   FILE GRID
========================= */

.file-grid {
    max-width: 1000px;
    margin: 30px auto;
    display: grid;
    grid-template-columns: repeat(auto-fill,minmax(220px,1fr));
    gap: 20px;
}

.file-card {
    overflow: hidden;
    background: #09111e;
    border: 1px solid #193552;
    border-radius: 15px;
    animation: cardIn .5s ease;
    transition: .3s;
}

.file-card:hover {
    transform: translateY(-7px);
    border-color: #168cff;
}

@keyframes cardIn {
    from {
        opacity: 0;
        transform: translateY(20px);
    }

    to {
        opacity: 1;
        transform: translateY(0);
    }
}

.file-preview {
    height: 160px;
    display: flex;
    justify-content: center;
    align-items: center;
    background: #040914;
    overflow: hidden;
}

.file-preview img {
    width: 100%;
    height: 100%;
    object-fit: cover;
}

.file-icon {
    font-size: 50px;
}

.file-info {
    padding: 15px;
}

.file-info h4 {
    white-space: nowrap;
    overflow: hidden;
    text-overflow: ellipsis;
}

.file-info p {
    color: #64748b;
    font-size: 12px;
    margin-top: 6px;
}

.file-action {
    display: block;
    margin-top: 12px;
    padding: 9px;
    text-align: center;
    color: white;
    text-decoration: none;
    background: #168cff;
    border-radius: 7px;
    font-size: 12px;
}

.loading,
.empty {
    grid-column: 1/-1;
    text-align: center;
    padding: 60px;
    color: #64748b;
}


/* =========================
   FOOTER
========================= */

footer {
    padding: 50px 7%;
    text-align: center;
    border-top: 1px solid #17253a;
}

.footer-logo {
    color: #168cff;
    font-weight: 900;
    font-size: 25px;
}

footer p {
    color: #64748b;
    margin-top: 8px;
}


/* =========================
   LOGIN
========================= */

.admin-body {
    min-height: 100vh;
}

.login-page {
    min-height: 100vh;
    display: flex;
    align-items: center;
    justify-content: center;
    padding: 30px;
}

.login-box {
    width: 100%;
    max-width: 450px;
    padding: 45px;
    background: rgba(7,15,28,.9);
    border: 1px solid rgba(22,140,255,.25);
    border-radius: 25px;
    box-shadow: 0 30px 100px rgba(0,0,0,.5);
}

.login-logo {
    color: #168cff;
    font-weight: 900;
    font-size: 28px;
    margin-bottom: 30px;
}

.login-label {
    color: #168cff;
    letter-spacing: 3px;
    font-size: 11px;
    font-weight: 800;
}

.login-box h1 {
    font-size: 40px;
    margin: 10px 0;
}

.login-box h1 span {
    color: #168cff;
}

.login-description {
    color: #64748b;
    margin-bottom: 30px;
}

.input-group {
    margin-bottom: 20px;
}

.input-group label {
    display: block;
    color: #cbd5e1;
    font-size: 13px;
    margin-bottom: 8px;
}

.input-group input {
    width: 100%;
    padding: 14px;
    border-radius: 8px;
    border: 1px solid #193552;
    background: #050b14;
    color: white;
    outline: none;
}

.input-group input:focus {
    border-color: #168cff;
}

.login-button {
    width: 100%;
    padding: 14px;
    border: none;
    border-radius: 8px;
    background: #168cff;
    color: white;
    font-weight: 800;
    cursor: pointer;
}

.login-message {
    color: #ff7777;
    margin-top: 15px;
    font-size: 13px;
}

.back-link {
    display: block;
    text-align: center;
    margin-top: 25px;
    color: #64748b;
    text-decoration: none;
}


/* =========================
   ADMIN DASHBOARD
========================= */

.admin-navbar {
    position: sticky;
    top: 0;
    z-index: 100;
    padding: 20px 7%;
    display: flex;
    justify-content: space-between;
    align-items: center;
    background: rgba(3,7,18,.9);
    backdrop-filter: blur(20px);
    border-bottom: 1px solid #193552;
}

.admin-actions {
    display: flex;
    align-items: center;
    gap: 15px;
}

.admin-actions span {
    color: #64748b;
}

.admin-actions button {
    padding: 9px 16px;
    border: 1px solid #193552;
    background: #09111e;
    color: white;
    border-radius: 7px;
    cursor: pointer;
}

.admin-main {
    max-width: 1100px;
    margin: auto;
    padding: 80px 25px;
}

.dashboard-heading p {
    color: #168cff;
    letter-spacing: 3px;
    font-size: 12px;
    font-weight: 800;
}

.dashboard-heading h1 {
    font-size: 50px;
    margin: 10px 0 50px;
}

.dashboard-heading h1 span {
    color: #168cff;
}

.admin-card {
    padding: 30px;
    margin-bottom: 25px;
    background: rgba(8,16,29,.9);
    border: 1px solid #193552;
    border-radius: 18px;
}

.admin-card h2 {
    margin-bottom: 8px;
}

.admin-card > p {
    color: #64748b;
}

.admin-category {
    display: flex;
    flex-wrap: wrap;
    gap: 10px;
    margin: 25px 0;
}

.admin-category-button {
    padding: 10px 16px;
    border-radius: 30px;
    border: 1px solid #193552;
    background: #050b14;
    color: #94a3b8;
    cursor: pointer;
}

.admin-category-button.active {
    background: #168cff;
    color: white;
    border-color: #168cff;
}

.big-upload {
    min-height: 220px;
    border: 2px dashed #22568a;
    border-radius: 15px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    cursor: pointer;
    transition: .3s;
}

.big-upload:hover {
    border-color: #168cff;
    background: rgba(22,140,255,.04);
}

.upload-icon {
    width: 60px;
    height: 60px;
    border-radius: 50%;
    background: rgba(22,140,255,.12);
    display: flex;
    align-items: center;
    justify-content: center;
    color: #168cff;
    font-size: 30px;
    margin-bottom: 15px;
}

.big-upload small {
    color: #64748b;
    margin-top: 8px;
}

.upload-status {
    margin-top: 15px;
    color: #168cff;
}

.admin-card-title {
    display: flex;
    justify-content: space-between;
    align-items: center;
}

.admin-card-title > strong {
    color: #168cff;
    font-size: 30px;
}

.admin-file-grid {
    display: grid;
    grid-template-columns: repeat(auto-fill,minmax(230px,1fr));
    gap: 15px;
    margin-top: 25px;
}

.admin-file {
    padding: 15px;
    background: #050b14;
    border: 1px solid #193552;
    border-radius: 10px;
}

.admin-file strong {
    display: block;
    white-space: nowrap;
    overflow: hidden;
    text-overflow: ellipsis;
}

.admin-file small {
    display: block;
    color: #64748b;
    margin: 7px 0;
}

.delete-button {
    width: 100%;
    padding: 8px;
    border: none;
    border-radius: 6px;
    background: #35151a;
    color: #ff7777;
    cursor: pointer;
}


/* =========================
   MOBILE
========================= */

@media(max-width:850px) {

    .navbar {
        padding: 18px 5%;
    }

    .navbar nav {
        display: none;
        position: absolute;
        top: 70px;
        left: 5%;
        right: 5%;
        padding: 20px;
        background: #09111e;
        border: 1px solid #193552;
        border-radius: 12px;
        flex-direction: column;
    }

    .navbar nav.show {
        display: flex;
    }

    .menu-button {
        display: block;
    }

    .hero-content {
        flex-direction: column;
        text-align: center;
    }

    .hero {
        padding-left: 5%;
        padding-right: 5%;
    }

    .section {
        padding-left: 5%;
        padding-right: 5%;
    }

    .about-container {
        flex-direction: column;
    }

    .portfolio-header {
        padding: 20px;
    }

}


@media(max-width:500px) {

    .profile-wrapper {
        width: 210px;
        height: 210px;
    }

    .hero h1 {
        font-size: 45px;
    }

    .section-heading h2 {
        font-size: 35px;
    }

    .file-grid {
        grid-template-columns: 1fr;
    }

    .login-box {
        padding: 30px 20px;
    }

    .dashboard-heading h1 {
        font-size: 38px;
    }

}
```
