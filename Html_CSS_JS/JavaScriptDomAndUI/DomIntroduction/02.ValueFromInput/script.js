function onCheckInputClick() {
    var input = document.getElementById('input').value;

    if (input == undefined) { // It's with "==" on purpose.
        console.log("Enter something please"); // Just to be strict with assignment
        return document.getElementById('output').value = "Enter something please";
    }

    console.log(input);
    document.getElementById('output').value = input;
}