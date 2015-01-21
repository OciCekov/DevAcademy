(function () {
    require.config({
        paths: {
            "underscore": "libs/underscore",
            "collections": "collections"
        }
    });

    // And yes I admit all this in here are annoying.
    require(["firstNameBeforeLast", "betweenAges", "highestMarks",
            "spieciesAndLegs", "totalLegs", "mostPopularAuthor", "mostCommonNames"],
        function (task1, task2, task3, task4, task5, task6, task7) {
        var resultPlace = document.getElementById("result");
        document.getElementById("task1").addEventListener("click", onTask1ButtonClick, false);

        // TODO this is ugly, fux it!
        function onTask1ButtonClick() {
            resultPlace.innerHTML = task1;
        }

        document.getElementById("task2").addEventListener("click", onTask2ButtonClick, false);

        function onTask2ButtonClick() {
            resultPlace.innerHTML = task2;
        }

        document.getElementById("task3").addEventListener("click", onTask3ButtonClick, false);

        function onTask3ButtonClick() {
            resultPlace.innerHTML = task3;
        }

        document.getElementById("task4").addEventListener("click", onTask4ButtonClick, false);

        function onTask4ButtonClick() {
            resultPlace.innerHTML = task4;
        }

        document.getElementById("task5").addEventListener("click", onTask5ButtonClick, false);

        function onTask5ButtonClick() {
            resultPlace.innerHTML = task5;
        }

        document.getElementById("task6").addEventListener("click", onTask6ButtonClick, false);

        function onTask6ButtonClick() {
            resultPlace.innerHTML = task6;
        }

        document.getElementById("task7").addEventListener("click", onTask7ButtonClick, false);

        function onTask7ButtonClick() {
            resultPlace.innerHTML = task7;
        }
    })
}());
