

window.addEventListener("load", function () {

    const loader = document.getElementById("loader");

    setTimeout(function () {

        loader.style.opacity = "0";

        setTimeout(function () {
            loader.style.display = "none";
        }, 600);

    }, 700);

});


/* ================================
   MOBILE MENU
================================ */

function toggleMenu() {

    const nav = document.getElementById("navMenu");

    nav.classList.toggle("active");

}


/* ================================
   CLOSE MOBILE MENU
================================ */

document.querySelectorAll("#navMenu a").forEach(function(link) {

    link.addEventListener("click", function() {

        document
            .getElementById("navMenu")
            .classList.remove("active");

    });

});


/* ================================
   SCROLL ANIMATION
================================ */

const cards = document.querySelectorAll(
    ".category-card, .about-card, .info-card"
);

const observer = new IntersectionObserver(
    function(entries) {

        entries.forEach(function(entry) {

            if (entry.isIntersecting) {

                entry.target.style.opacity = "1";
                entry.target.style.transform = "translateY(0)";

            }

        });

    },
    {
        threshold: 0.15
    }
);


cards.forEach(function(card) {

    card.style.opacity = "0";
    card.style.transform = "translateY(40px)";
    card.style.transition =
        "opacity 0.7s ease, transform 0.7s ease";

    observer.observe(card);

});
```
