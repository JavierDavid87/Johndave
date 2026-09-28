```javascript
const categories = document.querySelectorAll(".category");

let currentCategory = "quiz";

const categoryNames = {
    quiz: "Quiz",
    longquiz: "Long Quiz",
    midterms: "Midterms",
    finals: "Finals",
    activities: "Activities",
    projects: "Projects"
};


/* =========================
   MOBILE MENU
========================= */

function toggleMenu() {

    document
        .getElementById("nav")
        .classList.toggle("show");

}


/* =========================
   TYPING ANIMATION
========================= */

const typing =
    document.getElementById("typing");

const texts = [
    "Computer Science Student",
    "Future Software Developer",
    "Web Developer",
    "Programming Learner"
];

let textNumber = 0;
let letterNumber = 0;
let deleting = false;


function typeText() {

    const text = texts[textNumber];

    if (!deleting) {

        typing.textContent =
            text.substring(0, letterNumber + 1);

        letterNumber++;

        if (letterNumber === text.length) {

            deleting = true;

            setTimeout(typeText, 1500);

            return;
        }

    } else {

        typing.textContent =
            text.substring(0, letterNumber - 1);

        letterNumber--;

        if (letterNumber === 0) {

            deleting = false;

            textNumber++;

            if (textNumber >= texts.length) {
                textNumber = 0;
            }

        }

    }

    setTimeout(
        typeText,
        deleting ? 45 : 90
    );

}

typeText();


/* =========================
   CATEGORY
========================= */

categories.forEach(button => {

    button.addEventListener("click", () => {

        categories.forEach(item =>
            item.classList.remove("active")
        );

        button.classList.add("active");

        currentCategory =
            button.dataset.category;

        document.getElementById(
            "categoryTitle"
        ).textContent =
            categoryNames[currentCategory];

        loadPublicFiles();

    });

});


/* =========================
   LOAD PUBLIC FILES
========================= */

async function loadPublicFiles() {

    const grid =
        document.getElementById("fileGrid");

    grid.innerHTML =
        `<div class="loading">
            Loading files...
        </div>`;


    if (!window.portfolioDB) {

        grid.innerHTML =
            `<div class="empty">
                Firebase is not configured.
            </div>`;

        return;

    }


    const {
        collection,
        getDocs
    } = window.firestoreFunctions;


    try {

        const snapshot =
            await getDocs(
                collection(
                    window.portfolioDB,
                    "portfolioFiles"
                )
            );


        const files = [];


        snapshot.forEach(document => {

            const data =
                document.data();

            if (
                data.category === currentCategory
            ) {

                files.push(data);

            }

        });


        files.sort(
            (a,b) =>
                (b.createdAt || 0) -
                (a.createdAt || 0)
        );


        displayFiles(files);


    } catch(error) {

        console.error(error);

        grid.innerHTML =
            `<div class="empty">
                Unable to load files.
            </div>`;

    }

}


/* =========================
   DISPLAY
========================= */

function displayFiles(files) {

    const grid =
        document.getElementById("fileGrid");


    grid.innerHTML = "";


    document.getElementById(
        "fileCount"
    ).textContent =
        files.length;


    if (files.length === 0) {

        grid.innerHTML =
            `<div class="empty">
                No files uploaded yet.
            </div>`;

        return;

    }


    files.forEach(file => {

        const card =
            document.createElement("div");

        card.className =
            "file-card";


        const image =
            file.type &&
            file.type.startsWith("image/");


        card.innerHTML = `

            <div class="file-preview">

                ${
                    image

                    ?

                    `<img
                        src="${file.url}"
                        alt="Portfolio file"
                    >`

                    :

                    `<div class="file-icon">
                        📄
                    </div>`
                }

            </div>


            <div class="file-info">

                <h4 title="${escapeHTML(file.name)}">
                    ${escapeHTML(file.name)}
                </h4>

                <p>
                    ${formatBytes(file.size)}
                </p>

                <a
                    class="file-action"
                    href="${file.url}"
                    target="_blank"
                    rel="noopener">

                    View / Download

                </a>

            </div>
        `;


        grid.appendChild(card);

    });

}


/* =========================
   HELPERS
========================= */

function formatBytes(bytes) {

    if (!bytes) return "";

    const units =
        ["Bytes","KB","MB","GB"];

    const i =
        Math.floor(
            Math.log(bytes) /
            Math.log(1024)
        );

    return (
        (bytes /
        Math.pow(1024,i))
        .toFixed(1)
        + " "
        + units[i]
    );

}


function escapeHTML(text) {

    return String(text)
        .replace(/&/g,"&amp;")
        .replace(/</g,"&lt;")
        .replace(/>/g,"&gt;")
        .replace(/"/g,"&quot;")
        .replace(/'/g,"&#039;");

}


/* INITIAL */

loadPublicFiles();
```
