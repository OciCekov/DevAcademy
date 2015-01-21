/*globals document, window, alert*/

window.onload = function () {
    svgNs = 'http://www.w3.org/2000/svg';
    var theSvg = document.getElementById('theSvg');

    var m = writeText(20, 110, 'M', 50, '#3E3F37', 'bold', 'Arial');
    theSvg.appendChild(m);
    // First circle
    var circle = createCircle(170, 100, 80, '#3E3F37');
    theSvg.appendChild(circle);

    // The ugly leaf looking thingy
    var path = createPath('M 170 60 Q 120 130 170 115', 'none', '#5EB14A');
    theSvg.appendChild(path);
    path = createPath('M 170 60 Q 220 130 170 115', 'none', '#449644');
    theSvg.appendChild(path);

    var e = writeText(20, 200, 'E', 50, '#282827', 'bold', 'Arial');
    theSvg.appendChild(e);

    // Second circle
    circle = createCircle(170, 180, 80, '#282827');
    theSvg.appendChild(circle);
    var express = writeText(103, 181, 'express', 40, 'white', 'normal', 'Arial');
    theSvg.appendChild(express);

    var a = writeText(20, 290, 'A', 50, '#E23337', 'bold', 'Arial');
    theSvg.appendChild(a);

    // Third circle
    circle = createCircle(170, 260, 80, '#E23337');
    theSvg.appendChild(circle);

    // The 'A' inside the red circle
    path = createPath('M135 280 L 130 225 L170 215 L213 225 L205 280', '#B3B3B2', 'none', '5');
    theSvg.appendChild(path);
    path = createPath('M150 280 L 170 231 L190 280', 'white', 'none', '8');
    theSvg.appendChild(path);

    var n = writeText(20, 380, 'N', 50, '#8EC74E', 'bold', 'Arial');
    theSvg.appendChild(n);

    // Last circle
    circle = createCircle(170, 340, 80, '#8EC74E');
    theSvg.appendChild(circle);

    var node = createImage(120, 315, 100, 50, 'imgs/node.jpg');
    theSvg.appendChild(node);
};