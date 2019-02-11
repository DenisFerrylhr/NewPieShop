// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let angle = 0;

img = document.querySelector('.logo-img');

img.addEventListener('mouseenter', function () {
    angle = (angle + 15) % 360;
    img.classList.add('rotate' + angle);
});

img.addEventListener('mouseout', function () {
    img.classList.remove('rotate15');
    angle = 0;
});

window.addEventListener('resize', function () {
    let width = this.window.innerWidth;
    pies = document.querySelectorAll('.pie');

    if (width <= 992) {
        for (let i = 0; i < pies.length; i++) {
            pies[i].classList.remove('col-md-4');
            pies[i].classList.add('col-md-6');
        }
    }

    if (width > 992) {
        for (let i = 0; i < pies.length; i++) {
            pies[i].classList.remove('col-md-6');
            pies[i].classList.add('col-md-4');
        }
    }
});