/*globals document, requestAnimationFrame*/
(function () {
    "use strict";
    var canvas = document.getElementById('the-canvas'),
        ctx = canvas.getContext('2d'),

        circleX = 30,
        circleY = canvas.clientHeight / 2,
        r = 20,
        changeX = 5,
        changeY = 5;

    ctx.strokeStyle = "green";
    ctx.lineWidth = 4;

    function animationFrame() {
        ctx.clearRect(0, 0, canvas.clientWidth, canvas.clientHeight);
        ctx.beginPath();
        if (circleX + r === canvas.clientWidth || circleX - r === 0) {
            changeX *= -1;
        }
        if (circleY + r === canvas.clientHeight || circleY - r === 0) {
            changeY *= -1;
        }
        circleX += changeX;
        circleY += changeY;
        ctx.arc(circleX, circleY, r, 0, 2 * Math.PI);
        ctx.fill();
        ctx.stroke();
        requestAnimationFrame(animationFrame);
    }

    animationFrame();
})();