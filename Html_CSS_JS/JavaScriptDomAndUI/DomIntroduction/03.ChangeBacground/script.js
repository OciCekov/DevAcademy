function onChangeColorClick() {
    var userChoice = document.getElementsByTagName('input')[0].value;

    document.getElementsByTagName('body')[0].style.backgroundColor = userChoice;
}