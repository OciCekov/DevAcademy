function onLoad() {

    function moveDiv(degrees, divsArr) {
        for (var div in divsArr) {
            degrees = degrees + 5 / 2;
            var radius = 150,
                centerX = 200,
                centerY = 200,
                x = Math.floor(centerX + (radius * Math.cos(degrees / 2))),
                y = Math.floor(centerY + (radius * Math.sin(degrees / 2)));
            divsArr[div].style.top = x + "px";
            divsArr[div].style.left = y + "px";
        }

        setTimeout(function () {
            moveDiv(degrees, divsArr);
        }, 40);
        // When this was 100 it was really ugly.
    }

    var divs = [5],
        bodyElem = document.getElementsByTagName('body')[0];

    for (var i = 0; i < 5; i++) {
        divs[i] = document.createElement('div');
        divs[i].innerHTML = 'Pesho';
        divs[i].style.width = '50px';
        divs[i].style.heigth = '100px';
        divs[i].style.border = '1px solid pink';
        divs[i].style.color = 'green';
        divs[i].style.position = 'absolute';
        bodyElem.appendChild(divs[i]);
    }
    moveDiv(1, divs)
}