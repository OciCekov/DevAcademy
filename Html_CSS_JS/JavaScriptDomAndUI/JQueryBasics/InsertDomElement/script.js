function insertBefore(elementId, elementTag, innerText) {
    var element = $(elementTag);
    element.text(innerText);
    $('#' + elementId).before(element);
}

function insertAfter(elemntId, elementTag, innerText) {
    var element = $(elementTag);
    element.text(innerText);
    $('#' + elemntId).after(element);
}

window.onload = function () {

    insertBefore('first', '<div>', 'something');
    insertAfter('last', '<p>', 'Else');
}