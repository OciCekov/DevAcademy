/*globals document, window, alert*/

function createCircle(cX, cY, r, color) {

    var circle = document.createElementNS(svgNs, 'circle');
    circle.setAttribute('cx', cX);
    circle.setAttribute('cy', cY);
    circle.setAttribute('r', r);
    circle.setAttribute('fill', color);
    return circle;
}

function writeText(x, y, text, fontSize, fontColor, fontWeight, fontStyle) {

    var textField = document.createElementNS(svgNs, 'text');
    textField.setAttribute('x', x);
    textField.setAttribute('y', y);
    textField.setAttribute('font-size', fontSize);
    textField.setAttribute('font-weight', fontWeight);
    textField.setAttribute('font-family', fontStyle);
    textField.setAttribute('fill', fontColor);
    textField.textContent = text;
    return textField;
}

function createRect(x, y, width, height, color) {
    var rectangle = document.createElementNS(svgNs, 'rect');
    rectangle.setAttribute('x', x);
    rectangle.setAttribute('y', y);
    rectangle.setAttribute('width', width);
    rectangle.setAttribute('height', height);
    rectangle.setAttribute('fill', color);
    return rectangle;
}

function createPath(start, stroke, fill, strokeWidth) {
    var path;
    path = document.createElementNS(svgNs, 'path');
    path.setAttribute('d', start);
    path.setAttribute('stroke', stroke);
    path.setAttribute('fill', fill);
    path.setAttribute('stroke-width', strokeWidth);
    return path;
}

function createImage(x, y, width, height, src) {
    var image;
    image = document.createElementNS(svgNs, 'image');
    image.setAttribute('x', x);
    image.setAttribute('y', y);
    image.setAttribute('width', width);
    image.setAttribute('height', height);
    image.setAttributeNS('http://www.w3.org/1999/xlink', 'xlink:href', src);
    return image;
}