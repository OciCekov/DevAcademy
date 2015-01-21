define(function () {
    var collection;
    collection = {
        students: [
            {fname: "Pesho", lname: "Zdravkov", age: 17, averageMarks: 5.25},
            {fname: "Gosho", lname: "Georgiev", age: 22, averageMarks: 4.46},
            {fname: "Todorina", lname: "Georgieva", age: 28, averageMarks: 4.26},
            {fname: "Georgi", lname: "Dimitrov", age: 24, averageMarks: 5.65},
            {fname: "Simeon", lname: "Atanasov", age: 21, averageMarks: 5.15},
            {fname: "Stamatka", lname: "Stoqnova", age: 45, averageMarks: 3.98}

        ],
        animals: [
            {animal: "donkey", species: "mamal", legsCount: 4},
            {animal: "dolphin", species: "mamal", legsCount: 0},
            {animal: "dog", species: "mamal", legsCount: 4},
            {animal: "spider", species: "evil", legsCount: 8},
            {animal: "centipede", species: "evil", legsCount: 100},
            {animal: "mosquito", species: "evil", legsCount: 6}
        ],
        books: [
            // if (time === true) { check them }  http://jsbooks.revolunet.com/ especially this for cats :D
            {title: "Cofeescript cookbook", author: "Muliyple ownership"},
            {title: "Javascript Guide", author: "Mozilla Developer Network"},
            {title: "Javascript for cats", author: "Max Ogden"}
        ]
    };
    return collection;
})