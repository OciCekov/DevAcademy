window.onload = function () {
    var input = [
        {
            title: "Some Course",
            dates: ["Day 14-06-2014", "Day 15.06.2014"]
        },
        {
            title: "Athor Course",
            dates: ["Day 14-06-2014", "Day 15.06.2014"]
        },
        {
            title: "And some other",
            dates: ["Day 14-06-2014", "Day 15.06.2014"]
        },
        {
            title: "And this",
            dates: ["Day 14-06-2014", "Day 15.06.2014"]
        },
        {
            title: "And that",
            dates: ["Day 14-06-2014", "Day 15.06.2014"]
        },
        {
            title: "And also this",
            dates: ["Day 14-06-2014", "Day 15.06.2014"]
        },
        {
            title: "Well that's it",
            dates: ["Day 14-06-2014", "Day 15.06.2014"]
        }
    ];

    var inputListContainer = document.getElementById('input');

    var inputListTemplate = Handlebars.compile((document.getElementById('input-template')).innerHTML);

    // empty the container
    while (inputListContainer.firstChild) {
        inputListContainer.removeChild(inputListContainer.firstChild);
    }

    inputListContainer.innerHTML = inputListTemplate({
        input: input
    });
};
